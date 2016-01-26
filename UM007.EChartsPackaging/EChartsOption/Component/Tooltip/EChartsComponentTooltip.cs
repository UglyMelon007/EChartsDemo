using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Tooltip
{
    public class EChartsComponentTooltip:EChartsComponent
    {
        private string _showContent = "true";
        private string _trigger = "item";
        private string _position = "null";
        private string _formatter = "null";
        private string _islandFormatter = "{a}<br/>{b}:{c}";
        private string _showDelay = "20";
        private string _hideDelay = "100";
        private string _transitionDuration = "0.4";
        private string _enterable = "false";
        private string _borderColor = "#333";
        private string _borderRadius = "4";
        private string _borderWidth = "0";
        private string _padding = "5";
        private TextStyle _textStyle = new TextStyle();
        private AxisPointer _axisPointer = new AxisPointer();

        /// <summary>
        /// tooltip主体内容显示策略，只需tooltip触发事件或显示axisPointer而不需要显示内容时可配置该项为false，
        ///  可选为：true（显示） | false（隐藏）
        /// </summary>
        public string ShowContent
        {
            get { return _showContent; }
            set { _showContent = value; }
        }

        /// <summary>
        /// 触发类型，默认数据触发，见下图，可选为：'item' | 'axis'
        /// </summary>
        public string Trigger
        {
            get { return _trigger; }
            set { _trigger = value; }
        }

        /// <summary>
        /// 位置指定，传入{Array}，如[x, y]， 固定位置[x, y]；传入{Function}，如function([x, y]) {return [newX,newY]}，默认显示坐标为输入参数，用户指定的新坐标为输出返回。
        /// </summary>
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// 内容格式器
        /// </summary>
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        /// <summary>
        /// 拖拽重计算独有，数据孤岛内容格式器
        /// </summary>
        public string IslandFormatter
        {
            get { return _islandFormatter; }
            set { _islandFormatter = value; }
        }

        /// <summary>
        /// 显示延迟，添加显示延迟可以避免频繁切换，特别是在详情内容需要异步获取的场景，单位ms
        /// </summary>
        public string ShowDelay
        {
            get { return _showDelay; }
            set { _showDelay = value; }
        }

        /// <summary>
        /// 隐藏延迟，单位ms
        /// </summary>
        public string HideDelay
        {
            get { return _hideDelay; }
            set { _hideDelay = value; }
        }

        /// <summary>
        /// 动画变换时长，单位s，如果你希望tooltip的跟随实时响应，showDelay设置为0是关键，同时transitionDuration设0也会有交互体验上的差别
        /// </summary>
        public string TransitionDuration
        {
            get { return _transitionDuration; }
            set { _transitionDuration = value; }
        }

        /// <summary>
        /// 鼠标是否可进入详情气泡中，默认为false，如需详情内交互，如添加链接，按钮，可设置为true。
        /// </summary>
        public string Enterable
        {
            get { return _enterable; }
            set { _enterable = value; }
        }

        /// <summary>
        /// 提示边框颜色
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 提示边框圆角，单位px，默认为4
        /// </summary>
        public string BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; }
        }

        /// <summary>
        /// 提示边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 提示内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        /// <summary>
        /// 坐标轴指示器，默认type为line
        /// </summary>
        public AxisPointer AxisPointer
        {
            get { return _axisPointer; }
            set { _axisPointer = value; }
        }

        public EChartsComponentTooltip()
        {
            BackgroundColor = "rgba(0, 0, 0, 0.7)";
            _textStyle.Color = "#fff";
        }
    }
}
