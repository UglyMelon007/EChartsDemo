namespace EChartsOption.Series.MarkLine
{
    public class StartTwo
    {
        private string _name = "";
        private string _value = "";
        private string _xAxis = "";
        private string _yAxis = "";

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// 当xAxis为类目轴时，数值1会被理解为类目轴的index
        /// 当xAxis为类目轴时，字符串'周三'会被理解为与类目
        /// 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
        /// </summary>
        public string XAxis
        {
            get { return _xAxis; }
            set { _xAxis = value; }
        }

        /// <summary>
        /// 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
        /// </summary>
        public string YAxis
        {
            get { return _yAxis; }
            set { _yAxis = value; }
        }
    }
}
