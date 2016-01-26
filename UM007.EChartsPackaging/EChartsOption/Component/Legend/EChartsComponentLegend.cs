using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Legend
{
    internal class EChartsComponentLegend : EChartsComponent
    {
        private string _orient = "horizontal";
        private string _x = "center";
        private string _y = "top";
        private string _borderColor = "#ccc";
        private string _borderWidth = "0";
        private string _padding = "5";
        private string _itemGap = "10";
        private string _itemWidth = "20";
        private string _itemHeight = "14";
        private string _formatter = "null";
        private string _selectedMode = "true";
        private string _selected = "null";
        private TextStyle _textStyle = new TextStyle();
        private LegendData[] _data = new LegendData[] {};

        /// <summary>
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string Orient
        {
            get { return _orient; }
            set { _orient = value; }
        }

        /// <summary>
        /// 	水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 图例边框颜色
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 图例边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 图例内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔
        /// </summary>
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        }

        /// <summary>
        /// 图例图形宽度
        /// </summary>
        public string ItemWidth
        {
            get { return _itemWidth; }
            set { _itemWidth = value; }
        }

        /// <summary>
        /// 图例图形高度
        /// </summary>
        public string ItemHeight
        {
            get { return _itemHeight; }
            set { _itemHeight = value; }
        }

        /// <summary>
        /// 文本格式器
        /// </summary>
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        /// <summary>
        /// 选择模式，默认开启图例开关，可选single，multiple
        /// </summary>
        public string SelectedMode
        {
            get { return _selectedMode; }
            set { _selectedMode = value; }
        }

        /// <summary>
        /// 配置默认选中状态，可配合LEGEND.SELECTED事件做动态数据载入
        /// </summary>
        public string Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        /// <summary>
        /// 默认只设定了图例文字颜色
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        /// <summary>
        /// 图例内容数组，数组项通常为{string}，每一项代表一个系列的name，默认布局到达边缘会自动分行（列），传入空字符串''可实现手动分行（列）。 
        /// 使用根据该值索引series中同名系列所用的图表类型和itemStyle，如果索引不到，该item将默认为没启用状态。 
        /// 如需个性化图例文字样式，可把数组项改为{Object}，指定文本样式和个性化图例icon
        /// </summary>
        public LegendData[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public EChartsComponentLegend()
        {
            _textStyle.Color = "#333";
        }
    }
}
