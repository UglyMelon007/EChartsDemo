using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Legend
{
    public class LegendData
    {
        #region 字符串属性
        private string _name = "null";
        private string _icon = "null";

        public LegendData()
        {
            TextStyle = null;
        }

        /// <summary>
        /// 值
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 图标类型,或路径
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
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
