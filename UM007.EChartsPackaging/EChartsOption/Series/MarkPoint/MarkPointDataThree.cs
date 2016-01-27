using System.ComponentModel;

namespace EChartsOption.Series.MarkPoint
{
    /// <summary>
    /// 更为实用的，在折线、柱形、散点图中，
    /// 可以直接使用如下几个开箱即用的特殊点标注
    /// data : [
    ///  {type : 'max', name: '自定义名字'},    // 最大值
    ///  {type : 'min', name: '自定义名字'}     // 最小值
    ///  ]
    /// </summary>
    public class MarkPointDataThree : MarkPointData
    {
        private string _type = "null";
        private string _name = "null";

        /// <summary>
        /// 标注类型
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 标注名字
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
