<template>
    <div id="register">
        <div class="top">
            <router-link to="/login"><img src="/static/images/jianto.png" /></router-link>
        </div>
        <div class="zhongbu">
            <h4>注册小米账号</h4>
            <h5>系统会根据您选择的国家/地区的法律法规储存你您的个人信息</h5>
            <div class="biaodanzc">
               
                <div class="form-group">
                    <input type="text" class="form-control" id="RegisterName" placeholder="手机号码">
                </div>
                <div class="form-group">
                    <input type="password" class="form-control" id="RegisterPwd" placeholder="密码">
                </div>
                 <div class="form-group">
                    <input type="password" class="form-control" id="RegisterPwdT" placeholder="确认密码">
                </div>
                   <div class="form-group">
                   <button type="button" class="btn btn-danger" id="Register">注册</button>
                </div>
                <div class="form-group">
                    <router-link to="/login"><button type="button" class="btn btn-danger" id="">下一步</button></router-link>
               </div>
            </div>
            <div class="dibu">
                <span class="hui">已阅读并同意小米账号</span><span class="lan"> 用户协议 </span><span class="hui">和 </span><span class="lan">隐私政策</span>
            </div>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'Register',
    }
    $(function(){
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
    })
   
</script>

<style scoped>
    @import"../../static/css/register.css";
</style>