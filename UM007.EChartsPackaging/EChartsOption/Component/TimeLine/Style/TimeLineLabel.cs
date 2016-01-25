using EChartsOption.Style;

namespace EChartsOption.Component.TimeLine.Style
{
    public class TimeLineLabel
    {
        private string _show = "true";
        private string _rotate = "false";
        private string _formatter = "null";
        private string _interval = "auto";
        private TextStyle _textStyle = new TextStyle();

        /// <summary>
        /// 是否显示 
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 旋转角度，默认为0，不旋转，正值为逆时针，负值为顺时针，可选为：-90 ~ 90 
        /// </summary>
        public string Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        /// <summary>
        /// 挑选间隔，默认为'auto'，可选为：'auto'（自动隐藏显示不下的） | 0（全部显示） | {number} 
        /// </summary>
        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        /// <summary>
        ///  间隔名称格式器：{string}（Template） | 
        /// </summary>
        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        /// <summary>
        /// 文字样式
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        public TimeLineLabel()
        {
            _textStyle.Color = "#333";
        }
    }
}
