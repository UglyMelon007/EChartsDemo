using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class DataView
    {
        private string _show = "true";
        private string _title = "数据视图";
        private string _readOnly = "false";
        private string[] _lang = { "数据视图", "关闭", "刷新", };

        /// <summary>
        /// 是否显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// 数据视图readOnly为false时，会出现刷新按钮，如果是自主编排的显示内容，如何翻转也请自理
        /// </summary>
        public string ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        /// <summary>
        /// 数据视图上有三个话术，默认是['数据视图', '关闭', '刷新']，如需改写，可自定义
        /// </summary>
        public string[] Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
    }
}
