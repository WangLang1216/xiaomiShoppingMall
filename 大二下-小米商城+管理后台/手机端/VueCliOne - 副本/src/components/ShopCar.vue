<template>
  <div id="ShopCar">
    <div class="Header">
      <router-link to="/"><div class="glyphicon glyphicon-chevron-left"></div></router-link>
      <div>购物车</div>
      <div class="glyphicon glyphicon-search"></div>
    </div>
    <div class="Main">
      <div class="carList">
        <ol>
          <li>
            <div class="List">
              <div>
                <span></span>
              </div>
              <a href="#">
                <img
                  src="../../static/images/Sphone6.jpg"
                  width="91px"
                  alt=""
                />
              </a>
              <div>
                <div>小米11</div>
                <div>售价：{{ singlePrice }}元</div>
                <div>
                  <div>
                    <span @click="sub()">-</span>
                    <span>{{ goodsNum }}</span>
                    <span @click="add()">+</span>
                  </div>
                  <div class="glyphicon glyphicon-trash"></div>
                </div>
              </div>
            </div>
          </li>
        </ol>
        <div>温馨提示:产品是否购买成功，以最终下单为准，请尽快结算</div>
      </div>
      <div class="recommend">
        <div>
          <img src="../../static/images/bj.jpg" width="100%" alt="" />
        </div>
        <div class="GoodsList">
          <div v-for="(v, index) in Goods">
            <img :src="v.imgUrl" alt="" width="185px" />
            <span>{{ v.name }}</span
            ><br />
            <span>￥{{ v.Price }}</span>
          </div>
        </div>
      </div>
    </div>
    <div class="Footer">
      <div>
        <div>
          <span>共{{ goodsNum }}件 金额：</span><br />
          <strong>{{ totalPrice }}</strong>
          <span>元</span>
        </div>
      </div>
      <router-link to="/productDetails"><a href="#">继续购物</a></router-link>
      <a href="#">去结算</a>
    </div>
  </div>
</template>
<script>
export default {
  name: "ShopCar",
  data() {
    return {
      Goods: [],
      goodsNum: 1,
      totNum: 5,
      singlePrice: 4999,
    };
  },
  methods: {
    add() {
      if (this.goodsNum >= 0 && this.goodsNum < this.totNum) {
        return (this.goodsNum += 1);
      } else {
        alert("购买的数量不能超过" + this.totNum + "喔！");
      }
    },
    sub() {
      if (this.goodsNum <= this.totNum && this.goodsNum >= 1) {
        return (this.goodsNum -= 1);
      } else {
        alert("数量不能少于0喔！");
      }
    },
  },
  computed: {
    totalPrice() {
      return this.singlePrice * this.goodsNum;
    },
  },
  mounted() {
    this.axios
      .get("./static/json/Sphone.json")
      .then((res) => {
        this.Goods = res.data;
      })
      .catch((err) => {
        console.log(err);
      });
  },
};
</script>
<style scoped>
* {
  padding: 0;
  margin: 0;
}
#ShopCar {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  background-color: rgb(255, 255, 255);
}
#ShopCar .Header {
  width: 100%;
  height: 50px;
  background-color: rgb(242, 242, 242);
  display: flex;
  justify-content: space-between;
  align-items: center;
  color: rgb(102, 102, 102);
  font-size: 1.5rem;
  font-weight: normal;
  position: fixed;
}
#ShopCar .Header > div:nth-child(1) {
  height: 100%;
  width: 15%;
  /* background-color: aqua; */
  display: flex;
  justify-content: center;
  align-items: center;
}
#ShopCar .Header > div:nth-child(3) {
  height: 100%;
  width: 15%;
  /* background-color: aqua; */
  display: flex;
  justify-content: center;
  align-items: center;
}
#ShopCar .Footer {
  width: 100%;
  height: 52.8px;
  background-color: rgb(146, 221, 152);
  position: fixed;
  bottom: 0px;
  display: flex;
  justify-content: flex-start;
}
.Footer > div:nth-child(1) {
  flex: 1;
}
.Footer > div:nth-child(1) > div {
  width: 100%;
  height: 100%;
  padding: 10px 0px 0px 22px;
  background-color: rgb(255, 255, 255);
  color: rgb(176, 176, 176);
}
.Footer > div:nth-child(1) > div > strong {
  margin-left: 5px;
  color: rgb(255, 103, 0);
  font-size: 2rem;
}
.Footer > a:nth-child(2) {
  flex: 1;
  display: block;
  cursor: pointer;
  text-align: center;
  line-height: 52.8px;
  background-color: rgb(244, 244, 244);
  text-decoration: none;
  color: rgb(31, 30, 32);
  font-size: 1.625rem;
}
.Footer > a:nth-child(3) {
  flex: 1;
  display: block;
  cursor: pointer;
  text-align: center;
  line-height: 52.8px;
  background-color: rgb(255, 103, 0);
  text-decoration: none;
  color: rgb(255, 255, 255);
  font-size: 1.625rem;
}

.Main {
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  height: 100%;
}
.Main .carList {
  width: 100%;
  height: 166px;
  /* background-color: rgb(171, 199, 199); */
  margin-top: 50px;
}
.carList > ol {
  width: 100%;
  height: 120px;
}
.carList > ol > li {
  width: 100%;
  height: 120px;
}
.carList > ol > li > .List {
  padding: 10px 10px 0px 10px;
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: flex-start;
  /* background-color: rgb(255, 255, 255); */
}
.carList > ol > li > .List > div:first-child {
  /* width: 31px; */
  width: 10%;
  height: 93px;
  /* background-color: aqua; */
  display: flex;
  justify-content: center;
  align-items: center;
  color: black;
}
.carList > ol > li > .List > div:first-child > span {
  width: 20px;
  height: 20px;
  border: 1px solid rgb(190, 187, 187);
  border-radius: 50%;
}
.carList > ol > li > .List > a {
  /* width: 93px; */
  width: 30%;
  height: 93px;
  background-color: rgb(245, 245, 245);
  border: 0.3px solid rgb(216, 215, 215);
  display: flex;
  justify-content: center;
  align-items: center;
}
.carList > ol > li > .List > div:last-child {
  /* width: 240px; */
  width: 60%;
  height: 91px;
  padding-left: 10px;
  /* background-color: blueviolet; */
}
.carList > ol > li > .List > div:last-child > div:nth-child(1) {
  width: 90%;
  height: 33px;
  /* background-color: azure; */
}
.carList > ol > li > .List > div:last-child > div:nth-child(2) {
  width: 100%;
  height: 18px;
  /* background-color: rgb(85, 214, 214); */
  color: rgb(150, 148, 148);
}
.carList > ol > li > .List > div:last-child > div:nth-child(3) {
  width: 95%;
  height: 36px;
  /* background-color: red; */
  margin-top: 7px;
  display: flex;
  justify-content: space-between;
}
.carList
  > ol
  > li
  > .List
  > div:last-child
  > div:nth-child(3)
  > div:last-child {
  font-size: 1.5rem;
  color: rgb(176, 176, 176);
}
.carList
  > ol
  > li
  > .List
  > div:last-child
  > div:nth-child(3)
  > div:first-child {
  width: 100px;
  height: 33px;
  /* background-color: blanchedalmond; */
  display: flex;
  justify-content: flex-start;
  align-items: center;
  border: 1px solid rgb(223, 220, 220);
}
.carList
  > ol
  > li
  > .List
  > div:last-child
  > div:nth-child(3)
  > div:first-child
  > span {
  flex: 1;
  background-color: rgb(244, 244, 244);
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.carList
  > ol
  > li
  > .List
  > div:last-child
  > div:nth-child(3)
  > div:first-child
  > span:nth-child(2) {
  background-color: rgb(255, 255, 255);
}
.carList > div:nth-child(2) {
  height: 30px;
  background-color: rgb(244, 244, 244);
  font-size: 12px;
  color: rgb(176, 176, 176);
  display: flex;
  justify-content: center;
  align-items: center;
}

.Main .recommend {
  width: 100%;
  height: 100%;
  /* background-color: red; */
}
.GoodsList {
  width: 100%;
  height: 100%;
  display: flex;
  margin-bottom: 50px;
  justify-content: space-between;
  flex-wrap: wrap;
}
.GoodsList > div {
  width: 170px;
  height: 200px;
  margin: 5px 5px 5px 0px;
  text-align: center;
}
.GoodsList > div > span:nth-of-type(2) {
  color: rgb(255, 103, 0);
  /* margin-left: 20px; */
}
</style>