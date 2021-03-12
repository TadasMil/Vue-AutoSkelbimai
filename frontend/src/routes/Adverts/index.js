import NewAdvert from "../../pages/Advert/NewAdvert.vue";
import Adverts from "../../pages/Advert/Adverts.vue";
import FullAdvert from "../../pages/Advert/FullAdvert.vue";

export default [
  {
    path: "/new-advert",
    name: "NewAdvert",
    component: NewAdvert,
  },
  {
    path: "/adverts",
    name: "Adverts",
    component: Adverts,
    props: true,
  },
  {
    path: "/advert/:id",
    name: "FullAdvert",
    component: FullAdvert,
    props: true,
  },
];
