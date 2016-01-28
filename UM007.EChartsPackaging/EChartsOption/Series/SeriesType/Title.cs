using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 仪表盘标题 
    /// </summary>
    public class Title
    {
        #region 字符串属性
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
        #endregion

        #region 对象属性
        /// <summary>
        ///标题定位，数组为横纵相对仪表盘圆心坐标偏移，
        /// 支持百分比（相对外半径） 
        /// </summary>
        private string[] OffsetCenter { get; set; }

        /// <summary>
        /// 文本样式
        /// </summary>
        private TextStyle TextStyle { get; set; } 
        #endregion
    }
}
