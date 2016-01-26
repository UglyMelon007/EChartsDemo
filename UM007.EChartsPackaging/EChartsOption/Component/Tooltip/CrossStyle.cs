using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Tooltip
{
    public class CrossStyle
    {
        private string _color = "#1e90ff";
        private string _width = "1";
        private string _type = "dashed";

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
