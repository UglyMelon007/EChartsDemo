using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 指针样式 
    /// </summary>
    public class Pointer
    {
        private string _length = "null";
        private string _width = "null";
        private string _color = "null";

        /// <summary>
        /// 是否显示
        /// </summary>
        [DefaultValue("null")]
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// 指针最宽处
        /// </summary>
        [DefaultValue("null")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 指针颜色
        /// </summary>
        [DefaultValue("null")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
