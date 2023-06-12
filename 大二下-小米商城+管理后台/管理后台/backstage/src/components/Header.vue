<template>
    <div id="header">
        <div class="top">
            <div class="left">
                <ul>
                    <li><a href="#"><img src="/static/images/log.png" /></a></li>
                    <li><h3>优品汇</h3></li>
                    <li><a href="#"><span>首页</span></a></li>
                    <li><a href="#"><router-link to="/"><span>商品</span></router-link></a></li>
                    <li><a href="#"><span>订单</span></a></li>
                    <li><a href="#"><span>库存</span></a></li>
                    <li><a href="#"><router-link to="/users"><span>用户</span></router-link></a></li>
                    <li><a href="#"><span>促销</span></a></li>
                    <li><a href="#"><span>运营</span></a></li>
                    <li><a href="#"><span>内容</span></a></li>
                    <li><a href="#"><span>统计</span></a></li>
                    <li><a href="#"><span>财务</span></a></li>
                    <li><a href="#"><span>设置</span></a></li>
                    <li><a href="#"><span>权限</span></a></li>
                </ul>
            </div>
            <div class="right">
                <ul>
                    <li><span class="glyphicon glyphicon-user">&nbsp;admin</span></li>
                    <li><a href="#"><span class="glyphicon glyphicon-home"></span></a></li>
                    <li><a href="#"><span class="glyphicon glyphicon-tasks"></span></a></li>
                    <li><a href="#"><span class="glyphicon glyphicon-bell"></span></a></li>
                    <li><a href="#"><span class="glyphicon glyphicon-calendar"></span></a></li>
                    <li><a href="#"><span class="glyphicon glyphicon-off"></span></a></li>
                </ul>
            </div>
        </div>
    </div>
</template>

<script>

export default {
    name: 'Header',
}
</script>

<style scoped>
    @import"../../static/css/header.css";
</style>
