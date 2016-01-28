using System.ComponentModel;

namespace EChartsOption.Series.MarkLine
{
    /// <summary>
    /// 更为实用的，在折线、柱形、散点图中，可以直接使用如下几个开箱即用的特殊点作为标线类型
    /// data : [
    ///  {type : 'max', name: '自定义名字'},    // 最大值水平线或垂直线
    ///  {type : 'min', name: '自定义名字'},    // 最小值水平线或垂直线
    ///  {type : 'average', name: '自定义名字'},// 平均值水平线或垂直线
    ///  
    /// // 最小值指向最大值的连线
    ///  [
    ///  {type : 'min', name: '自定义名字'},
    ///  {type : 'max', name: '自定义名字'}
    ///  ],
    ///  
    /// // 散点图中存在两个数值型坐标，默认用纵轴值计算特殊点，可以通过valueIndex:0指定为横轴特殊点
    ///  {type : 'max', name: '自定义名字', valueIndex:0}
    ///  ]
    /// </summary>
    public class MarkLineDataThree : MarkLineData
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
