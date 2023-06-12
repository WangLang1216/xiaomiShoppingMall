// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

//引用axios
import axios from 'axios'
Vue.prototype.$http = axios
Vue.prototype.axios = axios

//引用jquery
import $ from 'jquery'

//引用bootstrap
import 'bootstrap3/dist/css/bootstrap.min.css'
import 'bootstrap3/dist/js/bootstrap.min.js'

//搜索
import { Search } from 'mint-ui';
Vue.component(Search.name, Search);

//跨域请求数据
// axios.defaults.baseURL = '/admin'
// axios.defaults.headers["Content-Type"] = "application/json"

//路由
import Router from 'vue-router'
Vue.use(Router)
import router from './router/index.js'

//轮播
import { Swipe, SwipeItem } from 'mint-ui';
Vue.component(Swipe.name, Swipe);
Vue.component(SwipeItem.name, SwipeItem);

//按钮
import { Button } from 'mint-ui';
Vue.component(Button.name, Button);

//底部导航
import { Tabbar, TabItem } from 'mint-ui';
Vue.component(Tabbar.name, Tabbar);
Vue.component(TabItem.name, TabItem);

//弹出框
import { MessageBox } from 'mint-ui';

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})

