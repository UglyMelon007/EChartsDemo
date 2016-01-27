using System.ComponentModel;
using EChartsOption.Component.Axis;
using EChartsOption.Component.DataZoom;
using EChartsOption.Component.Grid;
using EChartsOption.Component.Legend;
using EChartsOption.Component.Timeline;
using EChartsOption.Component.Title;
using EChartsOption.Component.Toolbox;
using EChartsOption.Component.Tooltip;

namespace EChartsOption
{
    public class Option
    {
        #region 公共选项
        private string _backgroundColor = "null";
        private string _renderAsImage = "null";

        private string _calculable = "null";
        private string _calculableColor = "null";
        private string _calculableHolderColor = "null";
        private string _nameConnector = "null";
        private string _valueConnector = "null";

        private string _animation = "null";
        private string _addDataAnimation = "null";
        private string _animationThreshold = "null";
        private string _animationDuration = "null";
        private string _animationDurationUpdate = "null";
        private string _animationEasing = "null";

        /// <summary>
        /// 全图默认背景
        /// </summary>
        [DefaultValue("null")]
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        /// <summary>
        /// 非IE8-支持渲染为图片
        /// </summary>
        [DefaultValue("null")]
        public string RenderAsImage
        {
            get { return _renderAsImage; }
            set { _renderAsImage = value; }
        }

        /// <summary>
        /// 是否启用拖拽重计算特性，默认关闭
        /// </summary>
        [DefaultValue("null")]
        public string Calculable
        {
            get { return _calculable; }
            set { _calculable = value; }
        }

        /// <summary>
        /// 拖拽重计算提示边框颜色
        /// </summary>
        [DefaultValue("null")]
        public string CalculableColor
        {
            get { return _calculableColor; }
            set { _calculableColor = value; }
        }

        /// <summary>
        /// 可计算占位提示颜色
        /// </summary>
        [DefaultValue("null")]
        public string CalculableHolderColor
        {
            get { return _calculableHolderColor; }
            set { _calculableHolderColor = value; }
        }

        /// <summary>
        /// 数据合并名字间连接符
        /// </summary>
        [DefaultValue("null")]
        public string NameConnector
        {
            get { return _nameConnector; }
            set { _nameConnector = value; }
        }

        /// <summary>
        /// 数据合并名字与数值间连接符
        /// </summary>
        [DefaultValue("null")]
        public string ValueConnector
        {
            get { return _valueConnector; }
            set { _valueConnector = value; }
        }

        /// <summary>
        /// 是否启用图表初始化动画，默认开启，建议IE8-关闭
        /// </summary>
        [DefaultValue("null")]
        public string Animation
        {
            get { return _animation; }
            set { _animation = value; }
        }

        /// <summary>
        /// 是否启用动态数据接口动画效果，默认开启，建议IE8-关闭
        /// </summary>
        [DefaultValue("null")]
        public string AddDataAnimation
        {
            get { return _addDataAnimation; }
            set { _addDataAnimation = value; }
        }

        /// <summary>
        /// 动画元素阀值，产生的图形原素超过2500不出动画，建议IE8-关闭
        /// </summary>
        [DefaultValue("null")]
        public string AnimationThreshold
        {
            get { return _animationThreshold; }
            set { _animationThreshold = value; }
        }

        /// <summary>
        /// 进入动画时长，单位ms
        /// </summary>
        [DefaultValue("null")]
        public string AnimationDuration
        {
            get { return _animationDuration; }
            set { _animationDuration = value; }
        }

        /// <summary>
        /// 更新动画时长，单位ms
        /// </summary>
        [DefaultValue("null")]
        public string AnimationDurationUpdate
        {
            get { return _animationDurationUpdate; }
            set { _animationDurationUpdate = value; }
        }

        /// <summary>
        /// 主元素的缓动效果
        /// </summary>
        [DefaultValue("null")]
        public string AnimationEasing
        {
            get { return _animationEasing; }
            set { _animationEasing = value; }
        }

        /// <summary>
        /// 数值系列的颜色列表，（详见color），
        /// 可配数组，eg：['#87cefa', 'rgba(123,123,123,0.5)','...']，当系列数量个数比颜色列表长度大时将循环选取
        /// </summary>
        public string[] Color { get; set; }
        #endregion

        #region 组件
        /// <summary>
        /// 直角坐标系中横轴数组（详见xAxis），数组中每一项代表一条横轴坐标轴，标准（1.0）中规定最多同时存在2条横轴
        /// </summary>
        public EChartsComponentAxis XAxis { get; set; }

        /// <summary>
        /// 直角坐标系中纵轴数组（详见yAxis），数组中每一项代表一条纵轴坐标轴，标准（1.0）中规定最多同时存在2条纵轴
        /// </summary>
        public EChartsComponentAxis YAxis { get; set; }

        /// <summary>
        /// 时间轴，每个图表最多仅有一个时间轴控件
        /// </summary>
        public EChartsComponentTimeline Timeline { get; set; }

        /// <summary>
        /// 标题，每个图表最多仅有一个标题控件
        /// </summary>
        public EChartsComponentTitle Title { get; set; }

        /// <summary>
        /// 工具箱，每个图表最多仅有一个工具箱
        /// </summary>
        public EChartsComponentToolbox Toolbox { get; set; }

        /// <summary>
        /// 提示框，鼠标悬浮交互时的信息提示
        /// </summary>
        public EChartsComponentTooltip Tooltip { get; set; }

        /// <summary>
        /// 图例，每个图表最多仅有一个图例，混搭图表共享
        /// </summary>
        public EChartsComponentLegend Legend { get; set; }

        /// <summary>
        /// 数据区域缩放,数据展现范围选择
        /// </summary>
        public EChartsComponentDataZoom DataZoom { get; set; }

        /// <summary>
        /// 直角坐标系内绘图网格
        /// </summary>
        public EChartsComponentGrid Grid { get; set; }
        #endregion

        #region 数据选项
        public Series.Series[] Series { get; set; }
        #endregion


    }
}
