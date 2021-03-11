<template>
  <div>all adverts</div>
</template>

<script>
import { computed } from "vue";
export default {
  name: "Adverts",
  props: {
    cars: {
      type: Array,
      default: () => {},
    },
  },

  setup(props, { root }) {
    const counter = computed(() => root.$store.state.adverts);

    console.log(counter);

    console.log(props.cars);
  },
};
</script>

<style></style>
