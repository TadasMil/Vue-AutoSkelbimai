export const getStaticData = (start, increment, end) => {
  var data = [];
  let i = start;
  data.push(i);
  while (i <= end) {
    i += increment;
    if (increment === 0.1) {
      data.push(i.toFixed(1).toString());
    } else {
      data.push(i);
    }
  }
  return data;
};
