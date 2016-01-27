namespace EChartsOption.Series.MarkLine
{
    /// <summary>
    /// 存在直角坐标系的图表如折线、柱形、K线、散点图中，
    /// 除了通过直接指定位置外，如果希望标线基于直角系的定位，可以通过xAxis，yAxis实现，
    /// 这两个值都会根据坐标轴类型以及传入参数的不同自动换算
    ///data : [
    ///  [
    ///  {name: '标线1起点', value: 100, xAxis: 1, yAxis: 20},      // 当xAxis为类目轴时，数值1会被理解为类目轴的index，通过xAxis:-1|MAXNUMBER可以让线到达grid边缘
    ///  {name: '标线1终点', xAxis: '周三', yAxis: 20},             // 当xAxis为类目轴时，字符串'周三'会被理解为与类目轴的文本进行匹配
    ///  ],
    ///  [
    ///  {name: '标线2起点', value: 200, xAxis: 10, yAxis: 20},     // 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
    ///  {name: '标线2终点', xAxis: 270, yAxis: 190}
    ///  ],
    ///   ] 
    /// </summary>
    public class MarkLineDataTwo : MarkLineData
    {
        private StartTwo _start = new StartTwo();
        private EndTwo _end = new EndTwo();

        /// <summary>
        /// 启始点属性
        /// </summary>
        public StartTwo Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        /// 结束点属性
        /// </summary>
        public EndTwo End
        {
            get { return _end; }
            set { _end = value; }
        }
    }
}
