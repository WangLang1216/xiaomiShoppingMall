import Vue from 'vue'
import Router from 'vue-router'
import Index from '../components/Index'
import Login from '../components/Login'
import My from '../components/My'
import ModifyInformation from '../components/ModifyInformation'
import ShopCar from '../components/base/ShopCar'
import Goods from '../components/base/Goods'

Vue.use(Router)

export default new Router({
    routes:[
        {
            path:"/",
            name:"Login",
            component:Login
        },
        {
            path:"/index",
            name:"Index",
            component:Index
        },
        {
            path:"/my",
            name:"My",
            component:My
        },
        {
            path:"/modifyInformation",
            name:"ModifyInformation",
            component:ModifyInformation
        },
        {
            path:"/shopCar",
            name:"ShopCar",
            component:ShopCar
        },
        {
            path:"/goods",
            name:"Goods",
            component:Goods
        }
    ]
})
// // 路由守卫
// router.beforeEach((to,from,next)=>{
//     // to要跳转到的路径
//     // from从哪个路径来
//     // next往下执行的回调
//     // 在localStorage中获取token
//     let token=localStorage.getItem('userName')
//     // 判断该页面是否需要登录
//     if(to.meta.auth){
//         // 如果token存在直接跳转
//         if(token){
//             next()
//         }else{
//             // 否则跳转到login登录页面
//             next({
//                 path:'/login',
//                 // 跳转时传递参数到登录页面，以便登录后可以跳转到对应页面
//                 query:{
//                     redirect:to.fullPath
//                 }
//             })
//         }
//     }else{
//         // 如果不需要登录，则直接跳转到对应页面
//         next()
//     }
// })