<template>
    <div id="commodity">
        <!--左侧列表-->
        <div class="list">
            <div class="titleOne">
                <p>商品管理</p>
            </div>
            <ul>
                <li><a href="#"><span>商品列表</span></a></li>
                <li><a href="#"><span>添加商品</span></a></li>
                <li><a href="#"><span>商品审核</span></a></li>
                <li><a href="#"><span>商品回收站</span></a></li>
                <li><a href="#"><span>商品批量修改</span></a></li>
                <li><a href="#"><span>商品评价</span></a></li>
            </ul>
            <div class="titleOne">
                <p>商品配置</p>
            </div>
            <ul>
                <li><a href="#"><span>商品分类</span></a></li>
                <li><a href="#"><span>商品类型</span></a></li>
                <li><a href="#"><span>品牌管理</span></a></li>
                <li><a href="#"><span>图片库管理</span></a></li>
            </ul>
        </div>
        <!--右侧内容-->
        <div class="contentOne">
            <div class="title">
                <div></div><p>&nbsp;商品列表</p>
            </div>
            <div class="whole">
                <div class="ButtonSelect">
                    <button class="btn btn-default" type="submit"><span>全部商品</span><span>(1000)</span></button>
                    <button class="btn btn-default" type="submit"><span>已上架</span><span>(800)</span></button>
                    <button class="btn btn-default" type="submit"><span>未上架</span><span>(100)</span></button>
                    <button class="btn btn-default" type="submit"><span>待审核</span><span>(50)</span></button>
                    <button class="btn btn-default" type="submit"><span>未通过</span><span>(50)</span></button>
                </div>
                <div class="query">
                    <div class="titles">
                        <p class="glyphicon glyphicon-triangle-bottom">筛选查询</p>
                        <button class="btn btn-default" type="submit"   @click="AddShip()"><span>添加</span></button>&nbsp;
                        <button class="btn btn-default" type="submit"   @click="cha()"><span>查询结果</span></button>
                    </div>
                    <div class="search">
                        <div>
                            <span>输入搜索：  </span><input type="text" placeholder="商品名称/商品货号"  id="SsName"/>
                        </div>
                        <div>
                            <span>商品价格：  </span><input type="text" placeholder="商品价格" />
                        </div>
                        <div>
                            <span>商品类型：  </span><input type="text" placeholder="商品类型" />
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
                                <li><a href="#">按价格升序</a></li>
                                <li><a href="#">按价格降序</a></li>
                            </ul>
                        </div>
                    </div>
                    <!--渲染数据-->
                    <div class="form">
                        <div class="top">
                            <div><span>编号</span></div>
                            <div><span>商品图片</span></div>
                            <div><span>商品名称</span></div>
                            <div><span>商品价格</span></div>
                            <div><span>商品类型</span></div>
                            <div><span>商品介绍</span></div>
                            <div><span>促销价格</span></div>
                            <div><span>审核状态</span></div>
                            <div><span>操作</span></div>
                        </div>
                        <!--数据-->
                        <div class="content" v-for="(item,index) in commodityArr">
                            <div><span>{{item.product_id}}</span></div>
                            <div><img :src="item.imgUrl" /></div>
                            <div><span>{{item.ship_name}}</span></div>
                            <div><span>￥{{item.price}}</span></div>
                            <div><span>{{item.modified_time}}</span></div>
                            <div><span>{{item.ship_contact}} </span></div>
                            <div><span>{{item.pricenew}} </span></div>
                            <div><span>{{item.telephone}}</span></div>
                            <!--编辑和删除-->
                            <div>
                                <a href="#"><span @click="open(item.product_id)">编辑</span></a>
                                <a href="#"><span @click="dele(item.product_id)">删除</span></a>
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
            <!--弹窗编辑-->
            <div class="popup" v-show="flag">
                <div class="title">
                    <div></div><p>&nbsp;数据修改</p><span class="glyphicon glyphicon-remove" @click="flag=false"></span>
                </div>
                <div class="modify">
                    <ul>
                        <li>
                            <div>
                                <div><span>商品名称：</span></div>
                                <div><input type="email" class="form-control" id="ShipName" placeholder="商品名称"></div>
                            </div>
                            <div>
                                <div><span>商品编号：</span></div>
                                <div><input type="email" class="form-control" id="ProductId" placeholder="商品编号"></div>
                            </div>
                        </li>
                        <li>
                            <div>
                                <div><span>商品价格：</span></div>
                                <div><input type="email" class="form-control" id="Price" placeholder="商品价格"></div>
                            </div>
                            <div>
                                <div><span>商品类型：</span></div>
                                <div><input type="email" class="form-control" id="ShipStyle" placeholder="商品类型"></div>
                            </div>
                        </li>
                        <li>
                            <div>
                                <div><span>商品介绍：</span></div>
                                <div><input type="email" class="form-control" id="ShipContact" placeholder="商品介绍"></div>
                            </div>
                            <div>
                                <div><span>促销价格：</span></div>
                                <div><input type="email" class="form-control" id="PriceNew" placeholder="促销价格"></div>
                            </div>
                        </li>
                        <li>
                            <div>
                                <div><span>商品照片：</span></div>
                                <div class="form-group">
                                    <input type="file" id="ImgUrl">
                                </div>
                            </div>
                            <div>
                                <div><span>审核状态：</span></div>
                                <div><input type="text" class="form-control" id="Tai" placeholder="审核状态"></div>
                            </div>
                        </li>
                        <li>
                            <div>
                                <button type="submit" class="btn btn-default" id="UpdateShip" @click="flag=false">保存</button>
                            </div>
                            <div>
                                <button type="submit" class="btn btn-default" @click="flag=false">退出</button>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</template>

<script>

export default {
    name: 'Commodity',
    data(){
        return{
            commodityArr:[],
            flag:false,
            kool:"1"
        }
    },
    mounted(){

        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/GetShipping_InfoAll')
        .then(function(res){
            // console.log(res);
            _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });
        

        

    },
   methods: {
  open(ID) {     
            this.flag=true;
          this.kool="1";
          var nook=this.kool;
             sessionStorage.setItem("pan",nook);    
            sessionStorage.setItem("shId",ID);     
      },
      cha(){
           var Name=document.getElementById("SsName").value;
            if(Name==""){
               
        var _this=this;
        this.$http.get('http://localhost:61386/api/Index/GetShipping_InfoAll')
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
        this.$http.get('http://localhost:61386/api/Shipping/ChaShipping_Info?ShipName='+Name)
        .then(function(res){
            // console.log(res);
           _this.commodityArr=res.data
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            console.log(err)
        });}                  
      },
      dele(ID){
                     
        this.$http.get('http://localhost:61386/api/Shipping/DeleteShipping_Info?ID='+ID)
        .then(function(res){
            // console.log(res);
            console.log(ID)
           alert("删除成功")
           // console.log(_this.commodityArr)
        })
        .catch(function(err){
            alert("删除失败")
        }); 
      },
      AddShip(){
        this.kool="0";
          var nook=this.kool;
       sessionStorage.setItem("pan",nook);     
        console.log(this.kool);
        this.flag=true;
     
      }
},
    mounteds:{
        
    }
};
    $(function(){
       $("#UpdateShip").click(function(){
        var name=document.getElementById("ShipName").value;
        var ID=document.getElementById("ProductId").value;
        var Price=document.getElementById("Price").value;
        var Style=document.getElementById("ShipStyle").value;
        var Contact=document.getElementById("ShipContact").value;
        var PriceNew=document.getElementById("PriceNew").value;
        var ImgUrl=document.getElementById("ImgUrl").value;
        var Auti=document.getElementById("Tai").value;
        var shiID=sessionStorage.getItem("shId"); 
         var boold=sessionStorage.getItem("pan");
        
        if(boold=="1")
        {
             if(ID==""){
                    alert("请填写编号")
             }
             else{
            console.log(this.kool)
             $.ajax({
              url: "http://localhost:61386/api/Shipping/UpDateShipping_Info?id="+shiID,
              type: "post",
              data:{
                    ship_name:name,
                    ship_contact:Contact,
                    price:Price,
                    modified_time:Style,
                    pricenew:PriceNew,
                    imgUrl:ImgUrl,
                    telephone:Auti,
                    product_id:ID                  
              }
          }).done(function (data) {
             
             if(data){
               
         alert("修改成功")
       
             }
             else {
                     alert("修改失败")    
             }
         })
         }
         }  
         else{
             if(ID==""){
                    alert("请填写编号")
             }
             else{
              $.ajax({
              url: "http://localhost:61386/api/Shipping/AddShipping_Info",
              type: "post",
              data:{
                    ship_name:name,
                    ship_contact:Contact,
                    price:Price,
                    modified_time:Style,
                    pricenew:PriceNew,
                    imgUrl:ImgUrl,
                    telephone:Auti,
                    product_id:ID                  
              }
          }).done(function (data) {
             
             if(data){
               
         alert("添加成功")
         
             }
             else {
                     alert("添加失败")    
             }
         })
         }
         }        
        
    
       })
       $("#SelectShip").click(function(){
           var Name=document.getElementById("SsName").value;
            var _this=this;
          
            $.ajax({
              url: "http://localhost:61386/api/Login/ChaShipping_Info?ShipName="+Name,
              type: "get",
            
          }).done(function (data) {

              
             if(data){
                _this.commodityArr=data.data
         alert("查询成功")
             }
             else {
                     alert("查询失败")    
             }
         })
       })
    
         
        
    });
</script>

<style scoped>
    @import"../../static/css/commodity.css";
</style>
