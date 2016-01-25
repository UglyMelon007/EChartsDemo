namespace EChartsOption.Style
{
    public class LineStyle : EChartsStyle
    {
        private string _color = "null";
        private string _type = "solid";
        private string _width = "null";
        private string _shadowColor = "rgba(0, 0, 0, 0)";
        private string _shadowBlur = "5";
        private string _shadowOffsetX = "3";
        private string _shadowOffsetY = "3";

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 线条样式，可选为：'solid' | 'dotted' | 'dashed'，
        /// 树图还可以选：'curve' | 'broken'
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 线宽
        /// </summary>
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 折线主线(IE8+)有效，阴影色彩，支持rgba
        /// </summary>
        public string ShadowColor
        {
            get { return _shadowColor; }
            set { _shadowColor = value; }
        }

        /// <summary>
        /// 折线主线(IE8+)有效，阴影模糊度，大于0有效
        /// </summary>
        public string ShadowBlur
        {
            get { return _shadowBlur; }
            set { _shadowBlur = value; }
        }

        /// <summary>
        /// 折线主线(IE8+)有效，阴影横向偏移，正值往右，负值往左
        /// </summary>
        public string ShadowOffsetX
        {
            get { return _shadowOffsetX; }
            set { _shadowOffsetX = value; }
        }

        /// <summary>
        /// 折线主线(IE8+)有效，阴影纵向偏移，正值往下，负值往上
        /// </summary>
        public string ShadowOffsetY
        {
            get { return _shadowOffsetY; }
            set { _shadowOffsetY = value; }
        }
    }
}
