<template>
  <select
    :class="{
      'tw-flex-1 tw-mr-4': isDataFrom,
    }"
    class="select tw-border-2 tw-border-gray-300 tw-px-2 tw-py-1"
    :value="modelValue"
    @input="$emit('update:modelValue', $event.target.value)"
  >
    <option value="" v-if="isDataFrom" selected disabled hidden>{{
      from === "from" ? "Nuo" : "Iki"
    }}</option>
    <option value="" selected disabled hidden v-else>---</option>
    <option v-for="type in data" :key="type.id">
      {{ isDataFrom ? type : type.name }}
    </option>
  </select>
</template>

<script>
export default {
  name: "Select",
  props: {
    name: {
      type: String,
      default: "",
    },
    data: {
      type: Array,
      default: () => {},
    },
    isDataFrom: {
      type: Boolean,
      required: true,
    },
    from: {
      type: String,
      default: "from",
    },
    modelValue: String,
  },
  setup(props) {
    console.log(props.data);
    console.log(props.isDataFrom);
    console.log(props.modelValue);
  },
};
</script>

<style>
.select {
  -webkit-appearance: none;
  -moz-appearance: none;
  background: transparent;
  background-image: url("data:image/svg+xml;utf8,<svg fill='purple' height='24' viewBox='0 0 24 24' width='24' xmlns='http://www.w3.org/2000/svg'><path d='M7 10l5 5 5-5z'/><path d='M0 0h24v24H0z' fill='none'/></svg>");
  background-repeat: no-repeat;
  background-position-x: 100%;
  background-position-y: 5px;
  margin-right: 2rem;
  padding-right: 2rem;
}
</style>
