<template>
  <div class="tw-flex tw-items-center tw-mx-2">
    <router-link :to="to">
      <button
        class="tw-rounded-xl tw-py-1 tw-px-4 tw-text-white tw-bg-purple tw-text-xl tw-outline-none tw-cursor-pointer"
      >
        {{ name }}
      </button>
    </router-link>
  </div>
</template>

<script>
export default {
  name: "LinkButton",
  props: {
    to: {
      type: Object,
      required: true,
    },
    name: {
      type: String,
      default: "",
    },
  },
};
</script>

<style></style>
