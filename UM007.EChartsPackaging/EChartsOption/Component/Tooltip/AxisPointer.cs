using EChartsOption.Style;

namespace EChartsOption.Component.Tooltip
{
    public class AxisPointer
    {
        #region 字符串属性
        private string _type = "null";

        /// <summary>
        /// 类型
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        } 
        #endregion

        #region 对象属性
        /// <summary>
        /// 设置十字准星指示器
        /// </summary>
        public CrossStyle CrossStyle { get; set; }

        /// <summary>
        /// 设置直线指示器
        /// </summary>
        public LineStyle LineStyle { get; set; }

        /// <summary>
        /// 设置阴影指示器
        /// </summary>
        public ShadowStyle ShadowStyle { get; set; } 
        #endregion
    }
}
