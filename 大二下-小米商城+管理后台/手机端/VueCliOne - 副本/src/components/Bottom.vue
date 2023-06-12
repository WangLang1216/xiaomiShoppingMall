<template>
    <div id="bottom">
        <!--底部导航栏-->
        <div class="dibudaohang">
            <div>
                <router-link to="/">
                    <img src="/static/images/dibudaohang1.png" />
                    <h6>首页</h6>
                </router-link>
            </div>
            <div>
                <router-link to="/sort">
                    <img src="/static/images/dibudaohang2.png" />
                    <h6>分类</h6>
                </router-link>
            </div>
            <div>
                <img src="/static/images/dibudaohang3.png" />
                <h6>米圈</h6>
            </div>
            <div>
                <router-link to="/shopCar">
                    <img src="/static/images/dibudaohang4.png" />
                    <h6>购物车</h6>
                </router-link>
            </div>
            <div>
                <router-link to="/my">
                    <img src="/static/images/dibudaohang5.png" />
                    <h6>我的</h6>
                </router-link>
            </div>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'Bottom'
    }
</script>

<style scoped>
    @import"../../static/css/bottom.css";
</style>
