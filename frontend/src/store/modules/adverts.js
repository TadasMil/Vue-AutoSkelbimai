import axios from "axios";

const state = {
  adverts: [],
  advert: {},
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

    commit("SET_ADVERTS", response.data);

    return response.data;
  },

  fetchAdvertById: async ({ commit }, advertId) => {
    console.log(advertId);
    const response = await axios.get(
      `https://localhost:44315/api/adverts/${advertId}`
    );

    commit("SET_ADVERT", response.data.car);

    return response.data;
  },
};

const mutations = {
  SET_ADVERTS: (state, adverts) => {
    state.adverts = adverts;
  },
  SET_ADVERT: (state, advert) => {
    state.advert = {};
    state.advert = { ...advert };
  },
};

export default {
  state,
  actions,
  mutations,
};
