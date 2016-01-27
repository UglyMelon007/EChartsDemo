using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Tooltip
{
    public class EChartsComponentTooltip:EChartsComponent
    {
        #region 字符串属性
        private string _showContent = "null";
        private string _trigger = "null";
        private string _position = "null";
        private string _formatter = "null";
        private string _islandFormatter = "null";
        private string _showDelay = "null";
        private string _hideDelay = "null";
        private string _transitionDuration = "null";
        private string _enterable = "null";
        private string _borderColor = "null";
        private string _borderRadius = "null";
        private string _borderWidth = "null";
        private string _padding = "null";

        /// <summary>
        /// tooltip主体内容显示策略，只需tooltip触发事件或显示axisPointer而不需要显示内容时可配置该项为false，
        ///  可选为：true（显示） | false（隐藏）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ShowContent
        {
            get { return _showContent; }
            set { _showContent = value; }
        }

        /// <summary>
        /// 触发类型，默认数据触发，见下图，可选为：'item' | 'axis'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Trigger
        {
            get { return _trigger; }
            set { _trigger = value; }
        }

        /// <summary>
        /// 位置指定，传入{Array}，如[x, y]， 固定位置[x, y]；传入{Function}，如function([x, y]) {return [newX,newY]}，默认显示坐标为输入参数，用户指定的新坐标为输出返回。
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// 内容格式器
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        /// <summary>
        /// 拖拽重计算独有，数据孤岛内容格式器
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string IslandFormatter
        {
            get { return _islandFormatter; }
            set { _islandFormatter = value; }
        }

        /// <summary>
        /// 显示延迟，添加显示延迟可以避免频繁切换，特别是在详情内容需要异步获取的场景，单位ms
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ShowDelay
        {
            get { return _showDelay; }
            set { _showDelay = value; }
        }

        /// <summary>
        /// 隐藏延迟，单位ms
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string HideDelay
        {
            get { return _hideDelay; }
            set { _hideDelay = value; }
        }

        /// <summary>
        /// 动画变换时长，单位s，如果你希望tooltip的跟随实时响应，showDelay设置为0是关键，同时transitionDuration设0也会有交互体验上的差别
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string TransitionDuration
        {
            get { return _transitionDuration; }
            set { _transitionDuration = value; }
        }

        /// <summary>
        /// 鼠标是否可进入详情气泡中，默认为false，如需详情内交互，如添加链接，按钮，可设置为true。
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Enterable
        {
            get { return _enterable; }
            set { _enterable = value; }
        }

        /// <summary>
        /// 提示边框颜色
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 提示边框圆角，单位px，默认为4
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; }
        }

        /// <summary>
        /// 提示边框线宽，单位px，默认为0（无边框）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 提示内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; }

        /// <summary>
        /// 坐标轴指示器，默认type为line
        /// </summary>
        public AxisPointer AxisPointer { get; set; } 
        #endregion
    }
}
