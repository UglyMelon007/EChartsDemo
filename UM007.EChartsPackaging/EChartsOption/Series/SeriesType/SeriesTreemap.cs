using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据
    /// </summary>
    public class SeriesTreemap
    {
        #region 字符串属性
        private string _root = "null";

        /// <summary>
        /// 当前显示的根节点的名字
        /// </summary>
        [DefaultValue("null")]
        public string Root
        {
            get { return _root; }
            set { _root = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 中心坐标，支持绝对值（px）和百分比
        /// </summary>
        public string[] Cener { get; set; }

        /// <summary>
        /// 大小，支持绝对值（px）和百分比
        /// </summary>
        public string[] Size { get; set; }

        /// <summary>
        /// 标志样式
        /// </summary>
        public SeriesTreemapItemStyle ItemStyle { get; set; }

        /// <summary>
        /// 数据列表，每一个数组项为Object {}
        /// </summary>
        public Data[] Data { get; set; } 
        #endregion
    }
}
