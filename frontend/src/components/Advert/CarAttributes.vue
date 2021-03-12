<template>
  <div
    class="tw-flex tw-justify-between tw-my-2 tw-text-lg tw-border-b tw-border-gray-200"
  >
    <p class="tw-text-gray-500">{{ name }}</p>
    <p class="tw-font-bold">{{ value }}</p>
  </div>
</template>

<script>
export default {
  name: "CarAttributes",
  props: {
    name: {
      type: String,
      required: true,
    },
    value: {
      type: String,
      required: true,
    },
  },
};
</script>

<style></style>
