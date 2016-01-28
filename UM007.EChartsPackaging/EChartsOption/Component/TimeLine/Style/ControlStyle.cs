using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Timeline.Style
{
    public class ControlStyle : EChartsStyle
    {
        #region 字符串属性
        private string _itemSize = "null";
        private string _itemGap = "null";

        /// <summary>
        /// 按钮大小
        /// </summary>
        [DefaultValue("null")]
        public string ItemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        /// <summary>
        /// 按钮间隔
        /// </summary>
        [DefaultValue("null")]
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 正常颜色
        /// </summary>
        public ControlStyleNormal Normal { get; set; }

        /// <summary>
        /// 高亮颜色
        /// </summary>
        public ControlStyleEmphasis Emphasis { get; set; } 
        #endregion
    }
}
