<template>
  <div class="tw-flex tw-flex-col">
    <PageTitle name="Pridėti skelbimą" />
    <InsertForm />
  </div>
</template>

<script>
import PageTitle from "../../components/Title/PageTitle.vue";
import InsertForm from "../../components/Form/InsertForm.vue";

export default {
  name: "NewAdvert",
  components: {
    PageTitle,
    InsertForm,
  },
};
</script>

<style></style>
