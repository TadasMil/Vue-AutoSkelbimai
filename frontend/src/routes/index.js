import Home from "./Home/index.js";
import NewAdvert from "./Adverts/index.js";
import { createRouter, createWebHistory } from "vue-router";

const routes = [...Home, ...NewAdvert];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
