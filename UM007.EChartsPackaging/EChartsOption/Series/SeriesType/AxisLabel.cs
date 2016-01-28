using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    public class AxisLabel
    {
        #region 字符串属性
        private string _show = "null";
        private string _formatter = "null";

        /// <summary>
        /// 是否显示 
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 格式化文本标签
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
        /// 文本样式
        /// </summary>
        public  TextStyle TextStyle { get; set; } 
        #endregion
    }
}
