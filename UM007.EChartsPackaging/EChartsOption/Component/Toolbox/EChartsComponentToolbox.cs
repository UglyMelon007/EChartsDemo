using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Toolbox
{
    public class EChartsComponentToolbox : EChartsComponent
    {
        #region 字符串属性
        private string _orient = "null";
        private string _x = "null";
        private string _y = "null";
        private string _borderColor = "null";
        private string _borderWidth = "null";
        private string _padding = "null";
        private string _itemGap = "null";
        private string _itemSize = "null";
        private string _disableColor = "null";
        private string _effectiveColor = "null";
        private string _showTitle = "null";

        public EChartsComponentToolbox()
        {
            Feature = new Feature();
            TextStyle = null;
            Color = null;
        }

        /// <summary>
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Orient
        {
            get { return _orient; }
            set { _orient = value; }
        }

        /// <summary>
        /// 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 工具箱边框颜色
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 工具箱边框线宽，单位px，默认为0（无边框）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 工具箱内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        }

        /// <summary>
        /// 工具箱icon大小，单位（px）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ItemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        /// <summary>
        /// 禁用颜色定义
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string DisableColor
        {
            get { return _disableColor; }
            set { _disableColor = value; }
        }

        /// <summary>
        /// 生效颜色定义
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string EffectiveColor
        {
            get { return _effectiveColor; }
            set { _effectiveColor = value; }
        }

        /// <summary>
        /// 是否显示工具箱文字提示，默认启用
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ShowTitle
        {
            get { return _showTitle; }
            set { _showTitle = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 工具箱icon颜色序列，循环使用，同时支持在具体feature内指定color
        /// </summary>
        public string[] Color { get; set; }

        /// <summary>
        /// 工具箱提示文字样式
        /// </summary>
        public TextStyle TextStyle { get; set; }

        /// <summary>
        /// 启用功能
        /// </summary>
        public Feature Feature { get; set; } 
        #endregion
    }
}
