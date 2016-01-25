using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption
{
    public class Label : EChartsStyle
    {
        private string _show = "true";
        private string _position = "null";
        private string _rotate = "false";
        private string _distance = "10";
        private string _formatter = "null";
        private string _x = "null";
        private string _y = "null";
        private TextStyle _textStyle = new TextStyle();

        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        public string Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public string Formatter
        {
            get { return _formatter; }
            set { _formatter = value; }
        }

        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

    }
}
