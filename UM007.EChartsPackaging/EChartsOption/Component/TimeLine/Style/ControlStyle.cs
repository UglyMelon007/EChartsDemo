using EChartsOption.Style;

namespace EChartsOption.Component.TimeLine.Style
{
    public class ControlStyle : EChartsStyle
    {
        private string _itemSize = "15";
        private string _itemGap = "5";
        private ControlStyleNormal _normal = new ControlStyleNormal();
        private ControlStyleEmphasis _emphasis = new ControlStyleEmphasis();

        /// <summary>
        /// 按钮大小
        /// </summary>
        public string ItemSize
        {
            get { return _itemSize; }
            set { _itemSize = value; }
        }

        /// <summary>
        /// 按钮间隔
        /// </summary>
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        }

        /// <summary>
        /// 正常颜色
        /// </summary>
        public ControlStyleNormal Normal
        {
            get { return _normal; }
            set { _normal = value; }
        }

        /// <summary>
        /// 高亮颜色
        /// </summary>
        public ControlStyleEmphasis Emphasis
        {
            get { return _emphasis; }
            set { _emphasis = value; }
        }
    }
}
