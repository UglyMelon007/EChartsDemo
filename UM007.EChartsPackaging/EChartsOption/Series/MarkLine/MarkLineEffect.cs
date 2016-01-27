using System.ComponentModel;

namespace EChartsOption.Series.MarkLine
{
    public class MarkLineEffect
    {
        private string _show = "null";
        private string _loop = "null";
        private string _period = "null";
        private string _scaleSize = "null";
        private string _color = "null";
        private string _shadowColor = "null";
        private string _shadowBlur = "null";

        /// <summary>
        /// 是否开启，默认关闭 
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 循环动画，默认开启
        /// </summary>
        [DefaultValue("null")]
        public string Loop
        {
            get { return _loop; }
            set { _loop = value; }
        }

        /// <summary>
        /// 运动周期，无单位，值越大越慢，默认为15 
        /// </summary>
        [DefaultValue("null")]
        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }

        /// <summary>
        /// 放大倍数，以markPoint symbolSize为基准，type为scale时有效 
        /// </summary>
        [DefaultValue("null")]
        public string ScaleSize
        {
            get { return _scaleSize; }
            set { _scaleSize = value; }
        }

        /// <summary>
        ///  炫光颜色，默认跟随markPoint itemStyle定义颜色, 
        /// </summary>
        [DefaultValue("null")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 光影颜色，默认跟随color 
        /// </summary>
        [DefaultValue("null")]
        public string ShadowColor
        {
            get { return _shadowColor; }
            set { _shadowColor = value; }
        }

        /// <summary>
        /// 光影模糊度，默认为0 
        /// </summary>
        [DefaultValue("null")]
        public string ShadowBlur
        {
            get { return _shadowBlur; }
            set { _shadowBlur = value; }
        }
    }
}
