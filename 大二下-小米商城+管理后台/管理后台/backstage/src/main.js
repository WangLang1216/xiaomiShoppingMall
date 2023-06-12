// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

//引用axios
import axios from 'axios'
Vue.prototype.$http = axios

//路由
import Router from 'vue-router'
import router from './router/index.js'
Vue.use(Router)

//引用jquery
import $ from 'jquery'

//引用bootstrap
import 'bootstrap3/dist/css/bootstrap.min.css'
import 'bootstrap3/dist/js/bootstrap.min.js'

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
