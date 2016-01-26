using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Grid
{
    public class EChartsComponentGrid : EChartsComponent
    {
        private string _x = "80";
        private string _y = "60";
        private string _x2 = "80";
        private string _y2 = "60";
        private string _width = "null";
        private string _height = "null";
        private string _borderWidth = "1";
        private string _borderColor = "#ccc";

        /// <summary>
        /// 直角坐标系内绘图网格左上角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 直角坐标系内绘图网格左上角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 	直角坐标系内绘图网格右下角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        public string X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        /// <summary>
        /// 直角坐标系内绘图网格右下角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        public string Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        /// <summary>
        /// 直角坐标系内绘图网格（不含坐标轴）宽度，默认为总宽度 - x - x2，数值单位px，指定width后将忽略x2，见下图。 
        /// 支持百分比（字符串），如'50%'(显示区域一半的宽度)
        /// </summary>
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 直角坐标系内绘图网格（不含坐标轴）高度，默认为总高度 - y - y2，数值单位px，指定height后将忽略y2，见下图。 
        /// 支持百分比（字符串），如'50%'(显示区域一半的高度)
        /// </summary>
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 边框线宽
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 边框颜色。
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        public EChartsComponentGrid()
        {
            Show = "null";
        }
    }
}
