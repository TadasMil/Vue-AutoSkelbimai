<template>
  <div class="tw-full tw-bg-gray tw-py-4">
    <div class="tw-max-w-lg tw-mx-auto">
      <div class="tw-w-10/12 tw-m-auto max-w-screen-xl">
        <slot name="navigation"></slot>
      </div>
    </div>
  </div>
  <div class="tw-max-w-lg tw-mx-auto">
    <div class="tw-w-11/12 tw-mx-auto">
      <div class="tw-w-11/12 tw-mx-auto">
        <slot />
      </div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style></style>
