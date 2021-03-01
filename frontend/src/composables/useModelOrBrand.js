export const useModelOrBrand = (data, isBrand) => {
  const newData = data.map((x, i) => {
    return {
      id: i,
      name: isBrand ? x.MakeName : x.Model_Name,
    };
  });

  return newData;
};
