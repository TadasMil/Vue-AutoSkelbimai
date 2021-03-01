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
          v-model="inputValues[select.model]"
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
import { options, optionsFrom } from "../../utilities/options";
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
    const textInputs = [
      optionsFrom.price,
      optionsFrom.power,
      optionsFrom.run,
      optionsFrom.volume,
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
      inputValues: {
        brand: "",
        model: "",
        fuelType: "",
        wheelPosition: "",
        city: "",
        gear: "",
        wheels: "",
        bodyType: "",
        color: "",
        firstRegistration: "",
        description: "",
        price: "",
        power: "",
        miles: "",
        year: "",
        volume: "",
        seats: "",
        phone: "",
        email: "",
      },
      brands: { ...options.brand },
      models: { ...options.model },
      images: [],
      selectionInputs: [
        options.gear,
        options.wheels,
        options.fuelType,
        options.wheelPosition,
        optionsFrom.numberOfSeats,
        optionsFrom.year,
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
      () => state.inputValues.brand,
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
          `https://vpic.nhtsa.dot.gov/api/vehicles/getmodelsformake/${state.inputValues.brand}?format=json`
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
          model: state.inputValues.model,
          fuelType: state.inputValues.fuelType,
          wheelPosition: state.inputValues.wheelPosition,
          city: state.inputValues.city,
          gear: state.inputValues.gear,
          wheels: state.inputValues.wheels,
          bodyType: state.inputValues.bodyType,
          color: state.inputValues.color,
          firstRegistration: state.inputValues.firstRegistration,
          description: "smthstate..",
          price: state.inputValues.price,
          power: state.inputValues.power,
          miles: state.inputValues.miles,
          year: state.inputValues.year,
          volume: state.inputValues.volume,
          seats: state.inputValues.numberOfSeats,
          name: state.inputValues.brand,
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
    };
  },
};
</script>
