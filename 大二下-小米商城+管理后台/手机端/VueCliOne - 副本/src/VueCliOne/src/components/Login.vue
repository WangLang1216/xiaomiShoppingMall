<template>
    <div id="login">
        <div class="central">
            <div class="left"><img src="/static/images/banner.jpg" class="img-responsive" /></div>
            <div class="right">
                <!--顶部导航-->
                <nav class="navbar navbar-default" style="background-color: white;border: 0px;z-index: 999;">
                    <div class="container-fluid">
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#"><img src="/static/images/logo-mi21.png" width="23%" style="background-color: white;margin-top: -5%;margin-left: 65%;"/></a>
                        <a class="navbar-brand" href="#"><span style="font-size: 25px;font-weight: 600;color: black;">小米账号</span></a>
                        </div>
                    
                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                            <ul class="nav navbar-nav navbar-right">
                                <li><a href="#"><span>用户政策</span></a></li>
                                <li><a href="#"><span>隐私政策</span></a></li>
                                <li><a href="#"><span>帮助中心</span></a></li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">中文(简体)<span class="caret"></span></a>
                                    <ul class="dropdown-menu">
                                    <li><a href="#">中文(繁体)</a></li>
                                    <li><a href="#">English</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div><!-- /.navbar-collapse -->
                    </div><!-- /.container-fluid -->
                </nav>
                <!--中部-->
                <div class="section container-fluid">
                    <div class="row">
                        <div class="col-md-3 col-sm-3"></div>
                        <div class="col-md-6 col-sm-6">
                            <div class="row">
                                <div class="col-md-2 col-sm-2"></div>
                                <div class="col-md-9 col-sm-9 theme">
                                    <div class="row">
                                        <div class="col-md-12 col-sm-12">
                                            <a href="#"><span class="denglutext">登录</span></a>&nbsp;&nbsp;
                                            <a href="#"><span class="zhucetext">注册</span></a>
                                            <div style="display: flex;">
                                                <div class="dengluxhx"></div>&nbsp;&nbsp;&nbsp;
                                                <div class="zhucexhx"></div>
                                            </div>
                                        </div>
                                        <!--登录-->
                                        <div class="col-md-12 col-sm-12" id="denglu">
                                           
                                                <div class="form-group">
                                                <input type="name" class="form-control" id="LoginName" placeholder="手机号码">
                                                </div>
                                                <div class="form-group">
                                                <input type="password" class="form-control" id="LoginPwd" placeholder="密码">
                                                <p class="cuowu">用户名或密码不正确</p>
                                                </div>
                                               <button type="submit" class="btn btn-default" id="LoginHd">登录</button>
                                           
                                            <div class="col-md-12 col-sm-12 wjsj">
                                                <p><a href="#">忘记密码？</a></p>
                                                <p><a href="#">手机号登录</a></p>
                                            </div>
                                        </div>
                                        <!--注册-->
                                        <div class="col-md-12 col-sm-12" id="zhuce">
                                            <!-- <form> -->
                                                <div class="form-group">
                                                <input type="name" class="form-control" id="RegisterName" placeholder="账号">
                                                </div>
                                                <input type="password" class="form-control" id="RegisterPwd" placeholder="密码">
                                                  <div class="form-group" style="display: none;" id="RegisterPwdQ">
                                                    <input type="password" class="form-control" id="RegisterPwdT" placeholder="确认密码">
                                                    
                                                </div>
                                                </div>
                                             
                                                <button type="submit" class="btn btn-default btnzhuce" style="display: none;width: 93%;margin-left: 3.5%;" id="Register">注册</button>
                                            <!-- </form> -->
                                            <div class="col-md-12 col-sm-12" style="text-align: center;margin-top: 10%;letter-spacing: 1px;">
                                                <span style="color: rgb(183,183,183);">已阅读并同意小米帐号</span>&nbsp;用户协议<span style="color: rgb(183,183,183);">&nbsp;和</span><span>&nbsp;隐私政策</span>
                                            </div>
                                        </div>
                                        <div class="col-md-12 col-sm-12 qtfs">
                                            <p>其他方式登录</p>
                                        </div>
                                        <div class="col-md-1 col-sm-1 col-xs-1"></div>
                                        <div class="col-md-10 col-sm-10 col-xs-10 qitafangshidenglu">
                                            <div class="col-md-3 col-sm-3 col-xs-3"><a href="#"><img src="/static/images/QQ.png" class="img-responsive" /></a></div>
                                            <div class="col-md-3 col-sm-3 col-xs-3"><a href="#"><img src="/static/images/weibo.png" class="img-responsive" /></a></div>
                                            <div class="col-md-3 col-sm-3 col-xs-3"><a href="#"><img src="/static/images/zhifubao.png" class="img-responsive" /></a></div>
                                            <div class="col-md-3 col-sm-3 col-xs-3"><a href="#"><img src="/static/images/weixin.png" class="img-responsive" /></a></div>
                                        </div>
                                        <div class="col-md-1 col-sm-1 col-xs-1"></div>
                                    </div>
                                </div>
                                <div class="col-md-2 col-sm-2"></div>
                            </div>
                        </div>
                        <div class="col-md-3 col-sm-3"></div>
                        <div class="col-md-12 col-sm-12 dibuwenzi">
                            <p>小米公司版权所有-京ICP备10046444-京公网安备11010802020134号-京ICP证110507号</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'Login',
}
    $(function(){
            $(".zhucetext").click(function(){
                $("#zhuce").show();
                $(".zhucexhx").show();
                $(".btnzhuce").show();
                $(".zhucetext").css("font-size","23px");
                $(".zhucetext").css("font-weight","600");
                $(".zhucetext").css("color","black");
                $(".denglutext").css("font-size","23px");
                $(".denglutext").css("color","rgb(187,187,187)");
                $("#denglu").hide();
                $(".dengluxhx").hide();
            });
            $(".denglutext").click(function(){
                $("#denglu").show();
                $(".dengluxhx").show();
                $(".denglutext").css("font-size","23px");
                $(".denglutext").css("font-weight","600");
                $(".denglutext").css("color","black");
                $(".zhucetext").css("font-size","23px");
                $(".zhucetext").css("color","rgb(187,187,187)");
                $("#zhuce").hide();
                $(".btnzhuce").hide();
                $(".zhucexhx").hide();
            });
            
            $('#LoginHd').click(function(){
                var patten= new RegExp(/^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$/);
                
         var name=document.getElementById("LoginName").value;
         var pwd=document.getElementById("LoginPwd").value;
           if(patten.test(name)){
        $.ajax({
              url: "http://localhost:61386/api/Login/Logind?result="+"",
              type: "post",
              data:{
                  customer_id:name,
                  password:pwd
              }
          }).done(function (data) {
             if(data=="登录成功"){
             alert(data);             
                sessionStorage.setItem("loginName",name);
                localStorage.setItem('hou', JSON.stringify(name));
               window.location.href = "http://localhost:8081/#/index";
             }
             else {
                     alert(data)    
             }
         })
         }
         else{
             alert("账号格式不正确")
         }
            });
            $('#Register').click(function(){
                var patten= new RegExp(/^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$/);
         var name=document.getElementById("RegisterName").value;
         var pwd=document.getElementById("RegisterPwd").value;
         var pwdt=document.getElementById("RegisterPwdT").value;
       
           if(patten.test(name)){
                 if(pwd==pwdt){
                      $.ajax({
              url: "http://localhost:61386/api/Login/LoginAH",
              type: "post",
              data:{
                  customer_id:name,
                  password:pwd,
                  login_name:"me"
              }
          }).done(function (data) {
             if(data){
                 alert(data)
             }
         })
                 }else{
             alert("两次密码不一致")
         }
         }
         else{
             alert("账号格式不正确")
         }
         
            });
            $("#RegisterPwd").click(function(){
          $("#RegisterPwdQ").show()
            });
        });
</script>

<style>
    @import"../../static/css/login.css";
</style>
