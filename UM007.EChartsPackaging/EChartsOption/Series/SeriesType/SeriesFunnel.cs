using System.ComponentModel;

namespace EChartsOption.Series.SeriesType
{
    public class SeriesFunnel
    {
        private string _x = "null";
        private string _y = "null";
        private string _x2 = "null";
        private string _y2 = "null";
        private string _width = "null";
        private string _height = "null";
        private string _funnelAlign = "null";
        private string _min = "null";
        private string _max = "null";
        private string _minSize = "null";
        private string _maxSize = "null";
        private string _sort = "null";
        private string _gap = "null";
        private string _legendHoverLink = "null";

        /// <summary>
        /// 左上角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        [DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 左上角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        [DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 右下角横坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域横向中心)
        /// </summary>
        [DefaultValue("null")]
        public string X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        /// <summary>
        /// 右下角纵坐标，数值单位px，支持百分比（字符串），如'50%'(显示区域纵向中心)
        /// </summary>
        [DefaultValue("null")]
        public string Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        /// <summary>
        /// 总宽度，默认为绘图区总宽度 - x - x2，数值单位px，指定width后将忽略x2，支持百分比（字符串），如'50%'(显示区域一半的宽度)
        /// </summary>
        [DefaultValue("null")]
        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }

        /// <summary>
        /// 总高度，默认为绘图区总高度 - y - y2，数值单位px，指定height后将忽略y2，支持百分比（字符串），如'50%'(显示区域一半的高度)
        /// </summary>
        [DefaultValue("null")]
        public string Height
        {
            get { return _height; }
            set { _height = value; }
        }

        /// <summary>
        /// 水平方向对齐布局类型，默认居中对齐，可用选项还有：'left' | 'right' | 'center'
        /// </summary>
        [DefaultValue("null")]
        public string FunnelAlign
        {
            get { return _funnelAlign; }
            set { _funnelAlign = value; }
        }

        /// <summary>
        /// 指定的最小值
        /// </summary>
        [DefaultValue("null")]
        public string Min
        {
            get { return _min; }
            set { _min = value; }
        }

        /// <summary>
        /// 指定的最大值
        /// </summary>
        [DefaultValue("null")]
        public string Max
        {
            get { return _max; }
            set { _max = value; }
        }

        /// <summary>
        /// 最小值min映射到总宽度的比例，如果需要最小值的图形并不是尖端三角，可设置minSize实现
        /// </summary>
        [DefaultValue("null")]
        public string MinSize
        {
            get { return _minSize; }
            set { _minSize = value; }
        }

        /// <summary>
        /// 最大值max映射到总宽度的比例
        /// </summary>
        [DefaultValue("null")]
        public string MaxSize
        {
            get { return _maxSize; }
            set { _maxSize = value; }
        }

        /// <summary>
        /// 数据排序， 可以取ascending, descending
        /// </summary>
        [DefaultValue("null")]
        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }

        /// <summary>
        /// 数据图形间距
        /// </summary>
        [DefaultValue("null")]
        public string Gap
        {
            get { return _gap; }
            set { _gap = value; }
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
