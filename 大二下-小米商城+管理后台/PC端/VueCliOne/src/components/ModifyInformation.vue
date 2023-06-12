<template>
    <div id="modifyInformation">
        <!--顶部导航-->
        <nav class="navbar navbar-default" style="background-color: rgb(246,246,246);border: 0px;z-index: 999;">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#" style="display: flex;"><img src="/static/images/logo-mi21.png" width="15%" height="230%" style="background-color: white;margin-top:-3%;"/><span style="font-size: 25px;font-weight: 600;color: black;margin-top:2%">&nbsp;小米账号</span></a>
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
        <!--个人信息-->
        <div class="personal">
            <div class="container">
                <div class="left">
                    <div class="col-md-12 toxiang">
                        <img src="/static/images/toxiang.png" />
                        <!--昵称-->
                        <h4  v-for="(kool,index) in custInf">{{kool.customer_name}}</h4>
                        <!--手机号-->
                        <div><span>+86  </span><span  v-for="(item,index) in custLogInf">{{item.customer_id}}</span></div>
                    </div>
                    <div class="col-md-12 daohang">
                        <ul>
                            <li><a href="#">登录安全</a></li>
                            <li><a href="#" style="color: rgb(255,103,0);">个人信息</a></li>
                            <li><a href="#">隐身中心</a></li>
                            <li><a href="#">绑定授权</a></li>
                            <li><a href="#">帮助中心</a></li>
                        </ul>
                    </div>
                </div>
                <div class="right">
                    <div class="col-md-12"><p>&nbsp;个人信息</p></div>
                    <div class="col-md-12 neirong">
                        <div class="form-group">
                            <label for="exampleInputName2">昵称：</label>
                            <input type="text" class="form-control" id="CustomerName" placeholder="请输入昵称">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputSex2">性别：</label>
                            <select class="form-control" id="Sex">
                                <option>男</option>
                                <option>女</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputEmail2">邮箱：</label>
                            <input type="email" class="form-control" id="CustomerEmail" placeholder="jane.doe@example.com">
                        </div>
                        <div class="form-group">
                            <label for="inputPassword">年龄:</label>
                            <input type="text" class="form-control" id="Age" placeholder="年龄" style="margin-left: 3.1%;">
                        </div>
                        <div class="form-group">
                            <label for="exampleInputName2">地区：</label>
                            <input type="text" class="form-control" id="ReceivingAddress" placeholder="请输入收货地址">
                        </div>
                        <div class="form-group tuchu">
                            <button type="button" class="btn btn-danger" id="Dian">保存/修改</button>
                            <router-link to="/my"><button type="button" class="btn btn-danger tuchus">退出</button></router-link>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

    export default {
        name: 'ModifyInformation',
         data(){
         return{
              custInf:[],
              custLogInf:[]
         }   
         },
      mounted(){
               var ID = JSON.parse(localStorage.getItem('hou'));  //取
                var _this=this;
            this.$http.get("http://localhost:61386/api/Login/GetInf?ID="+ID)
            .then(function(res){
                console.log(res);
                _this.custInf=res.data
                
                console.log(_this.custInf)
            })
            .catch(function(err){
                console.log(err)
            });
                 var _this=this;
            this.$http.get("http://localhost:61386/api/Login/GetLogin?ID="+ID)
            .then(function(res){
                console.log(res);
                _this.custLogInf=res.data
                
                console.log(_this.custLogInf)
            })
            .catch(function(err){
                console.log(err)
            });
      },
    }
   
  
     $(function(){

           $('#Dian').click(function(){         
                 var name=document.getElementById("CustomerName").value;
                      var email=document.getElementById("CustomerEmail").value;
         var Receiving=document.getElementById("ReceivingAddress").value;
         var age=document.getElementById("Age").value;
         var Sex=document.getElementById("Sex").value;
         var ID = JSON.parse(localStorage.getItem('hou'));  //取
               $.ajax({
              url: "http://localhost:61386/api/Login/BoolCustomer_Infs?ID="+ID,
              type: "get",
            
          }).done(function (data) {
             if(data){
                 console.log(data)
                $.ajax({
              url: "http://localhost:61386/api/Login/AddCustomer_Inf",
              type: "post",
              data:{
                  customer_id:ID,
                  customer_name:name,
                  identity_card_type:"身份证",
                  identity_card_num:"112112112112112111",
                  mobile_phone:"12345678901",
                  customer_email:email,
                  sex:Sex,
                user_money:age,
                customer_level:"白银",
                ReceivingAddress:Receiving,
                  
              }
          }).done(function (data) {
             if(data){
              alert("保存成功")
              
             }
         })
              
             }
             else{

                  $.ajax({
              url: "http://localhost:61386/api/Login/UpDateCustomer_Infs?ID="+ID,
              type: "post",
              data:{                
                  customer_name:name,
                  identity_card_type:"身份证",
                  identity_card_num:"112112112112112111",
                  mobile_phone:"12345678901",
                  customer_email:email,
                  sex:Sex,
                user_money:age,
                customer_level:"白银",
                ReceivingAddress:Receiving,                  
              }
          }).done(function (data) {
             if(data){
               alert("更新成功")
              
             }
         })

             }
         })


               
           })
     })
</script>

<style>
    @import"../../static/css/ModifyInformation.css";
</style>
