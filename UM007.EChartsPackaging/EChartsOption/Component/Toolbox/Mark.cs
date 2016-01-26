using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Toolbox
{
    public class Mark
    {
        private string _show = "true";
        private LineStyle _lineStyle = new LineStyle();
        private Title _title = new Title();

        /// <summary>
        /// 是否显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 线条样式
        /// </summary>
        public LineStyle LineStyle
        {
            get { return _lineStyle; }
            set { _lineStyle = value; }
        }

        /// <summary>
        /// 显示文本
        /// </summary>
        public Title Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Mark()
        {
            _lineStyle.Width = "2";
            _lineStyle.Color = "#1e90ff";
            _lineStyle.Type = "dashed";
        }
    }
}
