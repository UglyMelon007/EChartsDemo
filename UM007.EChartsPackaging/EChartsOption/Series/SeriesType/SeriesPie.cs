using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据
    /// </summary>
    public class SeriesPie : Series
    {
        #region 对象属性
        /// <summary>
        /// 圆心坐标，支持绝对值（px）和百分比，百分比计算min(width, height) * 50%
        /// </summary>
        public string[] Center { get; set; }

        /// <summary>
        /// 半径，支持绝对值（px）和百分比，百分比计算比，min(width, height) / 2 * 75%， 传数组实现环形图，[内半径，外半径]
        /// </summary>
        public string[] Radius { get; set; }
        #endregion

        #region 字符串属性
        private string _startAngle = "null";
        private string _minAngle = "null";
        private string _clockWise = "null";
        private string _roseType = "null";
        private string _selectedOffset = "null";
        private string _selectedMode = "null";
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
        /// 最小角度，可用于防止某item的值过小而影响交互
        /// </summary>
        [DefaultValue("null")]
        public string MinAngle
        {
            get { return _minAngle; }
            set { _minAngle = value; }
        }

        /// <summary>
        /// 显示是否顺时针
        /// </summary>
        [DefaultValue("null")]
        public string ClockWise
        {
            get { return _clockWise; }
            set { _clockWise = value; }
        }

        /// <summary>
        /// 南丁格尔玫瑰图模式，'radius'（半径） | 'area'（面积）
        /// </summary>
        [DefaultValue("null")]
        public string RoseType
        {
            get { return _roseType; }
            set { _roseType = value; }
        }

        /// <summary>
        /// 	选中是扇区偏移量
        /// </summary>
        [DefaultValue("null")]
        public string SelectedOffset
        {
            get { return _selectedOffset; }
            set { _selectedOffset = value; }
        }

        /// <summary>
        /// 选中模式，默认关闭，可选single，multiple
        /// </summary>
        [DefaultValue("null")]
        public string SelectedMode
        {
            get { return _selectedMode; }
            set { _selectedMode = value; }
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
    }
}
