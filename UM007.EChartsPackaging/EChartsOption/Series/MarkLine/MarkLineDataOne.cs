namespace EChartsOption.Series.MarkLine
{
    /// <summary>
    /// 标线的数据内容数组，
    /// 最直接的数据项可直接指定标线起始和结束位置（x，y）以及相关名称（name）和值（value），
    /// 在饼图、雷达图、力导、和弦图中
    /// data : [
    ///  [
    ///  {name: '标线1起点', value: 100, x: 50, y: 20},
    ///  {name: '标线1终点', x: 150, y: 120}
    ///  ],
    ///  [
    ///  {name: '标线2起点', value: 200, x: 30, y: 80},
    ///  {name: '标线2终点', x: 270, y: 190}
    ///  ],
    ///  ]
    /// </summary>
    public class MarkLineDataOne : MarkLineData
    {
        private StartOne _start = new StartOne();
        private EndOne _end = new EndOne();

        /// <summary>
        /// 启始点属性
        /// </summary>
        public StartOne Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        /// 结束点属性
        /// </summary>
        public EndOne End
        {
            get { return _end; }
            set { _end = value; }
        }
    }
}
