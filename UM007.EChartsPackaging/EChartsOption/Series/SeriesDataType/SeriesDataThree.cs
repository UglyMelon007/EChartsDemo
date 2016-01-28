using System.ComponentModel;

namespace EChartsOption.Series.SeriesDataType
{
    /// <summary>
    /// 当图表类型为饼图时，需要说明每部分数据的名称name，可设置选中状态
    /// </summary>
    public class SeriesDataThree : SeriesData
    {
        private string _value = "null";
        private string _name = "null";
        private string _selected = "null";

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
        /// 名字
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 选中状态
        /// </summary>
        [DefaultValue("null")]
        public string Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
    }
}
