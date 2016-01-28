using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class DataView
    {
        #region 字符串属性
        private string _show = "null";
        private string _title = "null";
        private string _readOnly = "null";

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
        /// 标题
        /// </summary>
        [DefaultValue("null")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// 数据视图readOnly为false时，会出现刷新按钮，如果是自主编排的显示内容，如何翻转也请自理
        /// </summary>
        [DefaultValue("null")]
        public string ReadOnly
        {
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        #endregion

        #region 对象属性
        /// <summary>
        /// 数据视图上有三个话术，默认是['数据视图', '关闭', '刷新']，如需改写，可自定义
        /// </summary>
        public string[] Lang { get; set; }
        #endregion
    }
}
