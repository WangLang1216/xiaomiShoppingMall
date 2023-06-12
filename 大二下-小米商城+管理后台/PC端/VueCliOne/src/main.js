// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

//axios
import axios from 'axios'
Vue.prototype.$http = axios
Vue.prototype.axios = axios

//引用jquery
import $ from 'jquery'

//引用bootstrap
import 'bootstrap3/dist/css/bootstrap.min.css'
import 'bootstrap3/dist/js/bootstrap.min.js'

//跨域请求数据
// axios.defaults.baseURL = '/admin'
// axios.defaults.headers["Content-Type"] = "application/json"

//路由
import Router from 'vue-router'
import router from './router/index.js'
Vue.use(Router)

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})

