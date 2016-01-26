namespace EChartsOption.Component.Timeline.Style
{
    public class CheckpointStyle
    {
        private string _symbol = "auto";
        private string _symbolSize = "auto";
        private string _color = "auto";
        private string _borderColor = "auto";
        private string _borderWidth = "auto";
        private TimeLineLabel _label = new TimeLineLabel();

        /// <summary>
        /// 当前点symbol，默认随轴上的symbol 
        /// </summary>
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 当前点symbol大小，默认随轴上symbol大小 
        /// </summary>
        public string SymbolSize
        {
            get { return _symbolSize; }
            set { _symbolSize = value; }
        }

        /// <summary>
        /// 当前点symbol颜色，默认为随当前点颜色，可指定具体颜色，如无则为'#1e90ff' 
        /// </summary>
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 当前点symbol边线颜色 
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 当前点symbol边线宽度 
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }
        /// <summary>
        /// 标签
        /// </summary>
        public TimeLineLabel Label
        {
            get { return _label; }
            set { _label = value; }
        }

        public CheckpointStyle()
        {
            _label.Show = "false";
            _label.TextStyle.Color = "auto";
        }
    }
}
