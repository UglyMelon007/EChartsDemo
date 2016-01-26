using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Tooltip
{
    public class AxisPointer
    {
        private string _type = "line";
        private CrossStyle _crossStyle = new CrossStyle();
        private LineStyle _lineStyle = new LineStyle();
        private ShadowStyle _shadowStyle = new ShadowStyle();

        /// <summary>
        /// 
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 设置十字准星指示器
        /// </summary>
        public CrossStyle CrossStyle
        {
            get { return _crossStyle; }
            set { _crossStyle = value; }
        }

        /// <summary>
        /// 设置直线指示器
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        /// <summary>
        /// 设置阴影指示器
        /// </summary>
        public ShadowStyle ShadowStyle
        {
            get { return _shadowStyle; }
            set { _shadowStyle = value; }
        }

        public AxisPointer()
        {
            _lineStyle.Color = "#48b";
            _lineStyle.Width = "2";
            _lineStyle.Type = "solid";
        }
    }
}
