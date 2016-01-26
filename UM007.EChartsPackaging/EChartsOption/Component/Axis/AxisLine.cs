using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class AxisLine
    {
        private string _show = "true";
        private string _onZero = "true";
        private LineStyle _lineStyle = new LineStyle();

        /// <summary>
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 定位到垂直方向的0值坐标上
        /// </summary>
        public string OnZero
        {
            get { return _onZero; }
            set { _onZero = value; }
        }

        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        public AxisLine()
        {
            _lineStyle.Color = "#48b";
            _lineStyle.Width = "2";
            _lineStyle.Type = "solid";
        }
    }
}
