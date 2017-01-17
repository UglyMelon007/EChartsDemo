using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    /// <summary>
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据，其中个别选项仅在部分图表类型中有效，请注意适用类型
    /// </summary>
    public class SeriesRectangle : Series
    {
        private string _stack = "null";
        private string _xAxisIndex = "null";
        private string _yAxisIndex = "null";
        private string _barGap = "null";
        private string _barCategoryGap = "null";
        private string _barMinHeight = "null";
        private int _barWidth = 1;
        private string _barMaxWidth = "null";
        private string _symbol = "null";
        private string _symbolSize = "null";
        private string _symbolRotate = "null";
        private string _showAllSymbol = "null";
        private string _smooth = "null";
        private string _dataFilter = "null";
        private string _large = "null";
        private string _largeThreshold = "null";
        private string _legendHoverLink = "null";

        /// <summary>
        /// 组合名称，双数值轴时无效，多组数据的堆积图时使用，eg：stack:'group1'，则series数组中stack值等于'group1'的数据做堆积计算
        /// </summary>
        [DefaultValue("null")]
        public string Stack
        {
            get { return _stack; }
            set { _stack = value; }
        }

        /// <summary>
        /// xAxis坐标轴数组的索引，指定该系列数据所用的横坐标轴
        /// </summary>
        [DefaultValue("null")]
        public string XAxisIndex
        {
            get { return _xAxisIndex; }
            set { _xAxisIndex = value; }
        }

        /// <summary>
        /// yAxis坐标轴数组的索引，指定该系列数据所用的纵坐标轴
        /// </summary>
        [DefaultValue("null")]
        public string YAxisIndex
        {
            get { return _yAxisIndex; }
            set { _yAxisIndex = value; }
        }

        /// <summary>
        /// 柱间距离，默认为柱形宽度的30%，可设固定值
        /// </summary>
        [DefaultValue("null")]
        public string BarGap
        {
            get { return _barGap; }
            set { _barGap = value; }
        }

        /// <summary>
        /// 类目间柱形距离，默认为类目间距的20%，可设固定值
        /// </summary>
        [DefaultValue("null")]
        public string BarCategoryGap
        {
            get { return _barCategoryGap; }
            set { _barCategoryGap = value; }
        }

        /// <summary>
        /// 柱条最小高度，可用于防止某item的值过小而影响交互
        /// </summary>
        [DefaultValue("null")]
        public string BarMinHeight
        {
            get { return _barMinHeight; }
            set { _barMinHeight = value; }
        }

        /// <summary>
        /// 柱条（K线蜡烛）宽度，不设时自适应
        /// </summary>
        [DefaultValue(1)]
        public int BarWidth
        {
            get { return _barWidth; }
            set { _barWidth = value; }
        }

        /// <summary>
        /// 柱条（K线蜡烛）最大宽度，不设时自适应
        /// </summary>
        [DefaultValue("null")]
        public string BarMaxWidth
        {
            get { return _barMaxWidth; }
            set { _barMaxWidth = value; }
        }

        /// <summary>
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        ///  'circle' | 'rectangle' | 'triangle' | 'diamond' |
        ///  'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond' 
        /// 另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星 
        /// 自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        [DefaultValue("null")]
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 标志图形大小，可计算特性启用情况建议增大以提高交互体验。可以是单个值，
        /// 如果在 symbol 为图片的时候想要分别设置宽高防止图片被拉伸，可以使用数组，其中数组第一个值是高，第二个值是宽。 
        /// 实现气泡图时symbolSize需为Function，气泡大小取决于该方法返回值，传入参数为当前数据项（value数组）。
        /// </summary>
        [DefaultValue("null")]
        public string SymbolSize
        {
            get { return _symbolSize; }
            set { _symbolSize = value; }
        }

        /// <summary>
        /// 标志图形旋转角度[-180,180]
        /// </summary>
        [DefaultValue("null")]
        public string SymbolRotate
        {
            get { return _symbolRotate; }
            set { _symbolRotate = value; }
        }

        /// <summary>
        /// 标志图形默认只有主轴显示（随主轴标签间隔隐藏策略），
        /// 如需全部显示可把showAllSymbol设为true标志图形默认只有主轴显示（随主轴标签间隔隐藏策略），
        /// 如需全部显示可把showAllSymbol设为true
        /// </summary>
        [DefaultValue("null")]
        public string ShowAllSymbol
        {
            get { return _showAllSymbol; }
            set { _showAllSymbol = value; }
        }

        /// <summary>
        /// 平滑曲线显示，smooth为true时lineStyle不支持虚线
        /// </summary>
        [DefaultValue("null")]
        public string Smooth
        {
            get { return _smooth; }
            set { _smooth = value; }
        }

        /// <summary>
        /// ECharts 会在折线图的数据数量大于实际显示的像素宽度（高度）的时候会启用优化，对显示在一个像素宽度内的数据做筛选，该选项是指明数据筛选的策略。
        ///  可选 'nearest', 'min', 'max', 'average'。或者是使用自定义的筛选函数
        /// </summary>
        [DefaultValue("null")]
        public string DataFilter
        {
            get { return _dataFilter; }
            set { _dataFilter = value; }
        }

        /// <summary>
        /// 启动大规模散点图
        /// </summary>
        [DefaultValue("null")]
        public string Large
        {
            get { return _large; }
            set { _large = value; }
        }

        /// <summary>
        /// 大规模散点图自动切换阀值，large为true下有效
        /// </summary>
        [DefaultValue("null")]
        public string LargeThreshold
        {
            get { return _largeThreshold; }
            set { _largeThreshold = value; }
        }

        /// <summary>
        /// 是否启用图例（legend）hover时的联动响应（高亮显示）
        /// </summary>
        [DefaultValue("null")]
        public string LegendHoverLink
        {
            get { return _legendHoverLink; }
            set { _legendHoverLink = value; }
        }
    }
}
