using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class DataZoom
    {
        private string _show = "true";
        private DataZoomTitle _title = new DataZoomTitle();

        /// <summary>
        /// 是否显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 显示文本
        /// </summary>
        public DataZoomTitle Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
