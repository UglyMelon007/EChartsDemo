using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class Restore
    {
        private string _show = "true";
        private string _title = "还原";

        /// <summary>
        /// 是否显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 文本描述
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
