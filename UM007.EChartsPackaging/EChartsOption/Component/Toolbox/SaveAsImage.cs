using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class SaveAsImage
    {
        private string _show = "true";
        private string _name = "UglyMelon007";
        private string _title = "保存为图片";
        private string _type = "png";
        private string _lang = "点击保存";

        /// <summary>
        /// 是否显示
        /// </summary>
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 图片保存的名字
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        /// 默认保存图片类型为'png'，需改为'jpeg'
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 非IE浏览器支持点击下载，有保存话术，默认是“点击保存”，可修改
        /// </summary>
        public string Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
    }
}
