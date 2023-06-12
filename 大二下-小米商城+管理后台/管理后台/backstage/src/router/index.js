import Vue from 'vue'
import Router from 'vue-router'
import Commodity from '../components/Commodity'
import Users from '../components/Users'

Vue.use(Router)

export default new Router({
    routes:[
        {
            path:"/",
            name:"Commodity",
            component:Commodity
        },
        {
            path:"/users",
            name:"Users",
            component:Users
        }
    ]
})
