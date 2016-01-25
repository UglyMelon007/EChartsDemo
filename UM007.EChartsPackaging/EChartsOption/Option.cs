using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption
{
    public class Option
    {
        #region 公共选项
        private string _backgroundColor = "rgba(0,0,0,0)";
        private string[] _color =
        {
            "#ff7f50", "#87cefa", "#da70d6", "#32cd32", "#6495ed", "#ff69b4", "#ba55d3",
            "#cd5c5c", "#ffa500", "#40e0d0", "#1e90ff", "#ff6347", "#7b68ee", "#00fa9a", "#ffd700", "#6b8e23", "#ff00ff",
            "#3cb371", "#b8860b", "#30e0e0",
        };
        private string _renderAsImage = "false";

        private string _calculable = "true";
        private string _calculableColor = "rgba(255, 203, 212, 0.8)";
        private string _calculableHolderColor = "#CDA1A2";
        private string _nameConnector = "&";
        private string _valueConnector = "-";

        private string _animation = "true";
        private string _addDataAnimation = "true";
        private string _animationThreshold = "2500";
        private string _animationDuration = "2000";
        private string _animationDurationUpdate = "500";
        private string _animationEasing = "Linear";

        /// <summary>
        /// 全图默认背景
        /// </summary>
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        /// <summary>
        /// 数值系列的颜色列表，（详见color），
        /// 可配数组，eg：['#87cefa', 'rgba(123,123,123,0.5)','...']，当系列数量个数比颜色列表长度大时将循环选取
        /// </summary>
        public string[] Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 非IE8-支持渲染为图片
        /// </summary>
        public string RenderAsImage
        {
            get { return _renderAsImage; }
            set { _renderAsImage = value; }
        }

        /// <summary>
        /// 是否启用拖拽重计算特性，默认关闭
        /// </summary>
        public string Calculable
        {
            get { return _calculable; }
            set { _calculable = value; }
        }

        /// <summary>
        /// 拖拽重计算提示边框颜色
        /// </summary>
        public string CalculableColor
        {
            get { return _calculableColor; }
            set { _calculableColor = value; }
        }

        /// <summary>
        /// 可计算占位提示颜色
        /// </summary>
        public string CalculableHolderColor
        {
            get { return _calculableHolderColor; }
            set { _calculableHolderColor = value; }
        }

        /// <summary>
        /// 数据合并名字间连接符
        /// </summary>
        public string NameConnector
        {
            get { return _nameConnector; }
            set { _nameConnector = value; }
        }

        /// <summary>
        /// 数据合并名字与数值间连接符
        /// </summary>
        public string ValueConnector
        {
            get { return _valueConnector; }
            set { _valueConnector = value; }
        }

        /// <summary>
        /// 是否启用图表初始化动画，默认开启，建议IE8-关闭
        /// </summary>
        public string Animation
        {
            get { return _animation; }
            set { _animation = value; }
        }

        /// <summary>
        /// 是否启用动态数据接口动画效果，默认开启，建议IE8-关闭
        /// </summary>
        public string AddDataAnimation
        {
            get { return _addDataAnimation; }
            set { _addDataAnimation = value; }
        }

        /// <summary>
        /// 动画元素阀值，产生的图形原素超过2500不出动画，建议IE8-关闭
        /// </summary>
        public string AnimationThreshold
        {
            get { return _animationThreshold; }
            set { _animationThreshold = value; }
        }

        /// <summary>
        /// 进入动画时长，单位ms
        /// </summary>
        public string AnimationDuration
        {
            get { return _animationDuration; }
            set { _animationDuration = value; }
        }

        /// <summary>
        /// 更新动画时长，单位ms
        /// </summary>
        public string AnimationDurationUpdate
        {
            get { return _animationDurationUpdate; }
            set { _animationDurationUpdate = value; }
        }

        /// <summary>
        /// 主元素的缓动效果
        /// </summary>
        public string AnimationEasing
        {
            get { return _animationEasing; }
            set { _animationEasing = value; }
        } 
        #endregion

        #region 数据选项
        private 
        #endregion
    }
}
