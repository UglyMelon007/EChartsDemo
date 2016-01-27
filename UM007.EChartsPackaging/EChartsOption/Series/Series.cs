using System.ComponentModel;
using EChartsOption.Component.Tooltip;
using EChartsOption.Style;

namespace EChartsOption.Series
{
    public class Series
    {
        #region 字符串属性
		private string _zlevel = "null";
        private string _z = "null";
        private string _type = "null";
        private string _name = "null";
        private string _clickable = "null";

        /// <summary>
        /// 一级层叠控制。
        /// </summary>
        [DefaultValue("null")]
        public string Zlevel
        {
            get { return _zlevel; }
            set { _zlevel = value; }
        }

        /// <summary>
        /// 二级层叠控制
        /// </summary>
        [DefaultValue("null")]
        public string Z
        {
            get { return _z; }
            set { _z = value; }
        }

        /// <summary>
        /// 图表类型，必要参数！如为空或不支持类型，则该系列数据不被显示。可选为： 
        /// 'line'（折线图） | 'bar'（柱状图） | 'scatter'（散点图） | 'k'（K线图） 
        /// 'pie'（饼图） | 'radar'（雷达图） | 'chord'（和弦图） | 'force'（力导向布局图） | 'map'（地图）
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 系列名称，如启用legend，该值将被legend.data索引相关
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

       /// <summary>
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭
       /// </summary>
        [DefaultValue("null")]
        public string Clickable
        {
            get { return _clickable; }
            set { _clickable = value; }
        } 
	#endregion

        #region 对象属性
        /// <summary>
        /// 提示框样式，仅对本系列有效，如不设则用option.tooltip,鼠标悬浮交互时的信息提示
        /// </summary>
        public ItemStyle ItemStyle { get; set; }

        /// <summary>
        /// 标注
        /// </summary>
        public MarkPoint.MarkPoint MarkPoint { get; set; }

        /// <summary>
        /// 标线
        /// </summary>
        public MarkLine.MarkLine MarkLine { get; set; }

        /// <summary>
        /// 数据，分五种,目前只写三种
        /// 具体看每种的介绍
        /// </summary>
        public SeriesData[] Data { get; set; }

        /// <summary>
        /// 提示框样式，仅对本系列有效，如不设则用option.tooltip,鼠标悬浮交互时的信息提示
        /// </summary>
        public EChartsComponentTooltip Tooltip { get; set; } 
        #endregion
    }
}
