<template>
    <div id="my">
        <!--顶部-->
        <div class="top">
            <div class="nav">
                <div class="left">
                    <ul>
                        <li style="margin-left: 0%;"><span><a href="#">小米商城</a></span></li>
                        <li><span><a href="#">MIUI</a></span></li>
                        <li><span><a href="#">loT</a></span></li>
                        <li><span><a href="#">云服务</a></span></li>
                        <li><span><a href="#">天星数码</a></span></li>
                        <li><span><a href="#">有品</a></span></li>
                        <li><span><a href="#">小爱开放平台</a></span></li>
                        <li><span><a href="#">企业团购</a></span></li>
                        <li><span><a href="#">资质证照</a></span></li>
                        <li><span><a href="#">协议规则</a></span></li>
                        <li><span><a href="#">下载app</a></span></li>
                        <li><span><a href="#">智能生活</a></span></li>
                        <li><span><a href="#">Select Location</a></span></li>
                    </ul>
                </div>
                <div class="right">
                    <ul>
                        <li style="margin-left: 0%;"><span><a href="/src/components/Login.vue">登录</a></span></li>
                        <li><span><a href="#">注册</a></span></li>
                        <li><span><a href="#">消息通知</a></span></li>
                        <li style="width: 25%;padding-left: 5%;">
                            <a href="#">
                                <img src="/static/images/gowuchelog.png" class="log1" width="20%" />
                                <img src="/static/images/gowuchelog2.png" class="log2" width="20%" style="display: none;" />
                                <span> 购物车 (0)</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--头部log、导航、搜索-->
        <div class="section">
            <div class="TopLNS">
                <div class="container">
                    <div class="row">
                        <div class="col-md-3" style="padding-top: 2%;">
                            <img src="../../static/images/logo-mi21.png" width="23%" style="line-height: 100px;" />
                        </div>
                        <div class="col-md-6">
                            <ul>
                                <li style="margin-left: -5%;"><a href="#"><span>小米手机</span></a></li>
                                <li><a href="#"><span>Redmi手机</span></a></li>
                                <li><a href="#"><span>电视</span></a></li>
                                <li><a href="#"><span>笔记本</span></a></li>
                                <li><a href="#"><span>家电</span></a></li>
                                <li><a href="#"><span>路由器</span></a></li>
                                <li><a href="#"><span>智能硬件</span></a></li>
                                <li><a href="#"><span>服务</span></a></li>
                                <li><a href="#"><span>社区</span></a></li>
                            </ul>
                        </div>
                        <div class="col-md-3 right">
                            <div class="row">
                                <div class="input-group" style="padding-top: 8%;">
                                    <input type="text" class="form-control" placeholder="手机" />
                                    <span class="input-group-btn">
                                        <button class="btn btn-default" type="button" style="border-radius: 1px;"><span class="glyphicon glyphicon-search" style="font-size: 20px;"></span></button>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>  
        </div>
        <!--二级菜单-->
        <div class="TopSH">
            <div id="TopSHPhoneOne" style="display: none;">
                <div class="container TopSHPhoneOne">
                    <ul v-for="(item,index) in TopSHPhone1Arr">
                        <li>
                            <ol>
                                <a href="#"><img :src="item.imgUrl" /></a>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.Price}}元起</span></a></li>
                            </ol>
                        </li>
                    </ul>
                </div>
            </div>
            <div id="TopSHPhoneTwo" style="display: none;">
                <div class="container TopSHPhoneTwo">
                    <ul v-for="(item,index) in TopSHPhone2Arr">
                        <li>
                            <ol>
                                <a href="#"><img :src="item.imgUrl" /></a>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.Price}}元起</span></a></li>
                            </ol>
                        </li>
                    </ul>
                </div>
            </div>
            <div id="TopSHTelevision" style="display: none;">
                <div class="container TopSHTelevision">
                    <ul v-for="(item,index) in TopSHTelevision">
                        <li>
                            <ol>
                                <a href="#"><img :src="item.imgUrl" /></a>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.Price}}元起</span></a></li>
                            </ol>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--个人中心-->
        <div class="personal">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 wenziTop"><router-link to="/index"><span>首页</span></router-link><span>  /  个人中心</span></div>
                    <div class="col-md-12 neirong">
                        <div class="left">
                            <h4>订单中心</h4>
                            <ul>
                                <li><a href="#">我的订单</a></li>
                                <li><a href="#">评价晒单</a></li>
                                <li><a href="#">话费充值订单</a></li>
                                <li><a href="#">以旧换新订单</a></li>
                            </ul>
                            <h4>个人中心</h4>
                            <ul>
                                <li><a href="#">我的个人中心</a></li>
                                <li><a href="#">消息通知</a></li>
                                <li><a href="#">购买资格</a></li>
                                <li><a href="#">现金账户</a></li>
                                <li><a href="#">小米礼品卡</a></li>
                                <li><a href="#">现金卷</a></li>
                                <li><a href="#">喜欢的商品</a></li>
                                <li><a href="#">优惠券</a></li>
                                <li><a href="#">收货地址</a></li>
                                <li><a href="#">红包</a></li>
                            </ul>
                            <h4>售后服务</h4>
                            <ul>
                                <li><a href="#">服务记录</a></li>
                                <li><a href="#">申请服务</a></li>
                                <li><a href="#">领取快递报销</a></li>
                            </ul>
                            <h4>账号管理</h4>
                            <ul>
                                <li><a href="#">个人信息</a></li>
                                <li><a href="#">修改密码</a></li>
                            </ul>
                        </div>
                        <div class="right">
                            <div class="col-md-6 xinxiLeft">
                                <div><img src="/static/images/toxiang.png" /></div>
                                <!--昵称-->
                                <div>
                                    <h3 v-for="(kool,index) in custerinf">{{kool.customer_name}}</h3>
                                    <router-link to="/modifyInformation" ><a href="#" ><p >修改个人信息 ></p></a></router-link>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <ul >
                                    <li>账户安全：<span>较高</span></li>
                                    <li>绑定手机：<span v-for="(item,index) in custinf">{{item.customer_id}}</span></li>
                                    <li>绑定邮箱：<span v-for="(kool,index) in custerinf">{{kool.customer_email}}</span></li>
                                </ul>
                            </div>
                            <div class="col-md-12"><hr/></div>
                            <div class="col-md-12 xinxiBottom">
                                <div class="col-md-6">
                                    <div><img src="/static/images/portal-icon-1.png" /></div>
                                    <!--待支付-->
                                    <div>
                                        <h4>待支付的订单：<span>0</span></h4>
                                        <a href="#">查看待支付订单 ></a>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div><img src="/static/images/portal-icon-2.png" /></div>
                                    <!--待收货-->
                                    <div>
                                        <h4>待收货的订单：<span>0</span></h4>
                                        <a href="#">查看待收货订单 ></a>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div><img src="/static/images/portal-icon-3.png" /></div>
                                    <!--待评价-->
                                    <div>
                                        <h4>待评价的订单：<span>0</span></h4>
                                        <a href="#">查看待评价订单 ></a>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div><img src="/static/images/portal-icon-4.png" /></div>
                                    <!--喜欢-->
                                    <div>
                                        <h4>喜欢的商品：<span>0</span></h4>
                                        <a href="#">查看喜欢的商品 ></a>
                                    </div>
                                </div>
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
        name: 'My',
        data(){
            return{
                TopSHPhone1Arr:[],
                TopSHPhone2Arr:[],
                TopSHTelevision:[],
                custinf:[],
                custerinf:[]
            }
        },
        methods: {
          
        },
        // 192.168.189.243
        mounted(){
            var _this=this;
            this.$http.get('/static/json/TopSHPhone1.json')
            .then(function(res){
                console.log(res);
                _this.TopSHPhone1Arr=res.data
                
                console.log(_this.TopSHPhone1Arr)
            })
            .catch(function(err){
                console.log(err)
            });
            var _this=this;
            this.$http.get('/static/json/TopSHPhone2.json')
            .then(function(res){
            //   console.log(res);
                _this.TopSHPhone2Arr=res.data
                console.log(_this.TopSHPhone2Arr)
            })
            .catch(function(err){
                console.log(err)
            });
            var _this=this;
            this.$http.get('/static/json/TopSHTelevision.json')
            .then(function(res){
            //   console.log(res);
                _this.TopSHTelevision=res.data
                console.log(_this.TopSHTelevision)
            })
            .catch(function(err){
                console.log(err)
            });
               var ID = JSON.parse(localStorage.getItem('hou'));  //取
                var _this=this;
            this.$http.get("http://localhost:61386/api/Login/GetLogin?ID="+ID)
            .then(function(res){
                console.log(res);
                _this.custinf=res.data
                
                console.log(_this.custinf)
            })
            .catch(function(err){
                console.log(err)
            });

            var ID = JSON.parse(localStorage.getItem('hou'));  //取
                var _this=this;
            this.$http.get("http://localhost:61386/api/Login/GetInf?ID="+ID)
            .then(function(res){
                console.log(res);
                _this.custerinf=res.data
                
                console.log(_this.custerinf)
            })
            .catch(function(err){
                console.log(err)
            });
        }
    }
     
     
    $(function(){
        // 顶部购物车变换
        $(".top .nav .right li:eq(3)").hover(function(){
            $(this).css("background","white");
            $(this).children().children(".log2").show();
            $(this).children().children(".log1").hide();
            $(this).children("a").children("span").css("color","rgb(255,103,0)");
        },function(){
            $(this).css("background","rgb(51,51,51)");
            $(this).children().children(".log1").show();
            $(this).children().children(".log2").hide();
            $(this).children("a").children("span").css("color","rgb(176,176,176)");
        });
        // top导航菜单显示隐藏
        $(".TopLNS ul li:eq(0)").mouseover(function(){
            $(".TopSH,#TopSHPhoneOne").show();
            $("#TopSHPhoneTwo").hide();
            $("#TopSHTelevision").hide();
        });
        $(".TopLNS ul li:eq(1)").mouseover(function(){
            $(".TopSH,#TopSHPhoneTwo").show();
            $("#TopSHPhoneOne").hide();
            $("#TopSHTelevision").hide();
        });
        $(".TopLNS ul li:eq(2)").mouseover(function(){
            $(".TopSH,#TopSHTelevision").show();
            $("#TopSHPhoneOne").hide();
            $("#TopSHPhoneTwo").hide();
        });
        $(".personal,.top").mouseover(function(){
            $(".TopSH").hide();
        });
    });
</script>

<style>
    @import"../../static/css/my.css";
</style>
