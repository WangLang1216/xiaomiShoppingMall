<template>
    <div id="my">
        <div class="top">
            <!--未登录-->
            <div class="weidenglu">
                <img src="/static/images/toxiangW.png" />
                <h6 v-on:click="denglu">登录/注册</h6>
            </div>
        </div>
        <!--中部-->
        <div class="central">
            <div class="dindan"><h5>我的订单</h5><h5>全部订单 ></h5></div>
            <div class="dindan2">
                <div>
                    <img src="/static/images/Mytop1.png" />
                    <h5>待付款</h5>
                </div>
                <div>
                    <img src="/static/images/Mytop2.png" />
                    <h5>待收货</h5>
                </div>
                <div>
                    <img src="/static/images/Mytop3.png" />
                    <h5>退换修</h5>
                </div>
            </div>
        </div>
        <!--目录-->
        <div class="section ash">
            <div>
                <div><img src="/static/images/icon1.png" /></div>
                <div><span>会员中心</span><span>></span></div>
            </div>
            <div>
                <div><img src="/static/images/icon2.png" /></div>
                <div><span>我的优惠</span><span>></span></div>
            </div>
        </div>
        <div class="section ssh">
            <div>
                <div><img src="/static/images/icon3.png" /></div>
                <div><span>服务中心</span><span>></span></div>
            </div>
            <div>
                <div><img src="/static/images/icon4.png" /></div>
                <div><span>小米之家</span><span>></span></div>
            </div>
        </div>
        <div class="section ssh">
            <div>
                <div><img src="/static/images/icon5.png" /></div>
                <div><span>我的F码</span><span>></span></div>
            </div>
            <div>
                <div><img src="/static/images/icon6.png" /></div>
                <div><span>礼品兑换</span><span>></span></div>
            </div>
        </div>
        <div class="section ssh">
            <div>
                <div><img src="/static/images/icon7.png" /></div>
                <div><span>设置</span><span>></span></div>
            </div>
        </div>
        <Bottom></Bottom>
    </div>
</template>

<script>
import Bottom from './Bottom';
//弹出框
import { MessageBox } from 'mint-ui';
    export default {
        name: 'My',
        components: {
            Bottom,
        },
        data () {
            return {
            
            }
        },
        methods:{
            denglu(){
                 MessageBox.confirm('', { 
                    message: '请仔细阅读，同意后可使用此软件！', 
                    title: '小米协议', 
                    confirmButtonText: '同意', 
                    cancelButtonText: '不同意' 
                    }).then(action => { 
                    if (action == 'confirm') {     //确认的回调
                    console.log(1); 
                    this.$router.push({ path: '/login'});
                    }
                    }).catch(err => { 
                    if (err == 'cancel') {     //取消的回调
                    console.log(2);
                    } 
                });
            }
        }
    };


    $(function(){
        
    })
</script>

<style scoped>
    @import"../../static/css/my.css";
</style>
