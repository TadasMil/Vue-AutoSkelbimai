<template>
  <div class="tw-flex tw-flex-col">
    <div class="tw-flex">
      <div class="tw-flex tw-flex-col tw-flex-1">
        <div
          v-for="select in options"
          :key="select"
          class="tw-w-full tw-mx-auto tw-flex tw-flex-col tw-mb-4"
        >
          <p class="tw-text-lg">{{ select.name }}:</p>
          <Select
            v-model="inputValues[select.model]"
            :data="select.data"
            :isDataFrom="false"
          />
        </div>
      </div>
      <div class="tw-flex tw-flex-col tw-flex-1">
        <div
          v-for="select in optionsFrom"
          :key="select"
          class="tw-w-full tw-mx-auto tw-mb-4 tw-ml-8"
        >
          <p class="tw-text-lg">{{ select.name }}:</p>
          <div class="tw-flex">
            <Select
              :data="select.from"
              :isDataFrom="true"
              v-model.number="inputValues[select.model.from]"
            />
            <Select
              :data="select.to"
              :isDataFrom="true"
              from="to"
              v-model.number="inputValues[select.model.to]"
            />
          </div>
        </div>
      </div>
    </div>
    <div>
      <hr class="tw-text-purple tw-my-4" />
      <div class="tw-flex tw-justify-center">
        <Button
          name="Ieškoti"
          class="tw-w-8/12 tw-mt-2 tw-mb-4 tw-font-bold"
          @click="formSubmit"
        />
      </div>
    </div>
  </div>
</template>

<script>
import { onMounted, reactive, toRefs, watch } from "vue";
import { useRouter } from "vue-router";
import { options, optionsFrom, inputTypes } from "../../utilities/options.js";
import axios from "axios";

import Select from "./Select.vue";
import Button from "../Buttons/Button.vue";

export default {
  name: "Form",
  components: {
    Select,
    Button,
  },
  setup() {
    const state = reactive({
      options,
      optionsFrom,
      inputValues: { ...inputTypes },
    });

    const router = useRouter();

    onMounted(() => {
      getCarsAttributes();
    });

    watch(
      () => state.inputValues.name,
      (selected, oldValue) => {
        if (selected !== oldValue) {
          state.inputValues.model = "";
          getModelBySelectedBrand();
        }
      }
    );

    const getModelBySelectedBrand = async () => {
      await axios
        .get("https://localhost:44315/api/models", {
          params: { brand: state.inputValues.name },
        })
        .then((res) => {
          state.options.model.data = res.data;
        })
        .catch((err) => console.log(err));
    };

    const getCarsAttributes = async () => {
      await axios
        .get("https://localhost:44315/api/attributes")
        .then((response) => {
          console.log(response.data.brands);
          state.options.brand.data = response.data.brands;
          state.options.bodyType.data = response.data.bodyTypes;
          state.options.color.data = response.data.colors;
          state.options.firstRegistration.data =
            response.data.firstRegistrations;
          state.options.city.data = response.data.cities;
        });
    };

    const formSubmit = async () => {
      // await axios
      //   .post("https://localhost:44315/api/cars", state.inputValues, {
      //     headers: { "Content-Type": "application/json" },
      //   })
      //   .then((res) => {
      //     console.log(res.data);
      //     const cars = [...res.data];
      router.push({ name: "Adverts" });
      //   })
      //   .catch((err) => console.log(err));
    };

    return { ...toRefs(state), formSubmit };
  },
};
</script>
