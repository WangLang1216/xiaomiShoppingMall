import Vue from 'vue'
import Router from 'vue-router'
import Index from '../components/Index'
import My from '../components/My'
import Login from '../components/Login'
import Register from '../components/Register'
import ProductDetails from '../components/ProductDetails'
import ShopCar from '../components/ShopCar'
import Sort from '../components/Sort'


Vue.use(Router)

export default new Router({
    routes:[
        {
            path:"/",
            name:"Index",
            component:Index
        },
        {
            path:"/my",
            name:"My",
            component:My
        },
        {
            path:"/login",
            name:"Login",
            component:Login
        },
        {
            path:"/register",
            name:"Register",
            component:Register
        },
        {
            path:"/productDetails",
            name:"ProductDetails",
            component:ProductDetails
        },
        {
            path:"/shopCar",
            name:"ShopCar",
            component:ShopCar
        },
        {
            path:"/sort",
            name:"Sort",
            component:Sort
        }
    ]
})