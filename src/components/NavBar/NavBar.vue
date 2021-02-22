<template>
  <nav class="tw-flex tw-justify-between tw-align-center">
    <Title />
    <div class="tw-flex">
      <NavLink v-for="navItem in navItems" :key="navItem.id" v-bind="navItem" />
      <LinkButton name="Pridėti skelbimą" :to="{ name: 'Home' }" />
    </div>
  </nav>
</template>

<script>
import Title from "../Title/Title.vue";
import NavLink from "./NavLink.vue";
import LinkButton from "../Buttons/LinkButton.vue";

export default {
  name: "NavBar",
  components: {
    Title,
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
