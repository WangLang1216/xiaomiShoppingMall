<template>
    <div id="users">
        <!--左侧列表-->
        <div class="list">
            <div class="titleOne">
                <p>用户管理</p>
            </div>
            <ul>
                <li><a href="#"><span>用户列表</span></a></li>
                <li><a href="#"><span>购买力筛选</span></a></li>
                <li><a href="#"><span>标签管理</span></a></li>
                <li><a href="#"><span>会员等级设置</span></a></li>
            </ul>
            <div class="titleOne">
                <p>成长值及优币</p>
            </div>
            <ul>
                <li><a href="#"><span>成长值及优币查询</span></a></li>
                <li><a href="#"><span>任务奖励设置</span></a></li>
                <li><a href="#"><span>更多规则设置</span></a></li>
            </ul>
        </div>
        <!--右侧内容-->
        <div class="contentOne">
            <div class="title">
                <div></div><p>&nbsp;用户列表</p>
            </div>
            <div class="whole">
                <div class="query">
                    <div class="titles">
                        <p class="glyphicon glyphicon-triangle-bottom">筛选查询</p>
                        <button class="btn btn-default" type="submit" @click="cha()"><span>查询结果</span></button>
                    </div>
                    <div class="search">
                        <div>
                            <span>用户账号：  </span><input type="text" placeholder="用户ID/账号"  id="SsID"/>
                        </div>
                        <div>
                            <span>用户昵称：  </span><input type="text" placeholder="用户昵称"  id="SsName"/>
                        </div>
                        <div>
                            <span>用户性别：  </span><input type="text" placeholder="用户性别" />
                        </div>
                    </div>
                </div>
                <div class="data">
                    <div class="titles">
                        <p class="glyphicon glyphicon-triangle-bottom">数据列表</p>
                        <div class="btn-group sort" role="group">
                            <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                排序方式
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu">
                                <li><a href="#">按会员等级</a></li>
                                <li><a href="#">按订单数量</a></li>
                                <li><a href="#">按消费金额</a></li>
                            </ul>
                        </div>
                    </div>
                    <!--渲染数据-->
                    <div class="form">
                        <div class="top">
                            <div><span>用户ID</span></div>
                            <div><span>用户昵称</span></div>
                            <div><span>会员等级</span></div>
                            <div><span>邮箱地址</span></div>
                            <div><span>用户积分</span></div>
                            <div><span>消费金额</span></div>
                            <div><span>用户地址</span></div>
                            <div><span>操作</span></div>
                        </div>
                        <!--数据-->
                        <div class="content" v-for="(item,index) in commodityArr">
                            <div><span>{{item.customer_inf_id}}</span></div>
                            <div><span>{{item.customer_name}}</span></div>
                            <div><span>{{item.customer_level}}</span></div>
                            <div><span>{{item.customer_email}}</span></div>
                            <div><span>{{item.user_point}} 分</span></div>
                            <div><span>{{item.user_money}} 元</span></div>
                            <div><span>{{item.ReceivingAddress}}</span></div>
                            <!--编辑和删除-->
                            <div>
                                <a href="#" @click="dele(item.customer_id)"><span>拉黑</span></a>
                            </div>
                        </div>
                    </div>
                </div>
                <!--底部-->
                <div class="bottom">
                    <h5>Copyright © www.AxureUX.com, All Rights Reserved.</h5>
                    <h5>Email : 2605735186@qq.com  QQ: 2605735186</h5>
                    <br/>
                </div>
            </div>
        </div>
    </div>
</template>

<script>


export default {
  name: 'Users',
   data(){
        return{
            commodityArr:[],
            flag:false
        }
    },
    mounted(){
        var _this=this;
        this.$http.get('http://localhost:61386/api/Shipping/GetInfAll')
        .then(function(res){
            // console.log(res);
            _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });              
    },
    methods:{
        cha(){
           var Name=document.getElementById("SsName").value;
             var ID=document.getElementById("SsID").value;
           
            if(Name=="" && ID==""){
               
        var _this=this;
        this.$http.get('http://localhost:61386/api/Shipping/GetInfAll')
        .then(function(res){
            // console.log(res);
            _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        }); 
            }
            else if(Name!="" && ID!=""){
            var Name=document.getElementById("SsName").value;
            var ID=document.getElementById("SsID").value;
            var _this=this;
            this.$http.get('http://localhost:61386/api/Shipping/ChaCustomer_Infs?ID='+ID+"&Name="+Name)
            .then(function(res){
            // console.log(res);
            _this.commodityArr=res.data
            // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });} 
        else if(Name=="" && ID!=""){
                  
        var ID=document.getElementById("SsID").value;
        var _this=this;
        this.$http.get('http://localhost:61386/api/Shipping/ChaCustomer_InfsID?ID='+ID)
        .then(function(res){
            // console.log(res);
           _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });
        }   
        else{
        var Name=document.getElementById("SsName").value;
        var _this=this;
        this.$http.get('http://localhost:61386/api/Shipping/ChaCustomer_InfsName?Name='+Name)
        .then(function(res){
            // console.log(res);
           _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });
        }              
      },
       dele(ID){
                      
        this.$http.get('http://localhost:61386/api/Login/DeleteDatecustomer_inf?ID='+ID)
        .then(function(res){
            // console.log(res);
            console.log(ID)
           alert("删除成功")
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            alert("删除失败")
        }); 
          this.$http.get('http://localhost:61386/api/Login/DeleteDatecustomer_login?ID='+ID)
        .then(function(res){
            // console.log(res);
            
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
           
        }); 
      }
    },
     
}
</script>

<style scoped>
    @import"../../static/css/users.css";
</style>