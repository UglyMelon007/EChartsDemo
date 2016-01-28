using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 坐标轴线，默认显示 (SeriesGauge)
    /// </summary>
    public class AxisLine
    {
        private string _show = "null";

        /// <summary>
        /// 是否显示
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 控制线条样式
        /// </summary>
        public LineStyle LineStyle { get; set; }
    }
}
