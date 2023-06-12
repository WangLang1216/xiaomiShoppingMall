<template>
  <div id="Goods">
    <div class="Header">
      <div class="NavOne">
        <ul>
          <li v-for="(v, index) in productGrop">
            <a href="#"> {{ v.nameOne }}</a>
            <span>|</span>
          </li>
        </ul>
        <div>
          <div class="person">
            <dl>
              <dt>
                <a href="#" @mouseover="show()" @mouseout="hide()">Gain</a>
              </dt>
              <dd v-show="flag" @mouseover="show()" @mouseout="hide()">
                <a href="#">个人中心</a>
                <a href="#">个人中心</a>
                <a href="#">个人中心</a>
                <a href="#">个人中心</a>
                <a href="#">个人中心</a>
              </dd>
            </dl>
          </div>
          <div>
            <span>|</span>
            <a href="#">消息通知</a>
            <span>|</span>
          </div>
          <div><a href="#">我的订单</a><span>|</span></div>
          <div>
            <a href="">购物车</a>
          </div>
        </div>
      </div>
      <div class="NavTwo">
        <div>
          <a href="#">
            <img src="/static/images/Goods/logo-mi21.png" width="56px" alt="" />
          </a>
        </div>
        <div>
          <a href="#">全部商品分类</a>
        </div>
        <div>
          <a href="#" @mouseover="showList()" @mouseout="hideList()"
            >小米手机</a
          >
        </div>
        <div>
          <a href="#">Redmi红米</a>
        </div>
        <div>
          <a href="#">电视</a>
        </div>
        <div>
          <a href="#">笔记本</a>
        </div>
        <div>
          <a href="#">家电</a>
        </div>
        <div>
          <a href="#">路由器</a>
        </div>
        <div>
          <a href="#">智能硬件</a>
        </div>
        <div>
          <a href="#">服务</a>
        </div>
        <div>
          <a href="#">社区</a>
        </div>
        <div class="search">
          <input type="text" placeholder="请输入关键词" />
          <button class="glyphicon glyphicon-search"></button>
        </div>
      </div>
      <div class="searchList">
        <!--  -->
        <div>
          <ul v-show="showFlag" @mouseover="showList()" @mouseout="hideList()">
            <li v-for="(v, index) in GoodsList">
              <a href="#">
                <img :src="v.imgUrl" width="55%" alt="" />
                <span>{{ v.name }}</span>
                <span>{{ v.price }}</span>
              </a>
            </li>
          </ul>
        </div>
      </div>
    </div>
    <div class="Main">
      <div>
        <div>
          <img src="/static/images/Goods/plus.png" width="500px" alt="" />
        </div>
        <div>
          <div>
            <h3>Redmi K40 游戏增强版</h3>
            <br />
            <p>
              <span
                >「6月16日
                12GB+128GB闪降100元；12GB+256GB闪降200元（不含李小龙版）」</span
              >
              天玑1200年度旗舰处理器｜弹出式肩键｜航天立体散热｜JBL立体声双扬声器｜64MP旗舰三摄
            </p>
            <br />
            <span>小米自营</span><br />
            <span>2699元</span><br />
            <div>
              <span class="glyphicon glyphicon-map-marker"></span>
              四川&nbsp;宜宾市&nbsp;长宁县&nbsp;双河镇&nbsp;
              <a href="#">修改</a><br />
              <span>有现货</span>
            </div>
          </div>
          <div>
            <h5>选择版本</h5>
            <div class="phoneSize">
              <span><a href="#">12G+256G</a></span>
              <span><a href="#">12G+128G</a></span>
              <span><a href="#">8G+256G</a></span>
              <span><a href="#">8G+128G</a></span>
              <span><a href="#">6G+128G</a></span>
            </div>
            <h5>选择颜色</h5>
            <div class="phoneType">
              <span><a href="#">暗影</a></span>
              <span><a href="#">光刃</a></span>
              <span><a href="#">银翼</a></span>
              <span><a href="#">李小龙特别版</a></span>
            </div>
          </div>
          <div>
            <div>
              <div>
                <span>Redmi K40 游戏增强版 12GB+256GB 暗影</span>
                <span>2699元</span>
              </div>
              <span>总计：2699元</span>
            </div>
            <div>
              <span><a href="#">加入购物车</a></span>
              <span><a href="#">喜欢</a></span>
            </div>
            <div>
              <span class="glyphicon glyphicon-ok-circle">小米自营</span>
              <span class="glyphicon glyphicon-ok-circle">小米发货</span>
              <span class="glyphicon glyphicon-ok-circle">7天无理由退货</span>
              <span class="glyphicon glyphicon-ok-circle">运费说明</span>
              <span class="glyphicon glyphicon-ok-circle">企业信息</span>
              <span class="glyphicon glyphicon-ok-circle">7天价格保护</span>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="prompt">
      <h4>价格说明</h4>
      <img src="/static/images/Goods/prompt.jpeg"/>
    </div>
    <div class="Footer"></div>
    <!-- <Footer></Footer> -->
  </div>
</template>
<script>
import Footer from "./Footer.vue";
export default {
  name: "Goods",
  components: {
    Footer,
  },
  data() {
    return {
      productGrop: [],
      GoodsList: [],
      flag: false,
      bgcFlag: true,
      showFlag: false,
    };
  },
  methods: {
    show() {
      this.flag = true;
    },
    hide() {
      this.flag = false;
    },
    showList() {
      this.showFlag = true;
    },
    hideList() {
      this.showFlag = false;
    },
  },
  mounted() {
    this.axios
      .get("./static/goods.json")
      .then((res) => {
        this.productGrop = res.data;
      })
      .catch((err) => {
        console.log(err);
      });
    this.axios
      .get("./static/goodsList.json")
      .then((res) => {
        this.GoodsList = res.data;
      })
      .catch((err) => {
        console.log(err);
      });
  },
};
</script>


<style scoped>
* {
  list-style: none;
  padding: 0;
  margin: 0;
}
.hide {
  overflow: visible;
}
.Goods {
  height: 100%;
}
.Header {
  width: 100%;
  height: 300px;
  /* background-color: bisque; */
  display: flex;
  flex-direction: column;
}
.Header .NavOne {
  width: 100%;
  height: 40px;
  /* background-color: aqua; */
  background-color: rgb(51, 51, 51);
  display: flex;
  justify-content: flex-start;
  align-items: center;
  z-index: 2;
}
.Header .NavOne > ul {
  flex: 2;
  display: flex;
  height: 40px;
  width: 100%;
  align-items: center;
  margin-left: 20px;
}
.Header .NavOne > ul > li {
  line-height: 40px;
  height: 100%;
  cursor: pointer;
  font-size: 12px;
  display: flex;
  flex-wrap: nowrap;
  margin-left: 7px;
  white-space: nowrap;
}
.Header .NavOne > ul > li > a:hover {
  color: rgb(255, 255, 255);
}
.Header .NavOne > ul > li > span {
  margin-left: 5px;
  color: rgb(66, 66, 66);
}
.Header .NavOne > ul > li > a {
  width: 100%;
  height: 100%;
  display: block;
  text-decoration: none;
  color: rgb(176, 176, 176);
}
.Header .NavOne > ul + div {
  width: 100%;
  height: 100%;
  /* background-color: antiquewhite; */
  flex: 1;
  display: flex;
  justify-content: space-between;
}
/* ___________________________________________________________________ */
.bgc {
  background-color: rgb(255, 255, 255);
}
.person {
  flex: 1;
}
.person dl {
  justify-content: flex-start;
  align-items: center;
}

.person dl dt {
  width: 100%;
  height: 40px;
}
.person dl dt a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  font-size: 12px;
  color: rgb(176, 176, 176);
  background-color: rgb(51, 51, 51);
}
.person dl dt a:hover {
  /* background-color: rgb(255, 255, 255); */
  color: rgb(255, 103, 0);
}
.person dl dd {
  height: 180px;
  background-color: rgb(255, 255, 255);
  z-index: 2;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
  box-shadow: 2px 10px 10px rgb(117, 117, 117);
}
.person dl dd > a {
  height: 100%;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  color: rgb(51, 51, 51);
  font-size: 12px;
}
.person dl dd > a:hover {
  background-color: rgb(245, 245, 245);
  color: rgb(255, 103, 0);
  transition: 0.2s;
}
/* ____________________________________________________________________ */
.Header .NavOne > ul + div > div:nth-child(2) {
  display: flex;
  align-items: center;
  justify-content: space-around;
  flex: 1;
  width: 100%;
  height: inherit;
  background-color: rgb(51, 51, 51);
}
.Header .NavOne > ul + div > div:nth-child(2) > a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  color: rgb(176, 176, 176);
  font-size: 12px;
}
.Header .NavOne > ul + div > div:nth-child(2) > a:hover {
  color: rgb(255, 255, 255);
}
.Header .NavOne > ul + div > div:nth-child(2) > span {
  color: rgb(66, 66, 66);
}
.Header .NavOne > ul + div > div:nth-child(3) {
  display: flex;
  align-items: center;
  justify-content: space-around;
  flex: 1;
  width: 100%;
  height: inherit;
  background-color: rgb(51, 51, 51);
}
.Header .NavOne > ul + div > div:nth-child(3) > a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 12px;
  text-decoration: none;
  color: rgb(176, 176, 176);
}
.Header .NavOne > ul + div > div:nth-child(3) > a:hover {
  color: rgb(255, 255, 255);
}
.Header .NavOne > ul + div > div:nth-child(3) > span {
  color: rgb(66, 66, 66);
}

.Header .NavOne > ul + div > div:nth-child(4) {
  display: flex;
  align-items: center;
  justify-content: center;
  flex: 1;
  width: 100%;
  height: inherit;
  background-color: rgb(255, 103, 0);
  overflow: hidden;
}
.Header .NavOne > ul + div > div:nth-child(4) :hover {
  background-color: rgb(255, 255, 255);
}
.Header .NavOne > ul + div > div:nth-child(4) > a {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
  height: 100%;
  text-decoration: none;
  color: rgb(66, 66, 66);
  font-size: 12px;
}
.Header .NavOne > ul + div > div:nth-child(4) > a:hover {
  color: rgb(255, 103, 0);
}
.Header .NavTwo {
  width: 100%;
  height: 100px;
  /* background-color: blueviolet; */
  display: flex;
  justify-content: space-between;
  align-items: center;
  border-bottom: 1px solid rgb(224, 224, 224);
}

.Header .NavTwo > div {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100%;
  height: 100%;
  /* background-color: rgb(48, 119, 119); */
  flex: 1;
  white-space: nowrap;
}
.Header .NavTwo > div a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  color: rgb(51, 51, 51);
  z-index: 1;
}

.Header .NavTwo > div a:hover {
  color: rgb(255, 103, 0);
  transition: 0.3s;
}
.Header .NavTwo > div:nth-child(1) {
  /* background-color: rgb(148, 89, 89); */
  flex: 2;
}

.Header .NavTwo > div:nth-child(12) {
  /* background-color: rgb(79, 230, 66); */
  flex: 3;
}

.search > input {
  border: 0;
  width: 180px;
  height: 40px;
  outline: 0.5px solid rgb(176, 176, 176);
}

.search > input + button {
  width: 40px;
  height: 40px;
  border: 0;
  margin-bottom: 2px;
  outline: 0.5px solid rgb(176, 176, 176);
}
.search > input + button:hover {
  background-color: rgb(255, 103, 0);
  color: rgb(255, 255, 255);
  transition: 0.4s;
}
.searchList {
  width: 100%;
  height: 130px;
  /* background-color: antiquewhite; */
  /* box-shadow: 1px 3px 3px rgb(176, 176, 176); */
}
.searchList div:nth-child(1) {
  height: 100%;
  /* display: none; */
}
.searchList div:nth-child(1) ul {
  height: 100%;
  width: 100%;
  box-shadow: 1px 5px 5px rgb(176, 176, 176);
  display: flex;
  justify-content: space-around;
  align-items: center;
}
.searchList div:nth-child(1) ul > li {
  width: 100%;
  height: 100%;
}
.searchList div:nth-child(1) ul > li > a {
  cursor: pointer;
  height: 100%;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-around;
  /* background-color: aquamarine; */
  text-decoration: none;
  color: rgb(66, 66, 66);
}
.searchList div:nth-child(1) ul > li > a span:nth-child(3) {
  color: rgb(255, 103, 0);
}

/* 主体开始 */
.Main {
  width: 100%;
  height: 900px;
  /* background-color: rgb(200, 188, 206); */
}
.Main > div {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: row;
}
.Main > div > div:nth-child(1) {
  flex: 1;
  /* background-color: rgb(216, 172, 119); */
}
.Main > div > div:nth-child(2) {
  flex: 1;
  /* background-color: rgb(119, 216, 156); */
  display: flex;
  flex-direction: column;
  font-size: 12px;
}
.Main > div > div:nth-child(2) > div:nth-child(1) {
  padding-top: 20px;
  width: 100%;
  height: 100%;
  flex: 1;
  display: flex;
  /* background-color: rgb(79, 80, 158); */
  flex-direction: column;
}
.Main > div > div:nth-child(2) > div:nth-child(1) p {
  color: rgb(176, 176, 176);
}
.Main > div > div:nth-child(2) > div:nth-child(1) span {
  color: rgb(255, 103, 0);
}
.Main > div > div:nth-child(2) > div:nth-child(1) > div {
  background-color: rgb(250, 250, 250);
  width: 100%;
  height: 100px;
  margin-top: 20px;
  padding: 30px;
}
.Main > div > div:nth-child(2) > div:nth-child(1) > div > a {
  color: rgb(255, 103, 0);
  text-decoration: none;
}
.Main > div > div:nth-child(2) > div:nth-child(2) {
  width: 100%;
  height: 100%;
  flex: 1;
  display: flex;
  flex-direction: column;
  /* background-color: rgb(132, 134, 212); */
}
.Main > div > div:nth-child(2) > div:nth-child(2) .phoneSize {
  width: 100%;
  height: 160px;
  /* background-color: rgb(216, 172, 119); */
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  align-items: center;
}
.Main > div > div:nth-child(2) > div:nth-child(2) .phoneSize > span {
  width: 40%;
  height: 23%;

  /* flex: 1; */
}
.phoneSize span:nth-child(1) a {
  border: 1px solid rgb(255, 103, 0);
  color: rgb(255, 103, 0);
}
.phoneSize span a {
  width: 100%;
  height: 100%;
  /* background-color: aqua; */
  border: 1px solid rgb(176, 176, 176);
  display: flex;
  justify-content: center;
  align-items: center;
  color: rgb(66, 66, 66);
  text-decoration: none;
}
.phoneSize span a:hover {
  color: rgb(255, 103, 0);
  border: 1px solid rgb(255, 103, 0);
}
.phoneType {
  margin-top: 10px;
  width: 100%;
  height: 80px;
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  justify-content: space-between;
}
.phoneType span {
  width: 230px;
  height: 36.8px;
}
.phoneType a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  text-decoration: none;
  color: rgb(66, 66, 66);
  border: 1px solid rgb(176, 176, 176);
}
.phoneType span:nth-child(1) a {
  color: rgb(255, 103, 0);
  border: 1px solid rgb(255, 103, 0);
}
.phoneType a:hover {
  color: rgb(255, 103, 0);
  border: 1px solid rgb(255, 103, 0);
}
.Main > div > div:nth-child(2) > div:nth-child(3) {
  width: 100%;
  height: 100%;
  flex: 1;
  display: flex;
  flex-direction: column;
}
.Main > div > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) {
  flex: 1.5;
  background-color: rgb(249, 249, 250);
}
.Main > div > div:nth-child(2) > div:nth-child(3) div:nth-child(1) > div {
  width: 100%;
  height: 50%;
  /* background-color: aqua; */
  display: flex;
  justify-content: space-around;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(1)
  > div
  > span {
  padding-top: 20px;
  /* background-color: aquamarine; */
  color: rgb(51, 51, 51);
}
.Main > div > div:nth-child(2) > div:nth-child(3) div:nth-child(1) + span {
  padding-left: 76px;
  color: rgb(255, 103, 0);
  font-size: 18px;
}
.Main > div > div:nth-child(2) > div:nth-child(3) div:nth-child(2) {
  flex: 1;
  display: flex;
  justify-content: flex-start;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(1) {
  width: 250px;
  height: 45px;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(1)
  > a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-top: 20px;
  text-decoration: none;
  color: rgb(255, 255, 255);
  background-color: rgb(255, 103, 0);
  font-size: 14px;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(1)
  > a:hover {
  background-color: rgb(242, 88, 7);
  transition: 0.5s;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(2) {
  width: 120px;
  height: 45px;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(2)
  > a {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  /* background-color: blueviolet; */
  margin-top: 20px;
  text-decoration: none;
  color: rgb(255, 255, 255);
  background-color: rgb(176, 176, 176);
  margin-left: 10px;
  font-size: 14px;
}
.Main
  > div
  > div:nth-child(2)
  > div:nth-child(3)
  div:nth-child(2)
  > span:nth-child(2)
  > a:hover {
  background-color: rgb(117, 117, 117);
  transition: 0.5s;
}

.Main > div > div:nth-child(2) > div:nth-child(3) div:nth-child(3) {
  flex: 1;
  /* background-color: rgb(77, 114, 114); */
  display: flex;
  justify-content: flex-start;
  font-size: 12px;
  flex-wrap: wrap;
  color: rgb(176, 176, 176);
}
.Main > div > div:nth-child(2) > div:nth-child(3) div:nth-child(3) > span {
  margin: 0 20px;
}
.prompt {
  height: 290px;
  width: 100%;
  padding: 20px;
  background-color: rgb(245, 245, 245);
}
.prompt > h4 {
  margin-bottom: 20px;
}
.prompt img{
  width: 100%;
}
/* 主体结束 */
</style>