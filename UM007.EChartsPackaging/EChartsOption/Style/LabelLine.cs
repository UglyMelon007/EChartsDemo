using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class LabelLine
    {
        private string _show = "true";
        private string _length = "40";
        private LineStyle _lineStyle = new LineStyle();

        /// <summary>
        /// 标签视觉引导线，默认显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 线长 ，从图形外边缘起计算，可为负值。漏斗图支持'auto'
        /// </summary>
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// 线条样式，
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }
    }
}
