<template>
  <input
    type="text"
    class="tw-border-2 tw-border-gray-300 tw-px-2 tw-py-1 tw-mr-8 tw-pr-8"
    :value="modelValue"
    @input="$emit('update:modelValue', $event.target.value)"
  />
</template>

<script>
export default {
  name: "Input",
  props: {
    modelValue: String,
  },
  setup(props) {
    console.log(props.modelValue);
  },
};
</script>
