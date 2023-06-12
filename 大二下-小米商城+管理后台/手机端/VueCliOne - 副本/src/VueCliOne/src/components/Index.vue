<template>
  <div id="index">
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
                        <li ><!--登录名style="display: none;"-->
                            <router-link to="/my"><span><a href="#">我的</a></span></router-link>
                        </li>
                        <li style="margin-left: 0%;"><span><a  href="/src/components/Login.vue">登录</a></span></li>
                        <li><span><a href="#">消息通知</a></span></li>
                        <li style="width: 25%;padding-left: 5%;">
                            <router-link to="/shopCar">
                            <a href="#">
                                <img src="/static/images/gowuchelog.png" class="log1" width="20%" />
                                <img src="/static/images/gowuchelog2.png" class="log2" width="20%" style="display: none;" />
                                <span> 购物车 (0)</span>
                            </a>
                            </router-link>
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
                                <li><a href="#"><span>{{item.ship_name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.price}}元起</span></a></li>
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
                                <li><a href="#"><span>{{item.ship_name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.price}}元起</span></a></li>
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
                                <li><a href="#"><span>{{item.ship_name}}</span></a></li>
                            </ol>
                            <ol>
                                <li><a href="#"><span>{{item.price}}元起</span></a></li>
                            </ol>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--轮播和右侧菜单-->
        <div class="Carousel">
            <div class="content container">
                <div class="main" id="main">
                    <div class="menu-box"></div>
                    
                    <div class="sub-menu hide" id="sub-menu">
                        <div class="inner-box">
                            <img src="../../static/images/lunboerji1.png" class="img-responsive" />
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                <img src="../../static/images/lunboerji2.png" class="img-responsive" />
                            </div>
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                <img src="../../static/images/lunboerji3.png" class="img-responsive" />
                            </div>
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                
                            </div>
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                
                            </div>
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                
                            </div>
                        </div>
                        <div class="inner-box">
                            <div class="sub-inner-box">
                                
                            </div>
                        </div>
                    </div>
                    
                    <div class="menu-content" id="menu-content">
                        <div class="menu-item">
                            <a href="">
                                <span>手机 电话卡</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>电视 盒子</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>笔记本 显示器</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>家电 插线板</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>出行 穿戴</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>智能 路由器</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>电源 配件</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>健康 儿童</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>耳机 音响</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                        <div class="menu-item">
                            <a href="">
                                <span>生活 箱包</span>
                                <i class="icon">&#xe665;</i>
                            </a>
                        </div>
                    </div>
                    <div class="banner" id="banner">
                        <a href="#">
                            <div class="banner-slide slide1 slide-active"></div>
                        </a>
                        <a href="#">
                            <div class="banner-slide slide2"></div>
                        </a>
                        <a href="#">
                            <div class="banner-slide slide3"></div>
                        </a>
                        <a href="#">
                            <div class="banner-slide slide4"></div>
                        </a>
                    </div>
                    <a href="javascript:void(0)" class="button prev" id="prev"></a>
                    <a href="javascript:void(0)" class="button next" id="next"></a>
                    <div class="dots" id="dots">
                        <span class="active"></span>
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                </div>
                
                <div class="lunbotubottpm">
                    <div class="left">
                        <div class="col-md-4 bott">
                            <a href="#">
                                <img src="../../static/images/lunboTottom1.png" class="img-responsive" />
                                <p>小米秒杀</p>
                            </a>
                        </div>
                        <div class="col-md-4 bott">
                            <a href="#">
                                <img src="../../static/images/lunboTottom2.png" class="img-responsive" />
                                <p>企业团购</p>
                            </a>
                        </div>
                        <div class="col-md-4 bott">
                            <a href="#">
                                <img src="../../static/images/lunboTottom3.png" class="img-responsive" />
                                <p>F码通道</p>
                            </a>
                        </div>
                        <div class="col-md-4">
                            <a href="#">
                                <img src="../../static/images/lunboTottom4.png" class="img-responsive" />
                                <p>米粉卡</p>
                            </a>
                        </div>
                        <div class="col-md-4">
                            <a href="#">
                                <img src="../../static/images/lunboTottom5.png" class="img-responsive" />
                                <p>以旧换新</p>
                            </a>
                        </div>
                        <div class="col-md-4">
                            <a href="#">
                                <img src="../../static/images/lunboTottom1.png" class="img-responsive" />
                                <p>话费充值</p>
                            </a>
                        </div>
                    </div>
                    <div class="right">
                        <div class="col-md-4"><a href="#"><img src="../../static/images/lunboTottom7.png" class="img-responsive" /></a></div>
                        <div class="col-md-4"><a href="#"><img src="../../static/images/lunboTottom8.png" class="img-responsive" /></a></div>
                        <div class="col-md-4"><a href="#"><img src="../../static/images/lunboTottom9.png" class="img-responsive" /></a></div>
                    </div>
                </div>
                <br/>
            </div>
        </div>
        <!--小米秒杀-->
        <div class="seckill">
            <div class="col-md-6">
                <p class="miaoshaTop">小米秒杀</p>
            </div>
            <div class="col-md-6 zuoyou">
                <a><div class="clickleft"><span class="glyphicon glyphicon-chevron-left"></span></div></a><a><div class="clickright"><span class="glyphicon glyphicon-chevron-right"></span></div></a>
            </div>
            <div class="container youzuo">
                <div class="left">
                    <span class="timeTo">  </span><span class="timeTo2">  场</span>
                    <img src="../../static/images/miaosha.png" class="img-responsive" />
                    <div id="noStart" style="color:rgb(255,103,0)">活动未开始</div>
                    <div class="div1" id="startNow" style="display: none;">开始购买</div>
                    <div class="div2" id="stopNow" style="display: none;">活动结束</div>
                    <span class="conten2"></span>
                    <div class="timeOue">
                        <div><span class="botHours">00</span></div><p>:</p>
                        <div><span class="botMIn">00</span></div><p>:</p>
                        <div><span class="botSecond">00</span></div>
                    </div>
                </div>
                <div class="right" v-for="(item,index) in seckillArr">
                    <div class="col-md-3 zuiho"><a href="#">
                        <img :src="item.imgUrl" />
                        <h3>{{item.ship_name}}</h3>
                        <h5>{{item.ship_contact}}</h5>
                        <span class="dazhe">{{item.pricenew}}元</span>
                        <span class="weidazhe">&nbsp;{{item.price}}元</span></a>
                    </div>
                </div>
                <div class="right2" v-for="(item,index) in seckillArr2">
                    <div class="col-md-3 zuiho"><a href="#">
                        <img :src="item.imgUrl" />
                        <h3>{{item.ship_name}}</h3>
                        <h5>{{item.ship_contact}}</h5>
                        <span class="dazhe">{{item.pricenew}}元</span>
                        <span class="weidazhe">&nbsp;{{item.price}}元</span></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="fengexian">
            <div class="container">
                <a href="#"><img src="/static/images/fengexian.png" class="img-responsive" /></a>
            </div>
        </div>
        <!--手机板块-->
        <div class="Mobile">
            <div class="col-md-6"><span class="MobileP1">手机</span></div>
            <div class="col-md-6"><a href="#"><span class="MobileP2">查看更多</span></a></div>
            <div class="container Mobiledis">
                <div class="left">
                    <a href="#"><img src="/static/images/Mobile1.png" class="img-responsive" /></a>
                </div>
                <div class="right">
                    <div class="col-md-12">
                        <div class="col-md-3 rightdange" v-for="(item,index) in MobileArr"><a href="#">
                            <img :src="item.imgUrl" class="img-responsive" />
                            <h3>{{item.ship_name}}</h3>
                            <h5>{{item.ship_contact}}</h5>
                            <span class="dazhe">{{item.price}}元起</span></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fengexian2">
            <div class="container">
                <a href="#"><img src="/static/images/fengexian2.png" class="img-responsive" /></a>
            </div>
        </div>
        <!--家电板块-->
        <div class="household">
            <div class="col-md-6"><span class="householdP1">家电</span></div>
            <div class="col-md-6"><span class="householdP2">热门</span>&nbsp;&nbsp;<span class="householdP3">电视音影</span></div>
            <div class="container householddis">
                <div class="left">
                    <div class="col-md-12">
                        <a href="#"><img src="/static/images/household1.png" class="img-responsive"  /></a>
                    </div>
                    <div class="col-md-12">
                        <a href="#"><img src="/static/images/household2.png" class="img-responsive"  /></a>
                    </div>
                </div>
                <div class="right">
                    <div class="col-md-3 zuiho" v-for="(item,index) in householdArr"><a href="#">
                        <img :src="item.imgUrl"  class="img-responsive"/>
                        <h3>{{item.ship_name}}</h3>
                        <h5>{{item.ship_contact}}</h5>
                        <span class="dazhe">{{item.pricenew}}元</span>
                        <span class="weidazhe">&nbsp;{{item.price}}元</span></a>
                    </div>
                </div>
            </div>
        </div>
        <div class="fengexian3">
            <div class="container">
                <a href="#"><img src="/static/images/fengexian3.png" class="img-responsive" /></a>
            </div>
        </div>
        <!--智能板块-->
        <div class="intelligence">
            <div class="col-md-6"><span class="householdP1">智能</span></div>
            <div class="col-md-6"><span class="householdP2">热门</span>&nbsp;&nbsp;<span class="householdP3">安防</span></div>
            <div class="container householddis">
                <div class="left">
                    <div class="col-md-12">
                        <a href="#"><img src="/static/images/intelligence1.png" class="img-responsive"  /></a>
                    </div>
                    <div class="col-md-12" style=" margin-top: 1%;">
                        <a href="#"><img src="/static/images/intelligence2.png" class="img-responsive"  /></a>
                    </div>
                </div>
                <div class="right">
                    <div class="col-md-3 zuiho" v-for="(item,index) in intelligenceArr"><a href="#">
                        <img :src="item.imgUrl"  class="img-responsive"/>
                        <h3>{{item.ship_name}}</h3>
                        <h5>{{item.ship_contact}}</h5>
                        <span class="dazhe">{{item.pricenew}}元</span>
                        <span class="weidazhe">&nbsp;{{item.price}}元</span></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>



export default {
    name: 'Index',
    data(){
        return{
            TopSHPhone1Arr:[],
            TopSHPhone2Arr:[],
            TopSHTelevision:[],
            seckillArr:[],
            seckillArr2:[],
            MobileArr:[],
            householdArr:[],
            intelligenceArr:[]
        }
    },
    // 192.168.189.243
    mounted(){
           var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=TopSHPhone1')
        .then(function(res){
       //     console.log(res);
            _this.TopSHPhone1Arr=res.data
        //    console.log(_this.TopSHPhone1Arr)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=TopSHPhone2')
        .then(function(res){
        //   console.log(res);
            _this.TopSHPhone2Arr=res.data
         //   console.log(_this.TopSHPhone2Arr)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=TopSHTelevision')
        .then(function(res){
        //   console.log(res);
            _this.TopSHTelevision=res.data
        //    console.log(_this.TopSHTelevision)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=miaosha')
        .then(function(res){
        //   console.log(res);
            _this.seckillArr=res.data
         //   console.log(_this.seckillArr)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=miaosha2')
        .then(function(res){
        //   console.log(res);
            _this.seckillArr2=res.data
      //      console.log(_this.seckillArr2)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=Mobile')
        .then(function(res){
        //   console.log(res);
            _this.MobileArr=res.data
         //   console.log(_this.MobileArr)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=household')
        .then(function(res){
        //   console.log(res);
            _this.householdArr=res.data
           // console.log(_this.householdArr)
        })
        .catch(function(err){
            console.log(err)
        });
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/Shipping_Info?PageName=intelligence')
        .then(function(res){
        //   console.log(res);
            _this.intelligenceArr=res.data
         //   console.log(_this.intelligenceArr)
        })
        .catch(function(err){
            console.log(err)
        });

    }
};
$(function(){
    // 顶部购物车变换
    $(".top .nav .right li:eq(4)").hover(function(){
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
    $(".Carousel,.top").mouseover(function(){
        $(".TopSH").hide();
    });
    //轮播图耳机菜单变色
    $(".menu-item").hover(function(){
        $(this).css("background-color","rgb(255,103,0)");
    },function(){
        $(this).css("background-color","rgba(255,103,0,0)");
    });
    //轮播下活动变色
    $(".lunbotubottpm .left div").hover(function(){
        $(this).children().children().css("color","white");
    },function(){
        $(this).children().children().css("color","rgb(180,177,173)");
    });
    //小米秒杀切换
    $(".zuoyou .clickleft").click(function(){
        $(".youzuo .right2").hide();
        $(".youzuo .right").slideDown(500);
    });
    $(".zuoyou .clickright").click(function(){
        $(".youzuo .right").hide();
        $(".youzuo .right2").slideDown(500);
    });


    //轮播和二级菜单
    var timer = null,
    index = 0,
    pics = byId("banner").getElementsByTagName("div"),
    dots = byId("dots").getElementsByTagName("span"),
    size = pics.length,
    prev = byId("prev"),
    next = byId("next"),
    menuItems = byId("menu-content").getElementsByTagName("div"),
    subMenu = byId("sub-menu"),
    subItems = subMenu.getElementsByClassName("inner-box");

    function addHandler(element, type, handler) {
        if (element.addEventListener) {
            element.addEventListener(type, handler, true);
        }
        else if (element.attachEvent) {
            element.attachEvent('on' + type, handler);
        }
        else {
            element['on' + type] = handler;
        }
    }

    function byId(id){
        return typeof(id)==="string"?document.getElementById(id):id;
    }

    // 清除定时器,停止自动播放
    function stopAutoPlay(){
        if(timer){
        clearInterval(timer);
        }
    }

    // 图片自动轮播
    function startAutoPlay(){
    timer = setInterval(function(){
        index++;
        if(index >= size){
            index = 0;
        }
        changeImg();
    },3000)
    }

    function changeImg(){
    for(var i=0,len=dots.length;i<len;i++){
        dots[i].className = "";
        pics[i].style.display = "none";
    }
    dots[index].className = "active";
    pics[index].style.display = "block";
    }

    function slideImg(){
        startAutoPlay();
        var main = byId("main");
        var banner = byId("banner");
        var menuContent = byId("menu-content");

        addHandler(main,"mouseover",stopAutoPlay);
        addHandler(main,"mouseout",startAutoPlay);

        // 点击导航切换
        for(var i=0,len=dots.length;i<len;i++){
        dots[i].id = i;
        addHandler(dots[i],"click",function(){
            index = this.id;
            changeImg();
        })
        }

        // 下一张
        addHandler(next,"click",function(){
        index++;
        if(index>=size) index=0;
        changeImg();
        })

        // 上一张
        addHandler(prev,"click",function(){
        index--;
        if(index<0) index=size-1;
        changeImg();
        })

        // 菜单
        for(var m=0,mlen=menuItems.length;m<mlen;m++){
            menuItems[m].setAttribute("data-index",m);
            addHandler(menuItems[m],"mouseover",function(){
                subMenu.className = "sub-menu";
                var idx = this.getAttribute("data-index");
                for(var j=0,jlen=subItems.length;j<jlen;j++){
                subItems[j].style.display = 'none';
                //    menuItems[j].style.background = "none";
                }
                subItems[idx].style.display = "block";
                // menuItems[idx].style.background = "rgba(0,0,0,0.1)";
            });
        }

        addHandler(subMenu,"mouseover",function(){
            this.className = "sub-menu";
        });

        addHandler(subMenu,"mouseout",function(){
            this.className = "sub-menu hide";
        });

        addHandler(banner,"mouseout",function(){
            subMenu.className = "sub-menu hide";
        });

        addHandler(menuContent,"mouseout",function(){
            subMenu.className = "sub-menu hide";
        });
    }

    addHandler(window,"load",slideImg);




    
});




$(function() {
  fn()
  function fn() {
   var timer = setInterval(function() {
    var start = '2021/06/09 00:00:00';
    var StartTime = new Date(start);
    var NowTime = new Date();
    var day = NowTime.getDate();
    var month = NowTime.getMonth() + 1;
    var year = NowTime.getFullYear();
    var tw = year + '/' + month + '/' + day + ' 08:00:00';
    var ei = year + '/' + month + '/' + day + ' 10:00:00';
    var tw1 = year + '/' + month + '/' + day +' 14:00:00';
    var ei1 = year + '/' + month + '/' + day +' 20:00:00';
    tw = new Date(tw).getTime();
    ei = new Date(ei).getTime();
    tw1 = new Date(tw1).getTime();
    ei1 = new Date(ei1).getTime();
    var EndTime = '';
    if(NowTime < StartTime) {
        EndTime = StartTime;
        $('#stopNow').css('display', 'none');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'block');
        $(".content2").html("距离活动开始剩余");
        $(".timeTo").html("8:00");
    } else {
        if(NowTime < tw) {
        EndTime = tw;
        $('#stopNow').css('display', 'none');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'block');
        $(".conten2").html("距离活动开始剩余");
        $(".timeTo").html("8:00");
     } else if(NowTime >= tw && NowTime < ei) {
      EndTime = ei;
        $('#stopNow').css('display', 'none');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'block');
        $(".conten2").html("距离活动开始剩余");
        $(".timeTo").html("10:00");
     }else if(NowTime < tw1){
      EndTime =tw1;
        $('#stopNow').css('display', 'none');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'block');
        $(".conten2").html("距离活动开始剩余");
        $(".timeTo").html("14:00");
     } else if(NowTime >= tw1 && NowTime < ei1) {
      EndTime = ei1;
        $('#stopNow').css('display', 'none');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'block');
        $(".conten2").html("距离活动开始剩余");
        $(".timeTo").html("20:00");
     }else if(NowTime >= ei1) {
      EndTime = tw + 24 * 60 * 60 * 1000;
        $('#stopNow').css('display', 'block');
        $('#startNow').css('display', 'none');
        $('#noStart').css('display', 'none');
        $(".conten2").html("距离活动开始剩余");
        $(".timeTo").html("8:00");
     }
    }
    //console.log(EndTime)
    var t = EndTime - NowTime;
    if(t < 1000) {
     window.location.reload();
     clearInterval(timer);
     timer = null;
     return false;
    }
    var d = 0;
    var h = 0;
    var m = 0;
    var s = 0;
    if(t >= 0) {
     d = Math.floor((t / 1000 / 3600) / 24);
     h = Math.floor((t / 1000 / 3600) % 24);
     m = Math.floor((t / 1000 / 60) % 60);
     s = Math.floor(t / 1000 % 60);
     if(d < 10) {
      d = "0" + d;
     }
     if(h < 10) {
      h = "0" + h;
     }
     if(m < 10) {
      m = "0" + m;
     }
     if(s < 10) {
      s = "0" + s;
     }
     $('.botHours').html(h);
     $('.botMIn').html(m);
     $('.botSecond').html(s);
    }
   }, 1000)
  }
 });










</script>

<style>
    @import"../../static/css/index.css";
</style>
