using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class SplitLine
    {
        private string _show = "true";
        private string _onGap = "null";
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
        /// 分隔线是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public string OnGap
        {
            get { return _onGap; }
            set { _onGap = value; }
        }

        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        public SplitLine()
        {
            _lineStyle.Color = "#ccc";
            _lineStyle.Width = "1";
            _lineStyle.Type = "solid";
        }
    }
}
