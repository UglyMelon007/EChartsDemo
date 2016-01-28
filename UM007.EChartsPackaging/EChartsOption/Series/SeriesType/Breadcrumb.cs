using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 面包屑
    /// </summary>
    public class Breadcrumb
    {
        #region 字符串属性
        private string _show = "null";

        /// <summary>
        /// 是否展示面包屑
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; } 
        #endregion
    }
}
