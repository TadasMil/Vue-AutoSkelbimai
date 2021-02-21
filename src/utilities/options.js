import { getStaticData } from "../composables/getStaticData";

export const optionsFrom = {
  price: {
    name: "Kaina",
    from: getStaticData(0, 500, 100000),
    to: getStaticData(0, 500, 100000),
  },
  power: {
    name: "Galia, kw",
    from: getStaticData(30, 12, 500),
    to: getStaticData(30, 12, 500),
  },
  run: {
    name: "Rida",
    from: getStaticData(0, 5000, 500000),
    to: getStaticData(0, 5000, 500000),
  },
  year: {
    name: "Metai",
    from: getStaticData(1970, 1, 2021),
    to: getStaticData(1970, 1, 2021),
  },
  volume: {
    name: "Tūris (litrai)",
    from: getStaticData(0.8, 0.1, 7),
    to: getStaticData(0.8, 0.1, 7),
  },
  numberOfSeats: {
    name: "Sėdimų vietų skaičius",
    from: getStaticData(1, 1, 9),
    to: getStaticData(1, 1, 9),
  },
};

export const options = {
  brand: {
    name: "Markė",
    type: "brand",
    data: [],
  },
  model: {
    type: "model",
    name: "Modelis",
    data: [],
  },
  fuelType: {
    name: "Kuro tipas",
    type: "fuelType",
    data: [
      {
        id: 1,
        name: "Dyzelinas",
      },
      {
        id: 2,
        name: "Benzinas",
      },
      {
        id: 3,
        name: "Benzinas/Dujos",
      },
      {
        id: 4,
        name: "Benzinas/Elektra",
      },
      {
        id: 5,
        name: "Elektra",
      },
      {
        id: 6,
        name: "Dujos",
      },
      {
        id: 7,
        name: "Dyzelinas/Elektra",
      },
    ],
  },
  wheelPosition: {
    type: "wheelPosition",
    name: "Vairo padėtis",
    data: [
      {
        id: 1,
        name: "Kairėje",
      },
      {
        id: 2,
        name: "Dešinėje",
      },
    ],
  },
  city: {
    name: "Miestas",
    type: "city",
    data: [],
  },
  gear: {
    name: "Pavarų dėžė",
    type: "gear",
    data: [
      {
        id: 1,
        name: "Automatinė",
      },
      {
        id: 2,
        name: "Mechaninė",
      },
    ],
  },
  wheels: {
    name: "Varomieji ratai",
    type: "wheels",
    data: [
      {
        id: 1,
        name: "Priekiniai",
      },
      {
        id: 2,
        name: "Galiniai",
      },
      {
        id: 3,
        name: "Visi varomieji",
      },
    ],
  },
  bodyType: {
    name: "Kėbulo tipas",
    type: "bodyType",
    data: [],
  },
  color: {
    name: "Spalva",
    type: "color",
    data: [],
  },
  firstRegistration: {
    name: "Pirmoji registracija",
    type: "firstRegistration",
    data: [],
  },
};
