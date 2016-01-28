using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据：
    /// </summary>
    public class SeriesGauge : Series
    {
        #region 字符串属性
        private string _startAngle = "null";
        private string _endAngle = "null";
        private string _min = "null";
        private string _max = "null";
        private string _splitNumber = "null";
        private string _legendHoverLink = "null";

        /// <summary>
        /// 开始角度, 饼图（90）、仪表盘（225），有效输入范围：[-360,360]
        /// </summary>
        [DefaultValue("null")]
        public string StartAngle
        {
            get { return _startAngle; }
            set { _startAngle = value; }
        }

        /// <summary>
        /// 结束角度,有效输入范围：[-360,360]，保证startAngle - endAngle为正值
        /// </summary>
        [DefaultValue("null")]
        public string EndAngle
        {
            get { return _endAngle; }
            set { _endAngle = value; }
        }

        /// <summary>
        /// 指定的最小值
        /// </summary>
        [DefaultValue("null")]
        public string Min
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        /// 指定的最大值
        /// </summary>
        [DefaultValue("null")]
        public string Max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        /// 分割段数，默认为10
        /// </summary>
        [DefaultValue("null")]
        public string SplitNumber
        {
            get { return _splitNumber; }
            set { _splitNumber = value; }
        }

        /// <summary>
        /// 是否启用图例（legend）hover时的联动响应（高亮显示）
        /// </summary>
        [DefaultValue("null")]
        public string LegendHoverLink
        {
            get { return _legendHoverLink; }
            set { _legendHoverLink = value; }
        }
        #endregion

        #region 对象属性
        /// <summary>
        /// 坐标轴线，默认显示 
        /// </summary>
        public AxisLine AxisLine { get; set; }

        /// <summary>
        /// 坐标轴小标记，默认显示 
        /// </summary>
        public AxisTick AxisTick { get; set; }

        /// <summary>
        /// 坐标轴文本标签
        /// </summary>
        public AxisLabel AxisLabel { get; set; }

        /// <summary>
        /// 主分隔线，默认显示
        /// </summary>
        public SplitLine SplitLine { get; set; }

        /// <summary>
        /// 指针样式 
        /// </summary>
        public Pointer Pointer { get; set; }

        /// <summary>
        /// 仪表盘标题 
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        /// 仪表盘详情 
        /// </summary>
        public Detail Detail { get; set; }
        #endregion
    }
}
