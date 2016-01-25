namespace EChartsOption.Style
{
    public class TextStyle : EChartsStyle
    {
        private string _color = "null";
        private string _decoration = "nono";
        private string _align = "null";
        private string _baseline = "null";
        private string _fontFamily = "Arial, Verdana, sans-serif";
        private string _fontSize = "12";
        private string _fontStyle = "normal";
        private string _fontWeight = "normal";

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 修饰，仅对tooltip.textStyle生效
        /// </summary>
        public string Decoration
        {
            get { return _decoration; }
            set { _decoration = value; }
        }

        /// <summary>
        /// 水平对齐方式，可选为：'left' | 'right' | 'center'
        /// </summary>
        public string Align
        {
            get { return _align; }
            set { _align = value; }
        }

        /// <summary>
        /// 垂直对齐方式，可选为：'top' | 'bottom' | 'middle'
        /// </summary>
        public string Baseline
        {
            get { return _baseline; }
            set { _baseline = value; }
        }

        /// <summary>
        /// 字体系列
        /// </summary>
        public string FontFamily
        {
            get { return _fontFamily; }
            set { _fontFamily = value; }
        }

        /// <summary>
        /// 字号 ，单位px
        /// </summary>
        public string FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        /// <summary>
        /// 样式，可选为：'normal' | 'italic' | 'oblique'
        /// </summary>
        public string FontStyle
        {
            get { return _fontStyle; }
            set { _fontStyle = value; }
        }

        /// <summary>
        /// 粗细，可选为：'normal' | 'bold' | 'bolder' | 'lighter' | 100 | 200 |... | 900
        /// </summary>
        public string FontWeight
        {
            get { return _fontWeight; }
            set { _fontWeight = value; }
        }
    }
}
