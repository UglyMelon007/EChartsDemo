using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class SaveAsImage
    {
        private string _show = "null";
        private string _name = "UglyMelon007";
        private string _title = "null";
        private string _type = "null";
        private string _lang = "null";

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
        /// 图片保存的名字
        /// </summary>
        [DefaultValue("UglyMelon007")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        /// 默认保存图片类型为'png'，需改为'jpeg'
        /// </summary>
        [DefaultValue("null")]
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 非IE浏览器支持点击下载，有保存话术，默认是“点击保存”，可修改
        /// </summary>
        [DefaultValue("null")]
        public string Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
    }
}
