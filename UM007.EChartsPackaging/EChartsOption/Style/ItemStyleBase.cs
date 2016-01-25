using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class ItemStyleBase
    {
        private string _color = "null";
        private string _borderColor = "null";
        private string _borderWidth = "null";
        private string _barBorderColor = "#fff";
        private string _barBorderRadius = "0";
        private string _barBorderWidth = "0";

        private LineStyle _lineStyle = new LineStyle();
        private Label _label = new Label();
        private AreaStyle _areaStyle = new AreaStyle();
        private LabelLine _labelLine = new LabelLine();
        //private ChordStyle _chordStyle = new ChordStyle();
        //private NodeStyle _nodeStyle = new NodeStyle();
        //private LinkStyle _linkStyle = new LinkStyle();

        /// <summary>
        /// 颜色，主色 
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 边框线宽，单位px
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 边框颜色(柱)
        /// </summary>
        public string BarBorderColor
        {
            get { return _barBorderColor; }
            set { _barBorderColor = value; }
        }

        /// <summary>
        /// 柱形边框圆角，单位px，默认为0，支持传入数组分别指定柱形4个圆角半径，
        /// 如:[5, 5, 0, 0]（顺时针左上，右上，右下，左下）柱
        /// </summary>
        public string BarBorderRadius
        {
            get { return _barBorderRadius; }
            set { _barBorderRadius = value; }
        }

        /// <summary>
        /// 柱形边框线宽，单位px，默认为0
        /// </summary>
        public string BarBorderWidth
        {
            get { return _barBorderWidth; }
            set { _barBorderWidth = value; }
        }

        /// <summary>
        /// 线条样式
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        /// <summary>
        /// 标签，饼图默认显示在外部，离饼图距离由labelLine.length决定，
        ///  漏斗图默认显示在右侧，离图形距离由labelLine.length决定 地图标签不可指定位置，
        ///  折线图，柱形图，K线图，散点图可指定position
        /// </summary>
        public Label Label
        {
            get { return _label; }
            set { _label = value; }
        }

        /// <summary>
        /// 区域样式
        /// </summary>
        public AreaStyle AreaStyle
        {
            get { return _areaStyle; }
            set { _areaStyle = value; }
        }

        /// <summary>
        /// 标签视觉引导线，默认显示
        /// </summary>
        public LabelLine LabelLine
        {
            get { return _labelLine; }
            set { _labelLine = value; }
        }
    }
}
