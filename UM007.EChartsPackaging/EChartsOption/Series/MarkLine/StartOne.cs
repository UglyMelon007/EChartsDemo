using System.ComponentModel;

namespace EChartsOption.Series.MarkLine
{
    public class StartOne
    {
        private string _name = "null";
        private string _value = "null";
        private string _x = "null";
        private string _y = "null";

        /// <summary>
        /// 名称
        /// </summary>
        [DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        [DefaultValue("null")]
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// x坐标
        /// </summary>
        [DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// y坐标
        /// </summary>
        [DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
