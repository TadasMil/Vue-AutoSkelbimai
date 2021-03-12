<template>
  <div class="tw-border-t tw-border-b tw-border-gray-300 tw-my-4">
    <h3 class="tw-text-purple tw-text-2xl tw-font-bold tw-text-center tw-py-2">
      {{ price }} €
    </h3>
  </div>
</template>

<script>
export default {
  name: "AdvertPrice",
  props: {
    price: {
      type: Number,
      required: true,
    },
  },
};
</script>

<style></style>
