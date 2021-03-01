<template>
  <div class="tw-flex tw-flex-col">
    <PageTitle name="Automobilių skelbimų paieška" />
    <Form />
  </div>
</template>

<script>
import Form from "../../components/Form/Form.vue";
import PageTitle from "../../components/Title/PageTitle.vue";

export default {
  name: "Home",
  components: {
    Form,
    PageTitle,
  },
};
</script>
