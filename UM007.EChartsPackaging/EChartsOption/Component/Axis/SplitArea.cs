using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class SplitArea
    {
        #region 字符串属性
        private string _show = "null";
        private string _onGap = "null";

        /// <summary>
        /// 是否显示，默认为false，设为true后带如下默认样式
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 分隔区域是否显示为间隔，默认等于boundaryGap
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
        /// 属性areaStyle（详见areaStyle）控制区域样式，颜色数组实现间隔变换。
        /// </summary>
        public AreaStyle AreaStyle { get; set; } 
        #endregion
    }
}
