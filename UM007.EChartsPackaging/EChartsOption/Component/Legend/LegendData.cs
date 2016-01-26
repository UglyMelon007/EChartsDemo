using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Legend
{
    public class LegendData
    {
        private string _name = "";
        private TextStyle _textStyle = new TextStyle();
        private string _icon = "";

        /// <summary>
        /// 值
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        /// <summary>
        /// 图标类型
        /// </summary>
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }
    }
}
