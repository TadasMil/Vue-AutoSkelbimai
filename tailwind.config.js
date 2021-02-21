module.exports = {
  purge: ["./index.html", "./src/**/*.{vue,js,ts,jsx,tsx}"],
  prefix: "tw-",
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      colors: {
        purple: "#5E08CE",
        gray: "#F6F6F6",
        "gray-300": "#D8D8D8",
      },
    },

    maxWidth: {
      lg: "1500px",
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
