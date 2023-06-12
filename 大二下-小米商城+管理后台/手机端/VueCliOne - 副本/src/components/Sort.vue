<template>
<div id="sort">
    <header>
        <router-link to="/">
            <div class="glyphicon glyphicon-menu-left nav_l"></div>
        </router-link>
        <div class="nav_c">分类</div>
        <div class="glyphicon glyphicon-search nav_r"></div>
    </header>
   
   <div class="c_center">
       <ul class="c_left">
           <li>小米手机</li>
           <li><a href="#two">Redmi</a></li>
           <li>游戏手机</li>
           <li>智能穿戴</li>
           <li>电视</li>
           <li>电脑办公</li>
           <li>大家电</li>
           <li>小家电</li>
           <li>智能家居</li>
           <li>户外出行</li>
           <li>日用百货</li>
           <li>儿童用品</li>
        </ul>
        <div class="c_right">
            <div class="one" id="one">
                <div><img src="/static/images/nav-one.png" class="tu"></div>
                <div class="word"><span>—— 小米数字系列 ——</span></div>
                <div class="one_one">
                <div class="pictruce" v-for="(item,index) in xiaomi_NumArr">
                    <img :src="item.imgURL" />
                    <p>{{item.name}}</p>
                </div>
                </div>
                 <div class="word2"><span>—— 小米MIX系列 ——</span></div>
                  <div class="one_one">
                <div class="pictruce" v-for="(item,index) in xiaomi_PeiArr">
                    <img :src="item.imgURL" />
                    <p>{{item.name}}</p>
                </div>
                </div>
                </div>
                <div class="one" id="two">
                <div><img src="/static/images/nav_two.png" class="tu"></div>
                <div class="word"><span>—— Redmi红米 Note系列 ——</span></div>
                <div class="one_one">
                <div class="pictruce" v-for="(item,index) in redmiArr">
                    <img :src="item.imgURL" />
                    <p>{{item.name}}</p>
                </div>
                </div>
                 <div class="word2"><span>—— Redmi红米 K系列 ——</span></div>
                  <div class="one_one">
                <div class="pictruce" v-for="(item,index) in redmikArr">
                    <img :src="item.imgURL" />
                    <p>{{item.name}}</p>
                </div>
                </div>
                </div>
            </div>
           
        </div>
   </div>

</div>
</template>
<script>

    export default {
        name: 'Sort',
         data(){
            return{
                xiaomi_NumArr:[],
                xiaomi_PeiArr:[],
                redmiArr:[],
                redmikArr:[]
            }
        },
        mounted(){
            //小米手机
            var _this=this;
            this.$http.get('/static/json/xiaomi_Num.json')
            .then(function(res){
                console.log(res);
                _this.xiaomi_NumArr=res.data
                console.log(_this.xiaomi_NumArr)
            })
            .catch(function(err){
                console.log(err)
            });
            //小米配件
            var _this=this;
            this.$http.get('/static/json/xiaomi_Pei.json')
            .then(function(res){
                console.log(res);
                _this.xiaomi_PeiArr=res.data
                console.log(_this.xiaomi_PeiArr)
            })
            .catch(function(err){
                console.log(err)
            });
            //红米手机
            var _this=this;
            this.$http.get('/static/json/redmi.json')
            .then(function(res){
                console.log(res);
                _this.redmiArr=res.data
                console.log(_this.redmiArr)
            })
            .catch(function(err){
                console.log(err)
            });
            //红米K手机
            var _this=this;
            this.$http.get('/static/json/redmik.json')
            .then(function(res){
                console.log(res);
                _this.redmikArr=res.data
                console.log(_this.redmikArr)
            })
            .catch(function(err){
                console.log(err)
            });
            
        }
    }
    $(function(){
        $(".c_left li:eq(1)").click(function(){
            $(".c_left li:eq(0)").css("color","black");
            $(".c_left li:eq(1) a").css("color","orange");
        });
    });
</script>
<style scoped>
    @import"../../static/css/sort.css";
</style>