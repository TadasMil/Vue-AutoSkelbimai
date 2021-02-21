<template>
  <div class="tw-flex tw-items-center tw-mx-2">
    <router-link :to="to">
      <div class="tw-flex tw-items-center">
        <Icon :icon="icon" class="tw-text-purple tw-w-6 tw-h-6 tw-mr-2" />
        <p class="tw-text-xl">{{ name }}</p>
      </div>
    </router-link>
  </div>
</template>

<script>
import Icon from "../Icons/XIcon.vue";

export default {
  name: "NavLink",
  components: {
    Icon,
  },
  props: {
    name: {
      type: String,
      required: true,
    },
    icon: {
      type: String,
      required: true,
    },
    to: {
      type: Object,
      required: true,
    },
  },
};
</script>

<style></style>
