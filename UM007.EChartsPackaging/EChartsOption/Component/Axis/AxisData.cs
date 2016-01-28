using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class AxisData
    {
        #region 字符串属性
        private string _value = "null";

        /// <summary>
        /// 文本内容
        /// </summary>
        [DefaultValue("null")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion

        #region 对象属性
        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; }
        #endregion
    }
}
