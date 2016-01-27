using System.ComponentModel;

namespace EChartsOption.Series.MarkLine
{
    /// <summary>
    /// 捆绑算法使用 Multilevel Agglomerative Edge Bundling for Visualizing Large Graphs
    /// </summary>
    public class Bundling
    {
        private string _enable = "null";
        private string _maxTurningAngle = "null";

        /// <summary>
        /// 是否使用边捆绑，默认关闭 
        /// </summary>
        [DefaultValue("null")]
        public string Enable
        {
            get { return _enable; }
            set { _enable = value; }
        }

        /// <summary>
        /// 边捆绑算法参数，可选 [0, 90] 的角度，配置捆绑后的边最大拐角, 默认为 45 度
        /// </summary>
        [DefaultValue("null")]
        public string MaxTurningAngle
        {
            get { return _maxTurningAngle; }
            set { _maxTurningAngle = value; }
        }
    }
}
