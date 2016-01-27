namespace EChartsOption.Component.Timeline.Style
{
    public class CheckpointStyle
    {
        #region 字符串属性
        private string _symbol = "null";
        private string _symbolSize = "null";
        private string _color = "null";
        private string _borderColor = "null";
        private string _borderWidth = "null";

        /// <summary>
        /// 当前点symbol，默认随轴上的symbol 
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 当前点symbol大小，默认随轴上symbol大小 
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string SymbolSize
        {
            get { return _symbolSize; }
            set { _symbolSize = value; }
        }

        /// <summary>
        /// 当前点symbol颜色，默认为随当前点颜色，可指定具体颜色，如无则为'#1e90ff' 
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// <summary>
        /// 当前点symbol边线颜色 
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 当前点symbol边线宽度 
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 标签
        /// </summary>
        public TimeLineLabel Label { get; set; } 
        #endregion
    }
}
