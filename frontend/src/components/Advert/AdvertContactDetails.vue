<template>
  <div class="tw-bg-gray-200 tw-p-4 tw-mt-2">
    <div class="tw-flex  tw-text-lg">
      <p>Miestas:</p>
      <p class="tw-font-bold tw-ml-2">{{ city }}</p>
    </div>

    <div class="tw-flex">
      <div
        class="tw-flex tw-mt-4 tw-bg-purple tw-text-white  tw-rounded-md tw-w-1/2 tw-mr-2 tw-p-2 tw-cursor-pointer"
      >
        <XIcon icon="phone" class="tw-w-6 tw-h-6" />
        <p class="tw-ml-2">{{ phone }}</p>
      </div>
      <div
        class="tw-flex tw-mt-4 tw-bg-purple tw-text-white tw-rounded-md tw-w-1/2 tw-p-2 tw-cursor-pointer"
      >
        <XIcon icon="email" class="tw-w-6 tw-h-6" />
        <p class="tw-ml-2">{{ email }}</p>
      </div>
    </div>
  </div>
</template>

<script>
import XIcon from "../Icons/XIcon.vue";

export default {
  name: "AdvertContactDetails",
  components: {
    XIcon,
  },
  props: {
    city: {
      type: String,
      required: true,
    },
    phone: {
      type: String,
      required: true,
    },
    email: {
      type: String,
      required: true,
    },
  },
};
</script>
