using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 数据列表，每一个数组项为Object {}
    /// </summary>
    public class Data
    {
        #region 字符串属性
        private string _name = "null";
        private string _value = "null";

        /// <summary>
        /// 数据名称
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 数据值
        /// </summary>
        [DefaultValue("null")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 子节点，每项的属性和父节点相同
        /// </summary>
        public Data[] Children { get; set; }

        /// <summary>
        /// 标志样式
        /// </summary>
        public SeriesTreemapItemStyle ItemStyle { get; set; } 
        #endregion
    }
}
