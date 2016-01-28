using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class AxisLabel
    {
        #region 字符串属性
        private string _show = "null";
        private string _interval = "null";
        private string _rotate = "null";
        private string _margin = "null";
        private string _clickable = "null";
        private string _formatter = "null";

        /// <summary>
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 标签显示挑选间隔，默认为'auto'，可选为： 
        /// 'auto'（自动隐藏显示不下的） | 0（全部显示） | 
        /// {number}（用户指定选择间隔） 
        /// {function}函数回调，传递参数[index，data[index]]，返回true显示，返回false隐藏
        /// </summary>
        [DefaultValue("null")]
        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        /// <summary>
        /// 标签旋转角度，默认为0，不旋转，正值为逆时针，负值为顺时针，可选为：-90 ~ 90
        /// </summary>
        [DefaultValue("null")]
        public string Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        /// <summary>
        /// 坐标轴文本标签与坐标轴的间距，默认为8，单位px
        /// </summary>
        [DefaultValue("null")]
        public string Margin
        {
            get { return _margin; }
            set { _margin = value; }
        }

        /// <summary>
        /// 坐标轴文本标签是否可点击
        /// </summary>
        [DefaultValue("null")]
        public string Clickable
        {
            get { return _clickable; }
            set { _clickable = value; }
        }

        /// <summary>
        /// 间隔名称格式器
        /// </summary>
        [DefaultValue("null")]
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        #endregion

        #region 对象属性
        /// <summary>
        /// 文本样式，其中当坐标轴为数值型和时间型时，color接受方法回调，实现个性化的颜色定义
        /// </summary>
        public TextStyle TextStyle { get; set; }
        #endregion
    }
}
