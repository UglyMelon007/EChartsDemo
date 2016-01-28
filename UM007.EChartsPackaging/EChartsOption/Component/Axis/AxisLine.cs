using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class AxisLine
    {
        #region 字符串属性
        private string _show = "null";
        private string _onZero = "null";

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
        /// 定位到垂直方向的0值坐标上
        /// </summary>
        [DefaultValue("null")]
        public string OnZero
        {
            get { return _onZero; }
            set { _onZero = value; }
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
