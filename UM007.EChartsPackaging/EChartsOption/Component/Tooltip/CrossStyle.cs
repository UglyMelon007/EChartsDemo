using System.ComponentModel;

namespace EChartsOption.Component.Tooltip
{
    public class CrossStyle
    {
        private string _color = "null";
        private string _width = "null";
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
        /// 宽度
        /// </summary>
        [DefaultValue("null")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
