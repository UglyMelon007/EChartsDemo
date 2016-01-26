using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class AxisTick
    {
        private string _show = "false";
        private string _interval = "auto";
        private string _onGap = "null";
        private string _inside = "false";
        private string _length = "5";
        private LineStyle _lineStyle = new LineStyle();

        /// <summary>
        /// 是否显示，默认为false，设为true后下面为默认样式
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 小标记显示挑选间隔，默认为'auto'，可选为： 
        /// 'auto'（随axisLabel，自动隐藏显示不下的） | 0（全部显示） | 
        /// {number}（用户指定选择间隔） 
        /// {function}函数回调，传递参数[index，data[index]]，返回true显示，返回false隐藏
        /// </summary>
        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        /// <summary>
        /// 小标记是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public string OnGap
        {
            get { return _onGap; }
            set { _onGap = value; }
        }

        /// <summary>
        /// 小标记是否显示为在grid内部，默认在外部
        /// </summary>
        public string Inside
        {
            get { return _inside; }
            set { _inside = value; }
        }

        /// <summary>
        /// 属性length控制线长
        /// </summary>
        public string Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// <summary>
        /// 属性lineStyle控制线条样式
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        public AxisTick()
        {
            _lineStyle.Color = "#333";
            _lineStyle.Width = "1";
        }
    }
}
