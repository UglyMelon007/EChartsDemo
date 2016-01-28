namespace EChartsOption.Series.SeriesType
{
    public class SeriesTreemapItemStyle
    {
         private SeriesTreeemapItemStyleBase _normal = new SeriesTreeemapItemStyleBase();
        private SeriesTreeemapItemStyleBase _emphasis = new SeriesTreeemapItemStyleBase();

        /// <summary>
        /// 默认样式
        /// </summary>
        public SeriesTreeemapItemStyleBase Normal
        {
            get { return _normal; }
            set { _normal = value; }
        }

        /// <summary>
        /// 强调样式
        /// </summary>
        public SeriesTreeemapItemStyleBase Emphasis
        {
            get { return _emphasis; }
            set { _emphasis = value; }
        }

        public SeriesTreemapItemStyle()
        {
            _normal.Color = "blue";
            _emphasis.Color = "red";
        }
    }
}
