using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class DataZoom
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
        ///<summary>
        /// 显示文本
        /// </summary>
        public DataZoomTitle Title { get; set; }
        #endregion
    }
}
