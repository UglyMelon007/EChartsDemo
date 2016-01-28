using System.ComponentModel;
using EChartsOption.Component.Tooltip;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesDataType
{
    /// <summary>
    /// 系列中的数据内容数组，
    /// 折线图以及柱状图时数组长度等于所使用类目轴文本标签数组axis.data的长度，
    /// 并且他们间是一一对应的。数组项通常为数值
    /// [ 
    /// 12, 34,
    ///  {
    ///  value : 56,
    ///  tooltip:{},             //自定义特殊tooltip，仅对该item有效，详见tooltip
    ///  itemStyle:{}            //自定义特殊itemStyle，仅对该item有效，详见itemStyle
    ///  },
    ///  10, 23
    ///  ]
    /// </summary>
    public class SeriesDataOne : SeriesData
    {
        #region 字符串属性
        private string _value = "null";

        /// <summary>
        /// 数据值 当某类目对应数据不存在时（ps：'不存在' 不代表值为 0），可用'-'表示，
        /// 无数据在折线图中表现为折线在该点断开，在柱状图中表现为该点无柱形
        /// </summary>
        [DefaultValue("null")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        #endregion

        #region 对象属性
        /// <summary>
        /// 自定义特殊tooltip，仅对该item有效
        /// </summary>
        public EChartsComponentTooltip Tooltip { get; set; }

        /// <summary>
        /// 自定义特殊itemStyle，仅对该item有效
        /// </summary>
        public ItemStyle ItemStyle { get; set; }
        #endregion
    }
}
