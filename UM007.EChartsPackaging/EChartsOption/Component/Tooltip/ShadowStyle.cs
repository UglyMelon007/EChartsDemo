using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Tooltip
{
    public class ShadowStyle
    {
        private string _color = "rgba(150, 150, 150, 0.3)";
        private string _width = "auto";
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
        /// 宽度
        /// </summary>
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
