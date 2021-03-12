<template>
  <div>
    <Advert
      v-for="advert in adverts.adverts"
      :key="advert.id"
      v-bind="advert"
    />
  </div>
</template>

<script>
import { computed, reactive, toRefs } from "vue";
import { useStore } from "vuex";

import Advert from "../../components/Advert/Advert.vue";

export default {
  name: "Adverts",
  components: {
    Advert,
  },
  setup() {
    const store = useStore();

    const state = reactive({
      adverts: computed(() => store.state.adverts),
    });

    console.log(state.adverts);

    return { ...toRefs(state) };
  },
};
</script>

<style></style>
