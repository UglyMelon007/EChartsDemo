using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Component.Toolbox
{
    public class Mark
    {
        #region 字符串属性
        private string _show = "null";

        /// <summary>
        /// 是否显示
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 线条样式
        /// </summary>
        public LineStyle LineStyle { get; set; }

        /// <summary>
        /// 显示文本
        /// </summary>
        public Title Title { get; set; } 
        #endregion
    }
}
