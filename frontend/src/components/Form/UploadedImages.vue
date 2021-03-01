<template>
  <div class="tw-mr-2">
    <img :src="image" alt="" class="tw-object-contain tw-h-40" />
  </div>
</template>

<script>
export default {
  name: "UploadedImages",
  props: {
    image: {
      type: String,
      required: true,
    },
  },
};
</script>

<style></style>
