<template>
  <div
    class="tw-flex tw-border-b tw-py-4 tw-border-purple tw-cursor-pointer hover:tw-bg-gray"
    @click="getFullAdvertPage"
  >
    <div class="tw-relative">
      <img
        :src="car.images[0].name"
        class="tw-object-contain tw-h-40 tw-ml-2"
      />
      <p
        class="tw-bg-black tw-bg-opacity-50 tw-text-white tw-absolute tw-top-0 tw-left-2 tw-px-2"
      >
        {{ diffTime }}
      </p>
    </div>
    <div class="tw-flex tw-flex-col tw-mt-2 tw-ml-2">
      <div class="tw-flex tw-font-bold tw-text-xl tw-text-purple">
        <p class="tw-mr-2">{{ car.name }}</p>
        <p>{{ car.model }}</p>
      </div>
      <div class=" tw-text-lg">
        <p>
          {{ car.volume }} l., {{ car.fuelType }}, {{ car.year }} m.,
          {{ car.gear }}
        </p>
      </div>
      <div
        class="tw-mt-8 tw-bg-purple tw-w-20 tw-border tw-rounded-md tw-flex tw-justify-center"
      >
        <h3 class="tw-text-lg tw-text-white">{{ car.price }} €</h3>
      </div>
    </div>
    <div class="tw-flex-grow tw-flex tw-justify-end">
      <div class="tw-flex tw-flex-col tw-items-center tw-mt-2 tw-mx-4">
        <XIcon icon="heart" class="tw-w-6 tw-h-6 tw-text-purple" />
        <p class="hover:tw-text-purple">Įsiminti</p>
      </div>
    </div>
  </div>
</template>

<script>
import { useRouter } from "vue-router";
import XIcon from "../Icons/XIcon.vue";

export default {
  name: "Advert",
  components: {
    XIcon,
  },
  props: {
    id: {
      type: String,
      required: true,
    },
    car: {
      type: Object,
      required: true,
    },
  },
  setup(props) {
    console.log(props);
    const router = useRouter();

    const getFullAdvertPage = () => {
      router.push({ name: "FullAdvert", params: { id: props.id } });
    };

    return { getFullAdvertPage };
  },
};
</script>
