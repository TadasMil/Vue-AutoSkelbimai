import { createStore } from "vuex";
import adverts from "./modules/adverts.js";

export default createStore({
  modules: {
    adverts,
  },
});
