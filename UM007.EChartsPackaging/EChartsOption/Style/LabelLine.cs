using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class LabelLine
    {
        private string _show = "true";

        /// <summary>
        /// 标签视觉引导线，默认显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }
    }
}
