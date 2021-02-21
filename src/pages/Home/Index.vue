<template>
  <div class="tw-flex tw-flex-col">
    <h3 class="tw-text-2xl tw-my-4 tw-font-bold">
      Automobilių skelbimų paieška
    </h3>
    <Form />
  </div>
</template>

<script>
import Form from "../../components/Form/Form.vue";

export default {
  name: "Home",
  components: {
    Form,
  },
};
</script>
