using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class SplitLine
    {
        #region 字符串属性
        private string _show = "null";
        private string _onGap = "null";

        /// <summary>
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 分隔线是否显示为间隔，默认等于boundaryGap
        /// </summary>
        [DefaultValue("null")]
        public string OnGap
        {
            get { return _onGap; }
            set { _onGap = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle LineStyle { get; set; } 
        #endregion
    }
}
