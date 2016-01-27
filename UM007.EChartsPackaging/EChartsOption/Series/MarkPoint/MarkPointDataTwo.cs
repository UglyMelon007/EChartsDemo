using System.ComponentModel;

namespace EChartsOption.Series.MarkPoint
{
    /// <summary>
    /// 在存在直角坐标系的图表如折线、柱形、K线、散点图中，
    /// 除了通过直接指定位置外，如果希望标注基于直角系的定位，
    /// 可以通过xAxis，yAxis实现，
    /// 这两个值都会根据坐标轴类型以及传入参数的不同自动换算
    /// data : [
    ///  {name: '标注1', value: 100, xAxis: 1, yAxis: 20},      // 当xAxis为类目轴时，数值1会被理解为类目轴的index
    ///  {name: '标注2', value: 100, xAxis: '周三', yAxis: 20}, // 当xAxis为类目轴时，字符串'周三'会被理解为与类目轴的文本进行匹配
    ///  {name: '标注3', value: 200, xAxis: 10, yAxis: 20},     // 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
    ///  ]
    /// </summary>
    public class MarkPointDataTwo : MarkPointData
    {
        private string _name = "null";
        private string _value = "null";
        private string _xAxis = "null";
        private string _yAxis = "null";

        /// <summary>
        /// 名称
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        [DefaultValue("null")]
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
        [DefaultValue("null")]
        public string XAxis
        {
            get { return _xAxis; }
            set { _xAxis = value; }
        }

        /// <summary>
        /// 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
        /// </summary>
        [DefaultValue("null")]
        public string YAxis
        {
            get { return _yAxis; }
            set { _yAxis = value; }
        }
    }
}
