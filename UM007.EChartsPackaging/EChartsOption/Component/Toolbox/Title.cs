using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class Title
    {
        private string _mark = "null";
        private string _markUndo = "null";
        private string _markClear = "null";

        /// <summary>
        ///辅助线开关 
        /// </summary>
        [DefaultValue("null")]
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        /// <summary>
        /// 删除辅助线
        /// </summary>
        [DefaultValue("null")]
        public string MarkUndo
        {
            get { return _markUndo; }
            set { _markUndo = value; }
        }

        /// <summary>
        /// 清空辅助线
        /// </summary>
        [DefaultValue("null")]
        public string MarkClear
        {
            get { return _markClear; }
            set { _markClear = value; }
        }
    }
}
