<template>
    <div id="productDetails">
        <!--头部-->
        <div class="top">
            <router-link to="/"><img src="/static/images/fanhui.png" /></router-link>
            <img src="/static/images/shangchuan.png" />
        </div>
        <!--轮播图-->
        <div class="Carousel">
            <mt-swipe :auto="3000">
                <mt-swipe-item><img src="/static/images/PDLB5.jpg" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/PDLB6.jpg" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/PDLB7.jpg" /></mt-swipe-item>
                <mt-swipe-item><img src="/static/images/PDLB2.jpg" /></mt-swipe-item>
            </mt-swipe>
        </div>
        <!--内容-->
        <div class="content">
            <div class="jiage">
                <span>￥</span><span>4799  </span><span>￥5299</span>
            </div>
            <div class="gengduo">
                <div class="yuyue"><span>预约得480米金</span></div>
                <h4>更多 ></h4>
            </div>
            <div class="mixin">
                <img src="/static/images/xiaomishangx.png" />
                <span>来这里，发现属于你的新品</span>
            </div>
        </div>
        <!--介绍-->
        <div class="introduce">
            <ul>
                <li><h3>小米11 Pro</h3></li>
                <li><span>「闪降500元！限量领北京消费券减100元！+1元得小米手环5NFC版，+1元得小米定制T恤；+1元得200G云空间月卡」</span></li>
                <li><span class="glyphicon glyphicon-copyright-mark">【专业影像】超感光夜景相机+电影镜头VLOG模式</span></li>
                <li><span class="glyphicon glyphicon-registration-mark">【突破性能】全新骁龙888+新型散热材料+WiFi6增强版</span></li>
                <li><span class="glyphicon glyphicon-link">【极速快充】5000mAh大电池+双67W快充+10W反向充</span></li>
                <li><div><span>限量领成都消费券立减100元></span></div></li>
            </ul>
        </div>
        <div class="mykf"></div>
        <div class="dibu">
            <div class="left">
                <div><img src="/static/images/dibudaohang1.png" /><p>首页</p></div>
                <div><img src="/static/images/kefu.png" /><p>客服</p></div>
                <div><img src="/static/images/dibudaohang4.png" /><p>购物车</p></div>
            </div>
            <div class="right">
                <div><span>加入购物车</span></div>
            </div>
        </div>
        <!--弹出-->
        <div class="eject">
            <div class="tupian">
                <div class="left">
                    <img src="/static/images/gowuche1.png" />
                    <img src="/static/images/gowuche2.png" />
                    <img src="/static/images/gowuche3.png" />
                </div>
                <div class="right">
                    <div>
                        <span>￥4799 </span><span>￥5299</span>
                        <span>￥4499 </span><span>￥4999</span>
                        <span>￥5199 </span><span>￥5699</span>
                        <br/>
                        <span>小米11 Pro</span>
                        <span> 8GB+256GB</span>
                        <span> 8GB+128GB</span>
                        <span> 12GB+256GB</span>
                        <span> 黑色</span>
                        <span> 绿色</span>
                        <span> 紫色</span>
                    </div>
                </div>
            </div>
            <div class="banben">
                <p>版本</p>
                <div class="xuanz">
                    <div><span>8G+256G</span></div>
                    <div><span>8G+128G</span></div>
                    <div><span>12G+256G</span></div>
                </div>
            </div>
            <div class="yanse">
                <p>颜色</p>
                <div class="xuanz">
                    <div><span>黑色</span></div>
                    <div><span>绿色</span></div>
                    <div><span>紫色</span></div>
                </div>
            </div>
            <div class="taozhuang">
                <p>套装</p>
                <div class="xuanz">
                    <div><span>标配</span></div>
                    <div><span>套装版（赠送充电器）</span></div>
                </div>
            </div>
            <div class="shuliang">
                <p>购买数量</p>
                <div class="number-box">
                    <input type="button" class="on-number" value="-" data-v="-1">
                    <input type="text" value="0">
                    <input type="button" class="on-number" value="+" data-v="1">
                </div>
            </div>
            <router-link to="/shopCar"><button><span>确定</span></button></router-link>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'ProductDetails',
        components: {

        },

    };
    $(function(){
        $(".dibu .right div").click(function(){
            $(".eject").slideDown();
            $(".eject").css("box-shadow","rgb(49,49,49) 0px -100px 500px");
        });
        $(".Carousel").click(function(){
            $(".eject").slideUp();
        });
        //选择商品切换
        $(".banben .xuanz div:eq(0)").addClass("fujia");
        $(".yanse .xuanz div:eq(0)").addClass("fujia");
        $(".taozhuang .xuanz div:eq(0)").addClass("fujia");
        $(".banben .xuanz div:eq(0)").click(function(){
            $(this).addClass("fujia");
            $(".tupian .right div span").hide();
            $(".tupian .right div span:eq(0),.tupian .right div span:eq(1),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(10)").show();
            $(".banben .xuanz div:eq(1),.banben .xuanz div:eq(2)").removeClass("fujia");

            $(".yanse .xuanz div:eq(0)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(0),.tupian .right div span:eq(1),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(10)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(1)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(0),.tupian .right div span:eq(1),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(11)").show();
                $(".yanse .xuanz div:eq(0),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(2)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(0),.tupian .right div span:eq(1),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(12)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(0)").removeClass("fujia");
            });
        });


        $(".banben .xuanz div:eq(1)").click(function(){
            $(this).addClass("fujia");
            $(".tupian .right div span").hide();
            $(".tupian .right div span:eq(2),.tupian .right div span:eq(3),.tupian .right div span:eq(6),.tupian .right div span:eq(8),.tupian .right div span:eq(10)").show();
            $(".banben .xuanz div:eq(0),.banben .xuanz div:eq(2)").removeClass("fujia");

            $(".yanse .xuanz div:eq(0)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(2),.tupian .right div span:eq(3),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(10)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(1)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(2),.tupian .right div span:eq(3),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(11)").show();
                $(".yanse .xuanz div:eq(0),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(2)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(2),.tupian .right div span:eq(3),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(12)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(0)").removeClass("fujia");
            });
        });
        $(".banben .xuanz div:eq(2)").click(function(){
            $(this).addClass("fujia");
            $(".tupian .right div span").hide();
            $(".tupian .right div span:eq(4),.tupian .right div span:eq(5),.tupian .right div span:eq(6),.tupian .right div span:eq(9),.tupian .right div span:eq(10)").show();
            $(".banben .xuanz div:eq(1),.banben .xuanz div:eq(0)").removeClass("fujia");
            $(".yanse .xuanz div:eq(0)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(4),.tupian .right div span:eq(5),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(10)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(1)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(4),.tupian .right div span:eq(5),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(11)").show();
                $(".yanse .xuanz div:eq(0),.yanse .xuanz div:eq(2)").removeClass("fujia");
            });
            $(".yanse .xuanz div:eq(2)").click(function(){
                $(this).addClass("fujia");
                $(".tupian .right div span").hide();
                $(".tupian .right div span:eq(4),.tupian .right div span:eq(5),.tupian .right div span:eq(6),.tupian .right div span:eq(7),.tupian .right div span:eq(12)").show();
                $(".yanse .xuanz div:eq(1),.yanse .xuanz div:eq(0)").removeClass("fujia");
            });
        });

        $(".yanse .xuanz>div:eq(0)").click(function(){
            $(this).addClass("fujia");
            $(".yanse .xuanz>div:eq(1),.yanse .xuanz>div:eq(2)").removeClass("fujia");
            $(".tupian .left img:eq(0)").show();
            $(".tupian .left img:eq(1)").hide();
            $(".tupian .left img:eq(2)").hide();
        });
        $(".yanse .xuanz>div:eq(1)").click(function(){
            $(this).addClass("fujia");
            $(".yanse .xuanz>div:eq(0),.yanse .xuanz>div:eq(2)").removeClass("fujia");
            $(".tupian .left img:eq(1)").show();
            $(".tupian .left img:eq(0)").hide();
            $(".tupian .left img:eq(2)").hide();
        });
        $(".yanse .xuanz>div:eq(2)").click(function(){
            $(this).addClass("fujia");
            $(".yanse .xuanz>div:eq(1),.yanse .xuanz>div:eq(0)").removeClass("fujia");
            $(".tupian .left img:eq(2)").show();
            $(".tupian .left img:eq(0)").hide();
            $(".tupian .left img:eq(1)").hide();
        });

    });
    $(document.documentElement).on("click",".on-number",function () {
        var $val=$(this).siblings("input[type='text']"),
            val=parseInt($val.val(),10)+parseInt($(this).data("v"));
        $val.val(isNaN(val) ? 0 : val);
    });
    
</script>

<style scoped>
    @import"../../static/css/productDetails.css";
</style>

