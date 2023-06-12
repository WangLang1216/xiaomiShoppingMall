<template>
  <div id="app">
    <Header></Header>
    <router-view></router-view>
    <!-- <Users></Users> -->
    <!-- <Commodity></Commodity> -->
  </div>
</template>

<script>
  import Header from './components/Header'
  import Commodity from './components/Commodity'
  import Users from './components/Users'

export default {
  name: 'App',
  components: {
    Header,
    Commodity,
    Users
  }
}
</script>

<style>

</style>
