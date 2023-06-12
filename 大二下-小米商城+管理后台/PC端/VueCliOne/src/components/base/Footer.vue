<template>
  <div id="Footer">
    <div>
      <ul>
        <li><a href="#" class="glyphicon glyphicon-wrench">预约维修服务</a></li>
        <li></li>
        <li>
          <a href="#" class="glyphicon glyphicon-earphone">7天无理由退货</a>
        </li>
        <li></li>
        <li><a href="#" class="glyphicon glyphicon-home">15天免费换货</a></li>
        <li></li>
        <li><a href="#" class="glyphicon glyphicon-gift">满69包邮</a></li>
        <li></li>
        <li>
          <a href="#" class="glyphicon glyphicon-map-marker">520余家售后网点</a>
        </li>
      </ul>
    </div>
    <div>
      <ul>
        <li>
          <dl>
            <dt>帮助中心</dt>
            <dd><a href="#">账户管理</a></dd>
            <dd><a href="#">购物指南</a></dd>
            <dd><a href="#">订单操作</a></dd>
          </dl>
        </li>
        <li>
          <dl>
            <dt>服务支持</dt>
            <dd><a href="#">售后政策</a></dd>
            <dd><a href="#">自助服务</a></dd>
            <dd><a href="#">相关下载</a></dd>
          </dl>
        </li>
        <li>
          <dl>
            <dt>线下门店</dt>
            <dd><a href="#">小米之家</a></dd>
            <dd><a href="#">服务网点</a></dd>
            <dd><a href="#">授权体验店</a></dd>
          </dl>
        </li>
        <li>
          <dl>
            <dt>关于小米</dt>
            <dd><a href="#">了解小米</a></dd>
            <dd><a href="#">加入小米</a></dd>
            <dd><a href="#">投资者关系</a></dd>
            <dd><a href="#">企业社会责任</a></dd>
            <dd><a href="#">廉洁举报</a></dd>
          </dl>
        </li>
        <li>
          <dl>
            <dt>关注我们</dt>
            <dd><a href="#">新浪微博</a></dd>
            <dd><a href="#">官方微信</a></dd>
            <dd><a href="#">联系我们</a></dd>
            <dd><a href="#">公益基金会</a></dd>
          </dl>
        </li>
        <li>
          <dl>
            <dt>特色服务</dt>
            <dd><a href="#">F 码通道</a></dd>
            <dd><a href="#">礼物码</a></dd>
            <dd><a href="#">防伪查询</a></dd>
          </dl>
        </li>
        <li></li>
        <li>
          <div>
            <h4>400-100-5678</h4>
            <span>8:00-18:00仅收市话费</span>
            <a href="#">人工客服</a>
            <span>
              <a href="#"
                >关注小米：<img
                  src="/static/images/Goods/notice.png"
                  width="50px"
                  alt=""
              /></a>
            </span>
          </div>
        </li>
      </ul>
    </div>
    <div>
      <img
        src="/static/images/Goods/bottom.png"
        width="1200px"
        height="250px"
        class="img-responsive"
        alt=""
      />
    </div>
  </div>
</template>
<script>
export default {
  name: "Footer",
};
</script>
<style scoped>
* {
  padding: 0;
  margin: 0;
  list-style: none;
}
#Footer {
  display: flex;
  flex-direction: column;
  width: 100%;
  height: 480px;
  color: rgb(97, 97, 97);
}
#Footer div:nth-child(1) {
  height: 80px;
  width: 100%;
}
#Footer div:nth-child(1) > ul {
  display: flex;
  height: 100%;
  width: 100%;
  border-bottom: 1px solid rgb(224, 224, 224);
  justify-content: space-around;
  align-items: center;
}
#Footer div:nth-child(1) > ul li:nth-child(even) {
  width: 0.8px;
  height: 20px;
  background-color: rgb(219, 219, 219);
}
#Footer div:nth-child(1) > ul > li > a {
  text-decoration: none;
  color: rgb(97, 97, 97);
  font-size: 16px;
}
#Footer div:nth-child(1) > ul > li > a:hover {
  transition: 0.3s;
  color: rgb(255, 106, 0);
}
#Footer div:nth-child(2) {
  height: 230px;
  width: 100%;
}

#Footer div:nth-child(2) ul {
  width: 100%;
  height: 100%;
  padding: 20px 20px;
  display: flex;
  justify-content: space-between;
}

#Footer div:nth-child(2) ul > li:nth-child(7) {
  width: 1px;
  height: 150px;
  background-color: rgb(224, 224, 224);
}
#Footer div:nth-child(2) ul > li > dl > dt {
  font-size: 14px;
  color: #757575;
  font-weight: normal;
  margin-bottom: 20px;
}
#Footer div:nth-child(2) ul > li > dl > dd {
  margin-top: 10px;
}
#Footer div:nth-child(2) ul > li > dl > dd > a {
  font-size: 12px;
  text-decoration: none;
  color: #757575;
}
#Footer div:nth-child(2) ul > li > dl > dd > a:hover {
  color: rgb(255, 106, 0);
  transition: 0.1s;
}
#Footer div:nth-child(2) ul > li:nth-child(8) {
  align-self: stretch;
  width: 130px;
  /* background-color: rgb(180, 170, 190); */
  height: 140px;
}
#Footer div:nth-child(2) ul > li:nth-child(8) > div {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-around;
  align-items: center;
}
#Footer div:nth-child(2) ul > li:nth-child(8) > div h4 + span {
  font-size: 8px;
}
#Footer div:nth-child(2) ul > li:nth-child(8) > div span + a {
  width: 100%;
  height: 30px;
  display: flex;
  justify-content: center;
  align-items: center;
  border: 1px solid rgb(255, 106, 0);
  text-decoration: none;
  color: rgb(255, 106, 0);
  font-size: 12px;
}
#Footer div:nth-child(2) ul > li:nth-child(8) > div span + a:hover {
  background-color: rgb(255, 106, 0);
  color: rgb(255, 255, 255);
  transition-duration: 0.5s;
}
#Footer div:nth-child(2) ul > li:nth-child(8) > div span > a {
  text-decoration: none;
  font-size: 12px;
  color: #757575;
}
</style>