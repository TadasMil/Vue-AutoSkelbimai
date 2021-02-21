<template>
  <Page>
    <template #navigation>
      <NavBar />
    </template>
    <template #content>
      <router-view />
    </template>
  </Page>
</template>

<script>
import NavBar from "./components/NavBar/NavBar.vue";
import Page from "./components/Layout/Page.vue";

export default {
  name: "App",
  components: {
    NavBar,
    Page,
  },
};
</script>
