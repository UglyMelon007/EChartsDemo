namespace EChartsOption.Component.Toolbox
{
    public class Feature
    {
        /// <summary>
        /// 辅助线标志
        /// </summary>
        public Mark Mark { get; set; }

        /// <summary>
        /// 框选区域缩放
        /// </summary>
        public DataZoom DataZoom { get; set; }

        /// <summary>
        /// 数据视图
        /// </summary>
        public DataView DataView { get; set; }

        /// <summary>
        /// 动态类型切换
        /// </summary>
        public MagicType MagicType { get; set; }

        /// <summary>
        /// 还原，复位原始图表
        /// </summary>
        public Restore Restore { get; set; }

        /// <summary>
        /// 保存图片（IE8-不支持）
        /// </summary>
        public SaveAsImage SaveAsImage { get; set; }
    }
}
