using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class SplitArea
    {
        private string _show = "false";
        private string _onGap = "null";
        private AreaStyle _areaStyle = new AreaStyle();

        /// <summary>
        /// 是否显示，默认为false，设为true后带如下默认样式
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 分隔区域是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public string OnGap
        {
            get { return _onGap; }
            set { _onGap = value; }
        }

        /// <summary>
        /// 属性areaStyle（详见areaStyle）控制区域样式，颜色数组实现间隔变换。
        /// </summary>
        public AreaStyle AreaStyle
        {
            get { return _areaStyle; }
            set { _areaStyle = value; }
        }

        public SplitArea()
        {
            _areaStyle.Color = "[ 'rgba(250,250,250,0.3)', 'rgba(200,200,200,0.3)' ]";
        }
    }
}
