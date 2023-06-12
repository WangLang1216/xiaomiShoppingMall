<template>
  <div id="app">
    <!-- <Index></Index> -->
    <!-- <Login></Login> -->
    <!-- <My></My> -->
    <!-- <ModifyInformation></ModifyInformation> -->
    <router-view></router-view>
    <!-- <Goods></Goods> -->
    <!-- <ShopCar></ShopCar> -->
    <Bottom></Bottom>
    <!-- <Footer></Footer> -->
  </div>
</template>

<script>
  import Index from './components/Index'
  import Bottom from './components/Bottom'
  import Login from './components/Login'
  import My from './components/My'
  import ModifyInformation from './components/ModifyInformation'
  import Footer from './components/base/Footer'
  import Goods from './components/base/Goods'
  import ShopCar from './components/base/ShopCar'
  export default {
    name: 'App',
    components: {
      Index,
      My,
      ModifyInformation,
      Bottom,
      Login,
      Footer,
      Goods,
      ShopCar
    }
  }
</script>

<style>

</style>
