using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    public class Detail
    {
        #region 字符串属性
        private string _show = "null";
        private string _backgroundColor = "null";
        private string _borderWidth = "null";
        private string _borderColor = "null";
        private string _width = "null";
        private string _height = "null";
        private string _formatter = "null";

        /// <summary>
        /// 显示与否
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 背景颜色
        /// </summary>
        [DefaultValue("null")]
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        /// <summary>
        /// 边框线宽
        /// </summary>
        [DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        [DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
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
        /// 高度
        /// </summary>
        [DefaultValue("null")]
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 格式化文本
        /// </summary>
        [DefaultValue("null")]
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 定位，数组为横纵相对仪表盘圆心坐标偏移，支持百分比（相对外半径），
        /// </summary>
        public string[] OffsetCenter { get; set; }

        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; } 
        #endregion
    }
}
