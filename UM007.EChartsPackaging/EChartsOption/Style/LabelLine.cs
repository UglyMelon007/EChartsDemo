using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class LabelLine
    {
        #region 字符串属性
        private string _show = "null";
        private string _length = "null";

        /// <summary>
        /// 标签视觉引导线，默认显示
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 线长 ，从图形外边缘起计算，可为负值。漏斗图支持'auto'
        /// </summary>
        [DefaultValue("null")]
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 线条样式，
        /// </summary>
        public LineStyle LineStyle { get; set; } 
        #endregion
    }
}
