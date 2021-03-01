<template>
  <div>
    <PageTitle name="Nuotraukos" />
    <div class="tw-flex tw-my-4 tw-flex-wrap">
      <UploadedImages
        v-for="image in images"
        :key="image"
        :image="image.name"
      />
    </div>
    <label
      for="imageUpload"
      class="tw-font-bold tw-text-lg tw-mt-4 tw-p-8 tw-bg-gray-200 tw-w-full tw-flex tw-justify-center tw-border-black tw-border tw-border-dashed"
      >Įkelti nuotrauką</label
    >
    <input
      type="file"
      id="imageUpload"
      @change="$emit('insertImage', $event)"
      accept="image/*"
      class="tw-hidden"
    />
  </div>
</template>

<script>
import PageTitle from "../Title/PageTitle.vue";
import UploadedImages from "./UploadedImages.vue";

export default {
  name: "InsertImage",
  components: {
    PageTitle,
    UploadedImages,
  },
  props: {
    images: {
      type: Array,
      required: true,
    },
  },
};
</script>
