<template>
  <div class="tw-flex tw-items-center tw-mt-4">
    <hr class="tw-w-full tw-border-gray-400" />
    <p class="tw-mx-8 tw-text-center tw-font-bold">
      {{ name }}
    </p>
    <hr class="tw-w-full tw-border-gray-400" />
  </div>
</template>

<script>
export default {
  name: "AttributeLineTitle.vue",
  props: {
    name: {
      type: String,
      default: "Automobilio informaciją",
    },
  },
};
</script>

<style></style>
