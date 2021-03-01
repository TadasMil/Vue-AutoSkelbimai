import { getStaticData } from "../composables/getStaticData";

export const optionsFrom = {
  price: {
    name: "Kaina",
    model: "price",
    from: getStaticData(0, 500, 100000),
    to: getStaticData(0, 500, 100000),
  },
  power: {
    name: "Galia, kw",
    model: "power",
    from: getStaticData(30, 12, 500),
    to: getStaticData(30, 12, 500),
  },
  run: {
    name: "Rida",
    model: "miles",
    from: getStaticData(0, 5000, 500000),
    to: getStaticData(0, 5000, 500000),
  },
  year: {
    name: "Metai",
    model: "year",
    from: getStaticData(1970, 1, 2020).sort((a, b) => a + b),
    to: getStaticData(1970, 1, 2021).sort((a, b) => a + b),
  },
  volume: {
    name: "Tūris (litrai)",
    model: "volume",
    from: getStaticData(0.8, 0.1, 7),
    to: getStaticData(0.8, 0.1, 7),
  },
  numberOfSeats: {
    name: "Sėdimų vietų skaičius",
    model: "numberOfSeats",
    from: getStaticData(1, 1, 9),
    to: getStaticData(1, 1, 9),
  },
};

export const options = {
  brand: {
    name: "Markė",
    model: "brand",
    data: [],
  },
  model: {
    model: "model",
    name: "Modelis",
    data: [],
  },
  fuelType: {
    name: "Kuro tipas",
    model: "fuelType",
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
    model: "wheelPosition",
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
    model: "city",
    data: [],
  },
  gear: {
    name: "Pavarų dėžė",
    model: "gear",
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
    model: "wheels",
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
    model: "bodyType",
    data: [],
  },
  color: {
    name: "Spalva",
    model: "color",
    data: [],
  },
  firstRegistration: {
    name: "Pirmoji registracija",
    model: "firstRegistration",
    data: [],
  },
};
