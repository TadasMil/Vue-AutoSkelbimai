<template>
  <div class="tw-border-b-4 tw-border-gray-300">
    <h3 class="tw-text-2xl tw-my-4 tw-font-bold">
      {{ name }}
    </h3>
  </div>
</template>

<script>
export default {
  name: "PageTitle",
  props: {
    name: {
      type: String,
      required: true,
    },
  },
};
</script>

<style></style>
