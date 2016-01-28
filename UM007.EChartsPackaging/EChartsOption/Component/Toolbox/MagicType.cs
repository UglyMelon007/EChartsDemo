using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class MagicType
    {
        #region 字符串属性
        private string _show = "null";
        private string _option = "null";


        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        ///可选，可传入切换是动态修改的配置，将复写series内的数组项
        /// 暂时没开放此功能
        /// </summary>
        [DefaultValue("null")]
        public string Option
        {
            get { return _option; }
            set { _option = "null"; }
        }
        
        #endregion

        #region 对象属性
        /// <summary>
        /// type : ['line', 'bar', 'stack', 'tiled']
        /// </summary>
        public string[] Type { get; set; }

        public MagicTypeTitle Title { get; set; } 
        #endregion
    }
}
