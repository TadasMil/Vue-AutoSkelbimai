<template>
  <div class="tw-mt-2">
    <div v-if="loading">
      Loading
    </div>
    <div class="tw-flex" v-else>
      <div class="tw-w-4/12">
        <p class="tw-font-bold tw-text-2xl">
          {{ advert.car?.name }} {{ advert.car?.model }}
          {{ advert.car?.fuelType }} {{ advert.car?.year }}
        </p>
        <AdvertContactDetails
          :phone="advert.phoneNumber"
          :city="advert.car?.city"
          :email="advert?.email"
        />
        <div>
          <AttributeLineTitle name="Automobilio informaciją" />
          <CarAttributes
            v-for="attribute in attributes"
            :key="attribute"
            v-bind="attribute"
          />
          <AttributeLineTitle name="Kuro sanaudos" />
          <CarAttributes
            v-for="attribute in fuelConsumption"
            :key="attribute"
            v-bind="attribute"
          />
          <AttributeLineTitle name="Ypatybės" />
          <CarAttributes
            v-for="attribute in features"
            :key="attribute"
            v-bind="attribute"
          />
          <AttributeLineTitle name="Komentarai" />
          <AdvertDescription />
          <AdvertPrice :price="advert.car?.price" />
        </div>
      </div>
      <div class="tw-w-9/12">
        <img
          :src="advert.car?.images[0].name"
          alt=""
          class="tw-object-contain tw-h-96 tw-ml-4"
        />
      </div>
    </div>
  </div>
</template>

<script>
import { computed, onMounted, reactive, toRefs } from "vue";
import { useStore } from "vuex";

import AdvertContactDetails from "../../components/Advert/AdvertContactDetails.vue";
import CarAttributes from "../../components/Advert/CarAttributes.vue";
import AttributeLineTitle from "../../components/Advert/AttributeLineTitle.vue";
import AdvertDescription from "../../components/Advert/AdvertDescription.vue";
import AdvertPrice from "../../components/Advert/AdvertPrice.vue";

export default {
  name: "FullAdvert",
  components: {
    AdvertContactDetails,
    CarAttributes,
    AttributeLineTitle,
    AdvertDescription,
    AdvertPrice,
  },
  props: {
    id: {
      type: String,
      required: true,
    },
  },
  setup(props) {
    const store = useStore();

    const state = reactive({
      advert: {},
      loading: false,
    });

    onMounted(async () => {
      getCarBySpecificId();
    });

    const getCarBySpecificId = async () => {
      try {
        state.loading = true;
        const carAdvert = await store.dispatch("fetchAdvertById", props.id);

        state.advert = carAdvert;
        state.loading = false;
      } catch (err) {
        console.log(err);
      }
    };

    const attributes = computed(() => [
      {
        name: "Markė",
        value: state.advert.car?.name,
      },
      {
        name: "Modelis",
        value: state.advert.car?.model,
      },
      {
        name: "Metai",
        value: state.advert.car?.year,
      },
      {
        name: "Variklis, l",
        value: state.advert.car?.volume,
      },
      {
        name: "Kuro tipas",
        value: state.advert.car?.fuelType,
      },
      {
        name: "Kėbulo tipas",
        value: state.advert.car?.bodyType,
      },
      {
        name: "Spalva",
        value: state.advert.car?.color,
      },
      {
        name: "Pavarų dėžė",
        value: state.advert.car?.gear,
      },
      {
        name: "Rida, km",
        value: state.advert.car?.miles,
      },
      {
        name: "Varomieji ratai",
        value: state.advert.car?.wheels,
      },
      {
        name: "Sėdimų vietų skaičius",
        value: state.advert.car?.seats,
      },
      {
        name: "Pirmosios registracijos šalis",
        value: state.advert.car?.firstRegistration,
      },
    ]);

    const fuelConsumption = computed(() => [
      {
        name: "Mieste",
        value: "Nenurodyta",
      },
      {
        name: "Užmiestyje",
        value: "Nenurodyta",
      },
      {
        name: "Mišrus",
        value: "Nenurodyta",
      },
    ]);

    const features = computed(() => {
      if (props.features) {
        return [{ name: "Duomenys" }];
      }

      return [{ name: "Nėra pateikta duomenų" }];
    });

    return { ...toRefs(state), attributes, fuelConsumption, features };
  },
};
</script>

<style></style>
