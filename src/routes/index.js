import Home from "./Home/index.js";
import { createRouter, createWebHistory } from "vue-router";

const routes = [...Home];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
});

export default router;
