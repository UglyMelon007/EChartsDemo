using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 坐标轴小标记，默认显示 (SeriesGauge)
    /// </summary>
    public class AxisTick
    {
        #region 字符串属性
        private string _show = "null";
        private string _splitNumber = "null";
        private string _length = "null";

        /// <summary>
        /// 显示与否
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 控制每份split细分多少段 
        /// </summary>
        [DefaultValue("null")]
        public string SplitNumber
        {
            get { return _splitNumber; }
            set { _splitNumber = value; }
        }

        /// <summary>
        /// 控制线长
        /// </summary>
        [DefaultValue("null")]
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }
        #endregion

        #region 对象属性
        ///<summary>
        /// 控制线条样式， 
        /// </summary>
        public LineStyle LineStyle { get; set; }
        #endregion
    }
}
