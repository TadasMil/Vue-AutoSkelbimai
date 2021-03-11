<template>
  <div>
    <div class="tw-flex tw-flex-wrap tw-items-between">
      <div
        v-for="select in selectionInputs"
        :key="select.id"
        class="tw-flex tw-flex-col tw-w-2/6 tw-py-2"
      >
        <label>{{ select.name }}</label>
        <InsertSelect
          :data="select.data || select.from"
          v-model="
            inputValues[select.model.from ? select.model.from : select.model]
          "
        />
      </div>
      <div
        v-for="select in textInputs"
        :key="select"
        class="tw-flex tw-flex-col tw-w-2/6 tw-py-2"
      >
        <label>{{ select.name }}</label>
        <Input v-model="inputValues[select.model]" />
      </div>
      <!-- CHANGE THIS -->
      <div
        v-for="select in numbers"
        :key="select"
        class="tw-flex tw-flex-col tw-w-2/6 tw-py-2"
      >
        <label>{{ select.name }}</label>
        <Input v-model.number="inputValues[select.model.from]" />
      </div>
    </div>
    <InsertImage @insertImage="handleImage" :images="images" />
    <Button
      name="Pridėti skelbimą"
      class="tw-my-4 tw-float-right"
      @click="submitForm"
    />
  </div>
</template>

<script>
import { onMounted, reactive, toRefs, watch, watchEffect } from "vue";
import axios from "axios";
import { options, optionsFrom, inputTypes } from "../../utilities/options";
import { useModelOrBrand } from "../../composables/useModelOrBrand.js";

import InsertSelect from "./InsertSelect.vue";
import InsertImage from "./InsertImage.vue";
import Input from "./Input.vue";
import Button from "../Buttons/Button.vue";

export default {
  name: "InsertForm",
  components: {
    InsertSelect,
    Input,
    InsertImage,
    Button,
  },

  setup() {
    //REFACTOR THE NUMBERS ARRAY
    const numbers = [
      optionsFrom.price,
      optionsFrom.power,
      optionsFrom.run,
      optionsFrom.volume,
      optionsFrom.seats,
      optionsFrom.year,
    ];

    const textInputs = [
      options.firstRegistration,
      options.city,
      options.bodyType,
      options.color,
      {
        name: "El. paštas:",
        model: "email",
      },
      {
        name: "Tel. Numeris:",
        model: "phone",
      },
    ];

    const state = reactive({
      inputValues: { ...inputTypes },
      brands: { ...options.brand },
      models: { ...options.model },
      images: [],
      selectionInputs: [
        options.gear,
        options.wheels,
        options.fuelType,
        options.wheelPosition,
      ],
    });

    onMounted(async () => {
      await getBrands();
    });

    watchEffect(() => {
      if (state.brands && state.models) {
        state.selectionInputs.unshift(state.models);
        state.selectionInputs.unshift(state.brands);
      }
    });

    watch(
      () => state.inputValues.name,
      (selected, oldValue) => {
        if (selected !== oldValue) {
          getModels();
        }
      }
    );

    const getBrands = async () => {
      await axios
        .get(
          "https://vpic.nhtsa.dot.gov/api/vehicles/GetMakesForVehicleType/car?format=json"
        )
        .then((response) => {
          state.brands.data = useModelOrBrand(response.data.Results, true);
        });
    };

    const getModels = async () => {
      await axios
        .get(
          `https://vpic.nhtsa.dot.gov/api/vehicles/getmodelsformake/${state.inputValues.name}?format=json`
        )
        .then((response) => {
          state.models.data = useModelOrBrand(response.data.Results, false);
        });
    };

    const handleImage = (e) => {
      const selectedImage = e.target.files[0];
      console.log(selectedImage);
      createBase64Image(selectedImage);
    };

    const createBase64Image = (fileObject) => {
      const reader = new FileReader();

      reader.onload = (e) => {
        const encodedImage = e.target.result.replace(/\s/g, "");
        const newImage = {
          name: encodedImage,
        };
        state.images.push(newImage);
      };

      reader.readAsDataURL(fileObject);
    };

    const submitForm = async () => {
      const newAdvert = {
        phoneNumber: state.inputValues.phone,
        email: state.inputValues.email,
        car: {
          ...state.inputValues,
          images: state.images,
        },
      };

      await axios
        .post("https://localhost:44315/api/adverts", newAdvert)
        .then((response) => {
          console.log(response);
        })
        .catch((err) => console.log(err));
    };

    return {
      ...toRefs(state),
      textInputs,
      handleImage,
      submitForm,
      numbers,
    };
  },
};
</script>
