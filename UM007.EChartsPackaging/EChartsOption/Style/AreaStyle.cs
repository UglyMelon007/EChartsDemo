using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class AreaStyle
    {
        private string _color = "null";
        private string _type = "default";

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 填充样式，目前仅支持'default'(实填充)
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
