using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class Restore
    {
        private string _show = "null";
        private string _title = "null";

        /// <summary>
        /// 是否显示
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 文本描述
        /// </summary>
        [DefaultValue("null")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
