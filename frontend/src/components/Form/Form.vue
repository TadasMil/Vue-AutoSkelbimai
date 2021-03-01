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
          <Select :data="select.data" :isDataFrom="false" />
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
            <Select :data="select.from" :isDataFrom="true" />
            <Select :data="select.to" :isDataFrom="true" from="to" />
          </div>
        </div>
      </div>
    </div>
    <div>
      <hr class="tw-text-purple tw-my-4" />
      <div class="tw-flex tw-justify-center">
        <Button name="Ieškoti" class="tw-w-8/12 tw-mt-2 tw-mb-4 tw-font-bold" />
      </div>
    </div>
  </div>
</template>

<script>
import { reactive, toRefs } from "vue";
import { options, optionsFrom } from "../../utilities/options.js";
import Select from "./Select.vue";
import Button from "../Buttons/Button.vue";

export default {
  name: "Form",
  components: {
    Select,
    Button,
  },
  setup() {
    const state = reactive({ options, optionsFrom });

    return { ...toRefs(state) };
  },
};
</script>
