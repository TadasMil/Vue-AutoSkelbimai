<template>
  <div>
    <p>{{ description }}</p>
  </div>
</template>

<script>
export default {
  name: "AdvertDescription",
  props: {
    description: {
      type: String,
      default: "Komentarų nėra",
    },
  },
};
</script>

<style></style>
