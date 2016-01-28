using System.ComponentModel;

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
        private string _name = "null";
        private string _value = "null";
        private string _x = "null";
        private string _y = "null";

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
        /// x坐标
        /// </summary>
        [DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// y坐标
        /// </summary>
        [DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
