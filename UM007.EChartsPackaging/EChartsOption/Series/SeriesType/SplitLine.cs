using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    public class SplitLine
    {
        #region 字符串样式
        private string _show = "null";
        private string _length = "null";

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
        /// 线长
        /// </summary>
        [DefaultValue("null")]
        public string Lenght
        {
            get { return _length; }
            set { _length = value; }
        } 
        #endregion

        #region 线条样式
        /// <summary>
        /// 线条样式
        /// </summary>
        public LineStyle LineStyle { get; set; } 
        #endregion
    }
}
