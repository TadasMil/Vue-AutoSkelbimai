import axios from "axios";

const state = {
  adverts: [],
};

const actions = {
  fetchAdverts: async ({ commit }, searchFields) => {
    const response = await axios.post(
      "https://localhost:44315/api/cars",
      searchFields,
      {
        headers: { "Content-Type": "application/json" },
      }
    );
    console.log(response);
    commit("SET_ADVERTS", response);
  },
};

const mutations = {
  SET_ADVERTS: (state, adverts) => {
    state.adverts = adverts;
  },
};

export default {
  state,
  actions,
  mutations,
};
