using System.ComponentModel;
using EChartsOption.Style;

namespace EChartsOption.Series.MarkLine
{
    public class MarkLine
    {
        #region 字符串属性
        private string _clickable = "null";
        private string _symbolRotate = "null";
        private string _large = "null";
        private string _smooth = "null";
        private string _smoothness = "null";
        private string _precision = "null";

        /// <summary>
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭
        /// </summary>
        [DefaultValue("null")]
        public string Clickable
        {
            get { return _clickable; }
            set { _clickable = value; }
        }


        /// <summary>
        /// 标线起始和结束的symbol旋转控制
        /// </summary>
        [DefaultValue("null")]
        public string SymbolRotate
        {
            get { return _symbolRotate; }
            set { _symbolRotate = value; }
        }

        /// <summary>
        /// 是否启用大规模标线模式，默认关闭。 
        /// 大规模标线模式下会优化标线绘制，同个系列的的所有标线都会使用同一种样式，并且忽略标线两端 symbol 的绘制。
        /// </summary>
        [DefaultValue("null")]
        public string Large
        {
            get { return _large; }
            set { _large = value; }
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
        /// 平滑曲线弧度，smooth为true时有效，指定平滑曲线弧度
        /// </summary>
        [DefaultValue("null")]
        public string Smoothness
        {
            get { return _smoothness; }
            set { _smoothness = value; }
        }

        /// <summary>
        /// 小数精度，使用开箱即用的均线markLine时有效
        /// </summary>
        [DefaultValue("null")]
        public string Precision
        {
            get { return _precision; }
            set { _precision = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 边捆绑： 
        /// enable 是否使用边捆绑，默认关闭 
        /// maxTurningAngle 边捆绑算法参数，可选 [0, 90] 的角度，配置捆绑后的边最大拐角, 默认为 45 度 
        /// 注：捆绑算法使用 Multilevel Agglomerative Edge Bundling for Visualizing Large Graphs
        /// </summary>
        public Bundling Bundling { get; set; }

        /// <summary>
        /// 标线图形炫光特效
        /// </summary>
        public MarkLineEffect Effect { get; set; }

        /// <summary>
        /// 标线图形样式属性
        /// </summary>
        public ItemStyle ItemStyle { get; set; }

        /// <summary>
        /// 标线图形数据
        /// </summary>
        public MarkLineData[] Data { get; set; }

        public MarkLineData[,] DataGroup { get; set; }

        /// <summary>
        /// 标线起始和结束的symbol介绍类型，如果都一样，可以直接传string
        /// </summary>
        public string[] Symbol { get; set; }

        /// <summary>
        /// 标线起始和结束的symbol大小，半宽（半径）参数，如果都一样，可以直接传number或function
        /// </summary>
        public string[] SymbolSize { get; set; } 
        #endregion
    }
}
