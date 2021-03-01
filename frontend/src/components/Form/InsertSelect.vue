<template>
  <select
    class="select tw-border-2 tw-border-gray-300 tw-px-2 tw-py-1"
    :value="modelValue"
    @input="$emit('update:modelValue', $event.target.value)"
  >
    <option value="" selected hidden>-----</option>
    <option v-for="selection in data" :key="selection">{{
      selection.name || selection
    }}</option>
  </select>
</template>

<script>
export default {
  name: "InsertSelect",

  props: {
    data: {
      type: Array,
      default: () => {},
    },
    modelValue: String,
  },
};
</script>

<style></style>
