using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Toolbox
{
    class EChartsComponentToolbox : EChartsComponent
    {
        private string _orient = "horizontal";
        private string _x = "right";
        private string _y = "top";
        private string _borderColor = "#ccc";
        private string _borderWidth = "0";
        private string _padding = "5";
        private string _itemGap = "10";
        private string _itemSize = "16";
        private string[] _color = { "#1e90ff", "#22bb22", "#4b0082", "#d2691e" };
        private string _disableColor = "#ddd";
        private string _effectiveColor = "#red";
        private string _showTitle = "true";
        private TextStyle _textStyle = new TextStyle();
        private Feature _feature = new Feature();

        /// <summary>
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string Orient
        {
            get { return _orient; }
            set { _orient = value; }
        }

        /// <summary>
        /// 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
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
        /// 工具箱边框颜色
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 工具箱边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 工具箱内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
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
        /// 工具箱icon大小，单位（px）
        /// </summary>
        public string ItemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        /// <summary>
        /// 工具箱icon颜色序列，循环使用，同时支持在具体feature内指定color
        /// </summary>
        public string[] Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 禁用颜色定义
        /// </summary>
        public string DisableColor
        {
            get { return _disableColor; }
            set { _disableColor = value; }
        }

        /// <summary>
        /// 生效颜色定义
        /// </summary>
        public string EffectiveColor
        {
            get { return _effectiveColor; }
            set { _effectiveColor = value; }
        }

        /// <summary>
        /// 是否显示工具箱文字提示，默认启用
        /// </summary>
        public string ShowTitle
        {
            get { return _showTitle; }
            set { _showTitle = value; }
        }
        /// <summary>
        /// 工具箱提示文字样式
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        /// <summary>
        /// 启用功能
        /// </summary>
        public Feature Feature
        {
            get { return _feature; }
            set { _feature = value; }
        }
    }
}
