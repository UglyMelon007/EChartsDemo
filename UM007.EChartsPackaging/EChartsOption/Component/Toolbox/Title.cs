using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class Title
    {
        private string _mark = "辅助线开关";
        private string _markUndo = "删除辅助线";
        private string _markClear = "清空辅助线";

        /// <summary>
        ///辅助线开关 
        /// </summary>
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }

        /// <summary>
        /// 删除辅助线
        /// </summary>
        public string MarkUndo
        {
            get { return _markUndo; }
            set { _markUndo = value; }
        }

        /// <summary>
        /// 清空辅助线
        /// </summary>
        public string MarkClear
        {
            get { return _markClear; }
            set { _markClear = value; }
        }
    }
}
