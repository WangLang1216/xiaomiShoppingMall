<template>
    <div id="login">
        <div class="top">
            <span>选择语言 </span><span class="glyphicon glyphicon-triangle-bottom"></span>
        </div>
        <div class="zhongbu">
            <img src="/static/images/logo-mi21.png" />
            <p>每一个人都能享受科技的乐趣</p>
        </div>
        <div class="denglu">
            <h4>小米账号登录</h4>
            <div class="biaodan">
                <div class="form-group">
                    <input type="text" class="form-control" id="LoginName" placeholder="账号">
                </div>
                <div class="form-group">
                    <input type="password" class="form-control" id="LoginPwd" placeholder="Password">
                </div>
                <div class="form-group">
                    <button type="button" class="btn btn-danger" id="LoginHd">登录</button>
                </div>
            </div>
            <div class="qitadenglu">
                <span>手机号登录</span><span> | </span><router-link to="/register"><span>立即注册</span></router-link>
                <h5>其他方式登录</h5>
                <div class="tubiao">
                    <div class="row">
                        <div class="col-xs-2"></div>
                        <div class="col-xs-2"><img src="/static/images/QQ.png"/></div>
                        <div class="col-xs-2"><img src="/static/images/weibo.png"/></div>
                        <div class="col-xs-2"><img src="/static/images/zhifubao.png"/></div>
                        <div class="col-xs-2"><img src="/static/images/weixin.png"/></div>
                        <div class="col-xs-2"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'Login',    
        created:function () {
            this.$emit('footer', false);
        }
    }
      $(function(){
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
               // sessionStorage.setItem("loginName",name);
              //  localStorage.setItem('hou', JSON.stringify(name));
              window.location.href = "http://localhost:8082/#/";
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
           
          
      })  
</script>

<style scoped>
    @import"../../static/css/login.css";
</style>
