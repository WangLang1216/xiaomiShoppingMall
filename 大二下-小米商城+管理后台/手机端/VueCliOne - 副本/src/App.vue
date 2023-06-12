<template>
  <div id="app">
    <!-- <Index></Index> -->
    <router-view></router-view>
    <!-- <ProductDetails></ProductDetails> -->
    <!-- <Bottom></Bottom> -->
  </div>
</template>

<script>
  import Index from './components/Index';
  import Bottom from './components/Bottom';
  import My from './components/My';
  import Login from './components/Login';
  import Register from './components/Register'
  import ProductDetails from './components/ProductDetails'
  export default {
    name: 'App',
    components: {
      Index,
      My,
      Login,
      Register,
      Bottom,
      ProductDetails
    }
  }
</script>

<style>

</style>
