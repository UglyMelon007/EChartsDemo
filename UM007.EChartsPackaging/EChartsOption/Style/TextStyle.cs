namespace EChartsOption.Style
{
    public class TextStyle : EChartsStyle
    {
        private string _color = "null";
        private string _decoration = "null";
        private string _align = "null";
        private string _baseline = "null";
        private string _fontFamily = "null";
        private string _fontSize = "null";
        private string _fontStyle = "null";
        private string _fontWeight = "null";

        /// <summary>
        /// 颜色
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 修饰，仅对tooltip.textStyle生效
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Decoration
        {
            get { return _decoration; }
            set { _decoration = value; }
        }

        /// <summary>
        /// 水平对齐方式，可选为：'left' | 'right' | 'center'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Align
        {
            get { return _align; }
            set { _align = value; }
        }

        /// <summary>
        /// 垂直对齐方式，可选为：'top' | 'bottom' | 'middle'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Baseline
        {
            get { return _baseline; }
            set { _baseline = value; }
        }

        /// <summary>
        /// 字体系列
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string FontFamily
        {
            get { return _fontFamily; }
            set { _fontFamily = value; }
        }

        /// <summary>
        /// 字号 ，单位px
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        /// <summary>
        /// 样式，可选为：'normal' | 'italic' | 'oblique'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string FontStyle
        {
            get { return _fontStyle; }
            set { _fontStyle = value; }
        }

        /// <summary>
        /// 粗细，可选为：'normal' | 'bold' | 'bolder' | 'lighter' | 100 | 200 |... | 900
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string FontWeight
        {
            get { return _fontWeight; }
            set { _fontWeight = value; }
        }
    }
}
