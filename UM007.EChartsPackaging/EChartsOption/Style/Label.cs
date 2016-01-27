using System.ComponentModel;

namespace EChartsOption.Style
{
    public class Label : EChartsStyle
    {
        #region 字符串属性
        private string _show = "null";
        private string _position = "null";
        private string _rotate = "null";
        private string _distance = "null";
        private string _formatter = "null";
        private string _x = "null";
        private string _y = "null";

        /// <summary>
        /// 标签显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 标签显示位置，地图标签不可指定位置 
        /// 饼图可选为：'outer'（外部） | 'inner'（内部）， 
        /// 漏斗图可选为：'inner'（内部）| 'left' | 'right'（默认）， 
        /// 折线图，柱形图，K线图，散点图默认根据布局自适应为'top'或者'right'，可选的还有：'inside' | 'left' | 'bottom' 
        /// 柱形图可选的还有，'insideLeft' | 'insideRight' | 'insideTop' | 'insideBottom'
        /// </summary>
        [DefaultValue("null")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// 和弦图有效，文本标签自动旋转
        /// </summary>
        [DefaultValue("null")]
        public string Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        /// <summary>
        /// 和弦图: 文本标签旋转后于弦的间隔 
        /// 饼图: 当label position为inner时有效，为label位置到圆心的距离与圆半径(环状图为内外半径和)的比例系数，默认为0.5。
        /// </summary>
        [DefaultValue("null")]
        public string Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        /// <summary>
        /// 标签文本格式器，通用
        /// </summary>
        [DefaultValue("null")]
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        /// <summary>
        /// 仅矩形树图使用，标签横坐标
        /// </summary>
        [DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 仅矩形树图使用，标签纵坐标
        /// </summary>
        [DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 标签的文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; }
        #endregion
    }
}
