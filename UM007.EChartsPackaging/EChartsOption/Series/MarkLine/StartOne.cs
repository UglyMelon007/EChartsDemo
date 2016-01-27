namespace EChartsOption.Series.MarkLine
{
    public class StartOne
    {
        private string _name = "";
        private string _value = "";
        private string _x = "";
        private string _y = "";

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// x坐标
        /// </summary>
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// y坐标
        /// </summary>
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
