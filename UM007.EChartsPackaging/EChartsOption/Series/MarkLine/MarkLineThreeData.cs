using System.ComponentModel;

namespace EChartsOption.Series.MarkLine
{
    public class MarkLineThreeData
    {
        private string _type = "null";
        private string _name = "null";

        /// <summary>
        /// 标注类型
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 标注名字
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
