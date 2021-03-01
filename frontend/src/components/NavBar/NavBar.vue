<template>
  <nav class="tw-flex tw-justify-between tw-align-center">
    <router-link :to="{ name: 'Home' }">
      <NavTitle />
    </router-link>
    <div class="tw-flex">
      <NavLink v-for="navItem in navItems" :key="navItem.id" v-bind="navItem" />
      <LinkButton name="Pridėti skelbimą" :to="{ name: 'NewAdvert' }" />
    </div>
  </nav>
</template>

<script>
import NavTitle from "../Title/NavTitle.vue";
import NavLink from "./NavLink.vue";
import LinkButton from "../Buttons/LinkButton.vue";

export default {
  name: "NavBar",
  components: {
    NavTitle,
    NavLink,
    LinkButton,
  },
  setup() {
    const navItems = [
      {
        id: 1,
        name: "Įsiminti",
        icon: "heart",
        to: { name: "Home" },
      },
      {
        id: 2,
        name: "Žiūrėti skelbimai",
        icon: "time",
        to: { name: "Home" },
      },
    ];

    return { navItems };
  },
};
</script>

<style></style>
