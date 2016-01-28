using System.ComponentModel;

namespace EChartsOption.Component.Timeline.Style
{
    public class ControlStyleNormal
    {
        private string _color = "null";

        [DefaultValue("null")]
        public string Color
        {
            get { return _color;}
            set { _color = value; }
        }
    }
}
