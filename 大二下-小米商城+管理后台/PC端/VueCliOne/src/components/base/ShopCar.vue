<template>
  <div id="ShopCar">
    <div id="Header">
      <div class="logo">
        <router-link to="/index"><a href="#"
          ><img src="static/images/ShopCar/20.png" width="48px" alt=""
        /></a></router-link>
      </div>
      <div class="title">
        <h2>我的购物车</h2>
        <p>温馨提示：产品是否购买成功，以最终下单为准哦，请尽快结算</p>
      </div>
      <div class="user">
        <div class="listFather">
          <router-link to="/my"><a href="#" @mouseover="showUser()" @mouseleave="hideUser()">我的</a></router-link>
          <!-- <i class="icon"></i> -->
          <div
            class="listBox"
            :class="{ showList: flag }"
            @mouseover="showUser()"
            @mouseleave="hideUser()"
          >
            <ul>
              <li><a href="#">个人中心</a></li>
              <li><a href="#">评价晒单</a></li>
              <li><a href="#">我的喜欢</a></li>
              <li><a href="#">小米账户</a></li>
              <li><a href="#">退出登录</a></li>
            </ul>
          </div>
        </div>
        <span>|</span>
        <a href="#">我的订单</a>
      </div>
    </div>
    <div id="Container">
      <div class="ContianerSon">
        <div class="mianOne">
          <div class="listHead">
            <div>
              <input type="checkbox" name="" id="" />
              &nbsp; 全选
            </div>
            <div>商品名称</div>
            <div>单价</div>
            <div>数量</div>
            <div>小计</div>
            <div>操作</div>
          </div>
          <div class="listBody">
            <div class="itemBox">
              <div class="itemTable">
                <div>
                  <input type="checkbox" name="" id="" />
                </div>
                <div>
                  <a href="#">
                    <img
                      src="/static/images/ShopCar/0.png"
                      alt="黑鲨手机"
                      width="80px"
                    />
                  </a>
                </div>
                <div>Redmi K40 游戏增强版 12GB+256GB 暗影</div>
                <div>
                  <span>{{ GoodsPrice }}</span>
                </div>
                <div class="CgNum">
                  <div>
                    <span>
                      <a href="#">
                        <img
                          @click="subGoods()"
                          src="/static/images/ShopCar/jianhao.png"
                          alt=""
                        />
                      </a>
                    </span>
                    <span>
                      {{ GoodsNum }}
                    </span>
                    <span>
                      <a href="#">
                        <img
                          @click="addGoods()"
                          src="/static/images/ShopCar/jiahao.png"
                          alt=""
                        />
                      </a>
                    </span>
                  </div>
                </div>
                <div>
                  <span>{{ singleGoodsPrice }}元</span>
                </div>
                <div>
                  <span>
                    <a href="#">×</a>
                  </span>
                </div>
              </div>
            </div>
          </div>
          <div class="mianThree"></div>
          <div class="mianFour">
            <div class="sectionLeft">
              <a href="#">继续购物</a>
              <div>
                共<span>{{ TotalGoods }}</span
                >件商品&nbsp;,已选择<span>{{ GoodsNum }}</span
                >件
              </div>
            </div>
            <div class="sectionRight" >
              <span>合计:{{ TotalPrice }}元</span>
              <div>
                <div class="tips">
                  <div>请勾选需要结算的商品</div>
                 
                  <a href="#" >去结算</a>
                 
                </div>
              </div>
            </div>
          </div>

          <!-- <div class="empty">
            <img src="/static/images/27.png" alt="空购物车" />
            <h1>你的购物车还是空的！</h1>
            <a href="#">马上购物</a>
          </div> -->
        </div>

        <!-- <div class="space">&nbsp;</div> -->
        <div class="mianTwo">
          <div class="tipsTwo">
            <span>买购物车中商品的人还买了</span>
          </div>
          <br />
          <div class="goodsBox">
            <ul class="goodsList">
              <li v-for="(v, index) in MathGrop">
                <img :src="v.imgName" alt="" />
                <span>{{ v.goodsName }}</span>
                <a href="#">{{ v.price }}</a>
                <span>{{ v.assets }}</span>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <!-- <div class="spaceFoot">&nbsp;</div> -->
      <!-- <Footer></Footer> -->
    </div>
  </div>
</template>

<script>
import Footer from "./Footer.vue";
export default {
  name: "ShopCar",
  data() {
    return {
      MathGrop: [],
      flag: true,
      GoodsNum: 1,
      GoodsPrice: 100,
      TotalGoods: 5,
    };
  },
  methods: {
    
    showUser() {
      this.flag = false;
    },
    hideUser() {
      this.flag = true;
    },
    addGoods() {
      if (this.GoodsNum < this.TotalGoods) {
        this.GoodsNum += 1;
      } else {
        alert("商品已超出购买限制");
      }
    },
    subGoods() {
      if (this.GoodsNum <= this.TotalGoods && this.GoodsNum >= 1) {
        this.GoodsNum -= 1;
      } else {
        alert("修改数量不能小于0");
      }
    },
  },
  computed: {
    TotalPrice() {
      return this.GoodsNum * this.GoodsPrice;
    },
    singleGoodsPrice() {
      return this.GoodsNum * this.GoodsPrice;
    },
  },
  components: {
    Footer,
  },
  mounted() {
    this.axios
      .get("./static/rec.json")
      .then((res) => {
        this.MathGrop = res.data;s
        console.log(res);
      })
      .catch(function (err) {
        console.log(err);
      });
  },
};
$(function(){
  $("#Buy").click(function(){
   

  })
})

</script>


<style scoped>
* {
  padding: 0px;
  margin: 0px;
}
body {
  font: 14px/1.5 Helvetica Neue, Helvetica, Arial, Microsoft Yahei,
    Hiragino Sans GB, Heiti SC, WenQuanYi Micro Hei, sans-serif;
  color: #333;
  color: rgb(245, 245, 245);
  min-width: 1226px;
}
html {
  overflow-x: hidden;
  overflow-y: auto;
}
#ShopCar {
  width: 100%;
  /* height: 1200px; */
  display: flex;
  justify-content: center;
  flex-direction: row;
  flex-wrap: wrap;
  align-content: start;
}

#Header {
  font-size: 12px;
  border-bottom: 2px solid #ff6700;
  background: #fff;
  color: #b0b0b0;
  z-index: 20;
  height: 100px;
  width: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
}
#Header > div:nth-child(1) {
  flex: 1;
  width: 93px;
  height: 100%;
  /* background-color: #77543d; */
}
#Header > div:nth-child(2) {
  flex: 6;
  width: 491px;
  height: 100%;
  /* background-color: antiquewhite; */
}
#Header > div:nth-child(3) {
  flex: 2;
  width: 193px;
  height: 100%;
  /* background-color: aqua; */
  margin-left: 100px;
}
.logo {
  display: flex;
  justify-content: center;
  align-items: center;
  margin-left: 20px;
}
.title {
  display: flex;
  justify-content: flex-start;
  align-items: center;
  padding-left: 20px;
  /* overflow: hidden; */
  text-overflow: ellipsis;
  white-space: nowrap;
  flex: 2;
}
.title h2 {
  font-size: 28px;
  font-weight: 400;
  color: rgb(42, 42, 42);
}
.title p {
  color: #757575;
  margin-left: 10px;
  margin-top: 6px;
}
.user {
  display: flex;
  justify-content: space-around;
  align-items: center;
  white-space: nowrap;
  text-overflow: ellipsis;
  padding-right: 30px;
}
.user a {
  text-decoration: none;
  color: #757575;
}
.user > a:hover {
  color: rgb(255, 103, 132);
}
.icon::before {
  content: "\E61C";
}
.listFather {
  margin-top: 107.6px;
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  z-index: 3;
  width: 100px;
  height: 207.6px;
  /* border: 1px solid springgreen; */
  border-radius: 3px;
}
.listFather > a {
  display: block;
  width: 100%;
  height: 27.6px;
  /* background-color: rgb(117, 117, 117); */
  display: flex;
  justify-content: center;
  margin-top: 42px;
}

.listFather a:hover {
  color: rgb(255, 103, 132);
}
.listBox {
  flex: 1;
  background-color: #fff;
  z-index: 3;
  height: 0;
  /* overflow: hidden; */
}
.listBox > ul {
  box-shadow: 2px 2px 10px;
  transition: 0.2s;
  list-style: none;
  width: 100%;
  height: 138px;
  position: relative;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  border-radius: 3px;
}
.listBox > ul > li {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.listBox > ul > li :hover {
  transition: 0.3s;
  background-color: rgb(245, 245, 245);
}
.listBox > ul > li > a {
  display: block;
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.showList {
  display: none;
}

#Container {
  flex: 3;
  background-color: rgb(245, 245, 245);
  padding: 38px 0px;
  width: 100%;
  /* height: 1700px; */
}
#Container .ContianerSon {
  width: 100%;
  height: 1086px;
  background-color: rgb(255, 255, 255);
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: center;
  /* border: 1px solid red; */
}
.ContianerSon .mianOne {
  width: 100%;
  height: 257px;
  padding: 20px 20px 0px 20px;
  /* background-color: rgb(124, 93, 98); */
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
}
.space {
  width: 100%;
  height: 40px;
  background-color: rgb(245, 245, 245);
}
.listHead {
  display: flex;
  justify-content: flex-start;
  align-items: center;
  width: 100%;
  padding-bottom: 10px;
  border-bottom: 1px solid rgb(222, 222, 222);
  height: 70px;
  /* background-color: aqua; */
}

.listHead > div:nth-child(1) {
  height: 70px;
  width: 110px;
  display: flex;
  /* background-color: firebrick; */
  justify-content: center;
  align-items: center;
}
.listHead > div:nth-child(2) {
  width: 380px;
  height: 70px;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: rgb(139, 36, 153); */
  margin-left: 120px;
}
.listHead > div:nth-child(3) {
  width: 158px;
  height: 70px;
  display: flex;
  padding-right: 18px;
  justify-content: center;
  align-items: center;
  /* background-color: rgb(177, 209, 36); */
}
.listHead > div:nth-child(4) {
  width: 150px;
  height: 70px;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: rgb(80, 88, 40); */
}
.listHead > div:nth-child(5) {
  width: 201px;
  height: 70px;
  padding-right: 81px;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: rgb(20, 63, 38); */
}
.listHead > div:nth-child(6) {
  width: 80px;
  height: 70px;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: rgb(67, 126, 92); */
}

.listBody {
  display: flex;
  justify-content: flex-start;
  align-items: center;
  width: 100%;
  height: 117px;
  /* background-color: rgb(198, 218, 25); */
}

.itemBox {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  padding: 15px 0px 15px 0px;
  /* background-color: rgb(139, 107, 107); */
}
.itemBox .itemTable {
  width: 100%;
  height: 86px;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: rgb(131, 189, 170); */
}

.itemTable div:nth-child(1) {
  width: 110px;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: #a750aa; */
}
.itemTable div:nth-child(1) input {
  margin-left: 24px;
}

.itemTable div:nth-child(2) {
  width: 120px;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: #cdb6ce; */
}

.itemTable div:nth-child(3) {
  width: 380px;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: #b3c7aa; */
}

.itemTable div:nth-child(4) {
  width: 158px;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: #4e6d40; */
}

/* ---------------------------表单问题------------------------------------ */
.itemTable .CgNum {
  width: 150px;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: #325155; */
}
.itemTable .CgNum > div {
  display: flex;
  justify-content: space-between;
  /* background-color: #ff6700; */
  border: 1px solid rgb(225, 225, 225);
  width: 150px;
  height: 40px;
}
.itemTable .CgNum > div a {
  /* background-color: #757575; */
  border: 0;
  outline: none;
  text-decoration: none;
  height: 38px;
  width: 38px;
  font-size: 30px;
}
.itemTable .CgNum > div a img {
  margin-left: 7px;
}
.itemTable .CgNum > div a:hover {
  background-color: rgb(222, 222, 222);
}
.itemTable .CgNum > div > span:nth-child(1),
.itemTable .CgNum > div span:nth-child(3) {
  /* text-decoration: none; */
  /* font-size: 18px; */
  width: 38px;
  height: 100%;
  flex: 1;
  /* background-color: #c9b6c9; */
  display: flex;
  justify-content: center;
  align-items: center;
}

.itemTable .CgNum > div > span:nth-child(2) {
  display: flex;
  width: 100%;
  height: 38px;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: #107e81; */
}

.empty {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: rgb(245, 245, 245);
}
.empty h1 {
  font-size: 36px;
  color: rgb(176, 176, 176);
}
.empty a {
  text-decoration: none;
  display: block;
  width: 160px;
  height: 40px;
  background-color: rgb(255, 103, 0);
  text-align: center;
  line-height: 40px;
  color: white;
}
.empty a:hover {
  background-color: rgb(242, 88, 7);
  box-shadow: inset 1px 1px 5px grey;
}
.empty img {
  height: 200px;
}
.ContianerSon .mianTwo {
  width: 100%;
  height: 800px;
  /* border-top: 2px solid rgb(245, 245, 245); */
  /* background-color: beige; */
}
/* ---------------------------表单问题------------------------------------ */
.itemTable div:nth-child(6) {
  width: 180px;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  /* background-color: #7cf842; */
  color: rgb(255, 103, 0);
}
.itemTable div:nth-child(6) > span {
  margin-left: 59px;
}
.itemTable div:nth-child(7) {
  /* margin-left: 10px; */
  width: 175px; /*125px */
  height: 100%;
  display: flex;
  justify-content: flex-end;
  align-items: center;
  /* background-color: #ca3958; */
}
.itemTable div:nth-child(7) > span {
  margin-right: 20px;
  display: block;
  width: 24px;
  height: 24px;
  text-decoration: none;
  color: rgb(245, 245, 245);
  border-radius: 12px;
  /* border: 1px solid rebeccapurple; */
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #f5f3f3;
}
.itemTable div:nth-child(7) > span:hover {
  z-index: 3;
  background-color: rgb(224, 63, 22);
}
.itemTable div:nth-child(7) > span > a {
  cursor: pointer;
  /* padding-bottom: 6px; */
  padding-top: 4px;
  text-align: center;
  width: 100%;
  height: 100%;
  text-decoration: none;
  z-index: 3;
  color: black;
}
.itemTable div:nth-child(7) > span > a:hover {
  color: #fff;
}

.mianThree {
  width: 100%;
  height: 80px;
  background-color: rgb(245, 245, 245);
}
.mianFour {
  /* border-bottom: 1px solid rgb(245, 245, 245); */
  width: 100%;
  height: 50px;
  line-height: 50px;
  /* margin-top: 10px; */
  /* padding-top: 10px; */
  /* background-color: #aba5c4; */
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.sectionLeft {
  width: 274.25px;
  height: 100%;
  /* background-color: #06f040; */
  display: flex;
  justify-content: space-around;
  align-items: center;
  color: rgb(117, 117, 117);
}
.sectionLeft > div {
  width: 274.25px;
  height: 100%;
  /* background-color: #06f040; */
  display: flex;
  justify-content: space-around;
  align-items: center;
  color: rgb(117, 117, 117);
}
.sectionLeft > div > span {
  color: rgb(255, 103, 0);
}
.sectionLeft > a {
  display: block;
  width: 100px;
  height: 100%;
  text-decoration: none;
  color: rgb(117, 117, 117);
}
.sectionLeft > a:hover {
  color: rgb(255, 103, 0);
  transition: 0.3s;
}
.sectionRight {
  width: 338px;
  height: 100%;
  /* background-color: #81577a; */
  display: flex;
  justify-content: flex-start;
  align-items: center;
}
.sectionRight > span {
  width: 130px;
  height: 100%;
  /* background-color: #7b9481; */
  display: flex;
  font-size: 16px;
  color: rgb(255, 103, 0);
  justify-content: center;
  align-items: center;
}
.sectionRight > div {
  width: 100%;
  height: 170px;
  /* background-color: #34a34e; */
  padding-bottom: 55px;
  display: flex;
  justify-content: center;
  align-items: center;
}
.tips {
  width: 100%;
  height: 100px;
  /* background-color: #a750aa; */
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}
.tips > div {
  border: 1px solid orange;
  width: 100%;
  /* height: 80%; */
  height: 40px;
  margin-top: 10px;
  color: orange;
  /* background-color: #095e4b; */
  display: flex;
  justify-content: center;
  align-items: center;
}
.tips > a {
  display: block;
  background-color: rgb(224, 224, 224);
  height: 100%;
  width: 100%;
  padding-bottom: 12px;
  flex: 1;
  text-decoration: none;
  /* font-size: 28px; */
  color: rgb(117, 117, 117);
  text-align: center;
  font-size: 18px;
}
.tips > a:hover {
  box-shadow: inset 1px 1px 10px grey;
  transition: 0.5s;
}

.tipsTwo {
  margin: 30px 0 30px 0;
  width: 100%;
  height: 40px;
  font-weight: 400;
  color: rgb(117, 117, 117);
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 30px;
  /* background-color: #be4bab; */
}

.goodsBox {
  width: 100%;
  height: 612px;
  display: flex;
  justify-content: center;
  overflow: hidden;
}
.goodsList {
  /* width: 100%; */
  width: 1226px;
  height: 600px;
  overflow: hidden;
  /* background-color: #06f040; */
  /* overflow: hidden; */
  display: flex;
  flex-wrap: wrap;
  flex-direction: row;
  justify-content: space-between;
  align-content: flex-start;
  background-color: rgb(245, 245, 245);
}
.goodsList > li {
  width: 234px;
  height: 300px;
  /* height: 48%; */
  margin: 4px;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  background-color: rgb(255, 255, 255);
}
.goodsList > li > a {
  text-decoration: none;
  color: orange;
}
.goodsList > li > a + span {
  color: rgb(117, 117, 117);
}
.goodsList > li:hover {
  box-shadow: 0.5px 0.5px 10px rgb(245, 245, 245);
  transition: 0.5s;
  background-color: rgb(235, 235, 235);
}
.goodsList li > img {
  height: 150px;
  width: 120px;
}
.spaceFoot {
  width: 100%;
  height: 40px;
  background-color: rgb(245, 245, 245);
}
#Footer {
  /* background-color: red; */
  height: 400px;
  width: 100%;
  background-color: rgb(255, 255, 255);
}
</style>