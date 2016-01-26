using EChartsOption.Component.Tooltip;
using EChartsOption.Style;

namespace EChartsOption.Series
{
    public class Series
    {
        private string _zlevel = "0";
        private string _z = "0";
        private string _type = "null";
        private string _name = "null";
        private string _clickable = "true";
        private ItemStyle _itemStyle = new ItemStyle();
        private EChartsComponentTooltip _tooltip = new EChartsComponentTooltip();
        private MarkPoint _markPoint = new MarkPoint();
        private MarkLine _markLine = new MarkLine();
    }
}
