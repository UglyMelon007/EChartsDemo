namespace EChartsOption.Component.Toolbox
{
    public class Feature
    {
        private Mark _mark = new Mark();
        private DataZoom _dataZoom = new DataZoom();
        private DataView _dataView = new DataView();
        private MagicType _magicType = new MagicType();
        private Restore _restore = new Restore();
        private SaveAsImage _saveAsImage = new SaveAsImage();

        /// <summary>
        /// 辅助线标志
        /// </summary>
        public Mark Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        /// <summary>
        /// 框选区域缩放
        /// </summary>
        public DataZoom DataZoom
        {
            get { return _dataZoom; }
            set { _dataZoom = value; }
        }

        /// <summary>
        /// 数据视图
        /// </summary>
        public DataView DataView
        {
            get { return _dataView; }
            set { _dataView = value; }
        }

        /// <summary>
        /// 动态类型切换
        /// </summary>
        public MagicType MagicType
        {
            get { return _magicType; }
            set { _magicType = value; }
        }

        /// <summary>
        /// 还原，复位原始图表
        /// </summary>
        public Restore Restore
        {
            get { return _restore; }
            set { _restore = value; }
        }

        /// <summary>
        /// 保存图片（IE8-不支持）
        /// </summary>
        public SaveAsImage SaveAsImage
        {
            get { return _saveAsImage; }
            set { _saveAsImage = value; }
        }
    }
}
