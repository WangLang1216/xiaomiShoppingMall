<template>
    <div id="index">
        <div class="fixedTop">
            <!--头部-->
            <div class="top">
                <div class="left">
                    <img src="/static/images/log.png" />
                </div>
                <div class="middle">
                    <input type="text" placeholder="  搜索商品名称" class="glyphicon glyphicon-search" />
                    <span class="glyphicon glyphicon-search"></span>
                    </div>
                <div class="right">
                    <img src="/static/images/topwd.png" />
                </div>
            </div>
            <!--导航-->
            <div class="Navigation">
                <div><span>推荐</span></div>
                <div><span>手机</span></div>
                <div><span>智能</span></div>
                <div><span>电视</span></div>
                <div><span>家电</span></div>
                <div><span>笔记本</span></div>
                <div><span class="glyphicon glyphicon-chevron-down"></span></div>
            </div>
        </div>
        <!--轮播图-->
        <div class="Carousel">
            <mt-swipe :auto="3000">
                <mt-swipe-item><img src="/static/images/lunbo1.jpg" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/lunbo2.jpg" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/lunbo3.png" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/lunbo4.jpg" /></mt-swipe-item>
            </mt-swipe>
        </div>
        <!--活动列表-->
        <div class="activity">
            <div class="top">
                <div><img src="/static/images/huodong1.png" /></div>
                <div><img src="/static/images/huodong2.png" /></div>
                <div><img src="/static/images/huodong3.png" /></div>
                <div><img src="/static/images/huodong4.png" /></div>
                <div><img src="/static/images/huodong5.png" /></div>
            </div>
            <div class="bottom">
                <div><img src="/static/images/huodong6.png" /></div>
                <div><img src="/static/images/huodong7.png" /></div>
                <div><img src="/static/images/huodong8.png" /></div>
                <div><img src="/static/images/huodong9.png" /></div>
                <div><img src="/static/images/huodong10.png" /></div>
            </div>
        </div>
        <!--海报-->
        <div class="poster">
            <div class="left"><img src="/static/images/poster1.png" /></div>
            <div class="right">
                <div><img src="/static/images/poster2.png" /></div>
                <div><img src="/static/images/poster3.png" /></div>
            </div>
        </div>
        <!--海报-->
        <div class="poster2"><img src="/static/images/poster4.png" /></div>
        <!--手机列表-->
        <div class="phone">
            <div class="container neirong">
                <div class="row">
                    <div class="col-xs-6" v-for="(item,index) in SphoneArr">
                        <img :src="item.imgUrl" />
                        <h3>{{item.name}}</h3>
                        <h5>{{item.introduce}}</h5>
                        <h4>￥{{item.Price}}起</h4>
                        <router-link to="/productDetails"><div><mt-button type="danger"><span>立即购买</span></mt-button></div></router-link>
                    </div>
                </div>
            </div>
            <div class="bottom"><p>更多小米手机产品 ></p></div>
        </div>
        <!--笔记本列表-->
        <div class="notebook">
            <img src="/static/images/bookhaibao.png" />
            <div class="container neirong">
                <div class="row">
                    <div class="col-xs-6" v-for="(item,index) in SbookArr">
                        <img :src="item.imgUrl" />
                        <h3>{{item.name}}</h3>
                        <h5>{{item.introduce}}</h5>
                        <h4>￥{{item.Price}}起</h4>
                        <div><mt-button type="danger"><span>立即购买</span></mt-button></div>
                    </div>
                </div>
            </div>
            <div class="bottom"><p>更多小米笔记本产品 ></p></div>
        </div>
        <!--海报-->
        <div class="poster3">
            <img src="/static/images/haibao8.png" />
            <div class="hai1">
                <div><img src="/static/images/haibaoD1.png" /></div>
                <div><img src="/static/images/haibaoD2.png" /></div>
            </div>
            <div class="hai1">
                <div><img src="/static/images/haibaoD3.png" /></div>
                <div><img src="/static/images/haibaoD4.png" /></div>
            </div>
            <div class="hai1">
                <div><img src="/static/images/haibaoD5.png" /></div>
                <div><img src="/static/images/haibaoD6.png" /></div>
            </div>
            <img src="/static/images/haibaoD7.png" />
            <div class="wenzi"><p>了解小米</p></div>
            <br/><br/>
        </div>

        
    <Bottom></Bottom>
    </div>
</template>

<script>
    import Bottom from './Bottom';
    export default {
        name: 'Index',
        components: {
            Bottom,
        },
        data(){
            return{
                SphoneArr:[],
                SbookArr:[]
            }
        },
        mounted(){
            //手机列表
            var _this=this;
            this.$http.get('/static/json/Sphone.json')
            .then(function(res){
                console.log(res);
                _this.SphoneArr=res.data
                console.log(_this.SphoneArr)
            })
            .catch(function(err){
                console.log(err)
            });
            //笔记本列表
            var _this=this;
            this.$http.get('/static/json/Sbook.json')
            .then(function(res){
                console.log(res);
                _this.SbookArr=res.data
                console.log(_this.SbookArr)
            })
            .catch(function(err){
                console.log(err)
            });
        }
    }
</script>

<style scoped>
    @import"../../static/css/index.css";
</style>
