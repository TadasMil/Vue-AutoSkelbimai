export const combineKeys = (cars) => {
  const car = { ...cars };

  car.price = stringConcat(car.price, car.priceTo);

  delete car.priceTo;

  car.power = stringConcat(car.power, car.power);

  delete car.powerTo;

  car.miles = stringConcat(car.miles, car.milesTo);

  delete car.milesTo;

  car.year = stringConcat(car.year, car.yearTo);

  delete car.yearTo;

  car.volume = stringConcat(car.volume, car.volumeTo);

  delete car.volumeTo;

  car.seats = stringConcat(car.seats, car.seatsTo);

  delete car.seatsTo;

  delete car.phone;
  delete car.email;

  return car;
};

const stringConcat = (a, b) => {
  return a + "/" + b;
};
