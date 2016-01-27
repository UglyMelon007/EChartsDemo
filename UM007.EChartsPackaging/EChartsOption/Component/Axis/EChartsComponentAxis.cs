using EChartsOption.Style;

namespace EChartsOption.Component.Axis
{
    public class EChartsComponentAxis : EChartsComponent
    {
        #region 属性字符串
        private string _type = "null";
        private string _position = "null";
        private string _name = "null";
        private string _nameLocation = "null";
        private string _boundaryGap = "null";
        private string _min = "null";
        private string _max = "null";
        private string _scale = "null";
        private string _splitNumber = "null";
        private string _logLabelBase = "null";
        private string _logPositive = "null";

        /// <summary>
        /// 坐标轴类型，横轴默认为类目型'category'，纵轴默认为数值型'value',可选为'category' | 'value' | 'time' | 'log'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 坐标轴类型，横轴默认为类目型'bottom'，纵轴默认为数值型'left'，可选为：'bottom' | 'top' | 'left' | 'right'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// 坐标轴名称，默认为空
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// 坐标轴名称位置，默认为'end'，可选为：'start' | 'end'
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string NameLocation
        {
            get { return _nameLocation; }
            set { _nameLocation = value; }
        }

        /// <summary>
        /// 类目起始和结束两端空白策略，见下图，默认为true留空，false则顶头
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BoundaryGap
        {
            get { return _boundaryGap; }
            set { _boundaryGap = value; }
        }

        /// <summary>
        /// 指定的最小值，eg: 0，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[0]
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Min
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        /// 指定的最大值，eg: 100，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[1]
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        /// 脱离0值比例，放大聚焦到最终_min，_max区间
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        /// <summary>
        /// 分割段数，不指定时根据min、max算法调整
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string SplitNumber
        {
            get { return _splitNumber; }
            set { _splitNumber = value; }
        }

        /// <summary>
        /// 	axis.type === 'log'时生效。指定时，axisLabel显示为指数形式，如指定为4时，axisLabel可显示为4²、4³。不指定时，显示为普通形式，如 1,000,000
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string LogLabelBase
        {
            get { return _logLabelBase; }
            set { _logLabelBase = value; }
        }

        /// <summary>
        /// axis.type === 'log'时生效。指明是否使用反向log数轴（从而支持value为负值）。默认自适应，即如果value全为负值，则logPositive自动设为false，否则为true。
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string LogPositive
        {
            get { return _logPositive; }
            set { _logPositive = value; }
        }
        #endregion

        #region 对象属性
        /// <summary>
        /// 坐标轴名称文字样式，默认取全局配置，颜色跟随axisLine主色，可设
        /// </summary>
        public TextStyle TextStyle { get; set; }

        /// <summary>
        /// 坐标轴线，默认显示
        /// </summary>
        public AxisLine AxisLine { get; set; }

        /// <summary>
        /// 坐标轴小标记，默认不显示
        /// </summary>
        public AxisTick AxisTick { get; set; }

        /// <summary>
        /// 坐标轴文本标签
        /// </summary>
        public AxisLabel AxisLabel { get; set; }

        /// <summary>
        /// 分隔线，默认显示
        /// </summary>
        public SplitLine SplitLine { get; set; }

        /// <summary>
        /// 分隔区域，默认不显示
        /// </summary>
        public SplitArea SplitArea { get; set; }

        /// <summary>
        /// 类目列表，同时也是label内容
        /// </summary>
        public AxisData[] Data { get; set; }
        #endregion
    }
}
