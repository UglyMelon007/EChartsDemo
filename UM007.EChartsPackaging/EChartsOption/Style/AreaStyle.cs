using System.ComponentModel;

namespace EChartsOption.Style
{
    public class AreaStyle
    {
        private string _color = "null";
        private string _type = "null";

        /// <summary>
        /// 颜色
        /// </summary>
        [DefaultValue("null")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 填充样式，目前仅支持'default'(实填充)
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
