<template>
  <button
    class="tw-rounded-lg tw-py-1 tw-px-4 tw-text-white tw-bg-purple tw-text-xl tw-outline-none tw-cursor-pointer"
    v-bind="$attrs"
  >
    {{ name }}
  </button>
</template>

<script>
export default {
  name: "Button",
  props: {
    name: {
      type: String,
      required: true,
    },
  },
};
</script>

<style></style>
