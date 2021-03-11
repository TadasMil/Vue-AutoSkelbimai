import adverts from "./modules/adverts.js";
import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

const store = new Vuex.Store({
  modules: {
    adverts,
  },
});

export default store;
