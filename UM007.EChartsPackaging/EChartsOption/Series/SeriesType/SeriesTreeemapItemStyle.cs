using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.SeriesType
{
    public class SeriesTreeemapItemStyleBase : ItemStyleBase
    {
        #region 字符串属性
        private string _chidlBorderWidth = "null";
        private string _childBorderColor = "null";

        /// <summary>
        /// 二级边框宽度
        /// </summary>
        [DefaultValue("null")]
        public string ChildBorderWidth
        {
            get { return _chidlBorderWidth; }
            set { _chidlBorderWidth = value; }
        }

        /// <summary>
        /// 二级边框颜色
        /// </summary>
        [DefaultValue("null")]
        public string ChildBorderColor
        {
            get { return _childBorderColor; }
            set { _childBorderColor = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 面包屑
        /// </summary>
        public Breadcrumb Breadcrumb { get; set; } 
        #endregion
    }
}
