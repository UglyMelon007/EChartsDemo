using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class ItemStyleBase
    {
        private string _color = "null";
        private string _borderColor = "null";
        private string _borderWidth = "null";
        private string _barBorderColor = "#fff";
        private string _barBorderRadius = "0";
        private string _barBorderWidth = "0";

        private LineStyle _lineStyle = new LineStyle();
        private Label _label = new Label();
        private AreaStyle _areaStyle = new AreaStyle();
        private LabelLine _labelLine = new LabelLine();
        //private ChordStyle _chordStyle = new ChordStyle();
        //private NodeStyle _nodeStyle = new NodeStyle();
        //private LinkStyle _linkStyle = new LinkStyle();
    }
}
