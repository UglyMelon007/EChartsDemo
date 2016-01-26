using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Title
{
    class EChartsComponentTitle : EChartsComponent
    {
        private string _text = "UglyMelon007";
        private string _link = "";
        private string _target = "blank";
        private string _subtext = "testdemo";
        private string _sublink = "";
        private string _subtarget = "blank";
        private string _x = "left";
        private string _y = "top";
        private string _textAlign = "null";
        private string _borderColor = "#ccc";
        private string _borderWidth = "0";
        private string _padding = "5";
        private string _itemGap = "5";
        private TextStyle _textStyle = new TextStyle();
        private TextStyle _subtextStyle = new TextStyle();

        /// <summary>
        /// 主标题文本，'\n'指定换行
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// 主标题文本超链接
        /// </summary>
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        /// <summary>
        /// 指定窗口打开主标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        public string Target
        {
            get { return _target; }
            set { _target = value; }
        }

        /// <summary>
        /// 副标题文本，'\n'指定换行
        /// </summary>
        public string Subtext
        {
            get { return _subtext; }
            set { _subtext = value; }
        }

        /// <summary>
        /// 副标题文本超链接
        /// </summary>
        public string Sublink
        {
            get { return _sublink; }
            set { _sublink = value; }
        }

        /// <summary>
        /// 指定窗口打开副标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        public string Subtarget
        {
            get { return _subtarget; }
            set { _subtarget = value; }
        }

        /// <summary>
        /// 水平安放位置，默认为左侧，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 水平对齐方式，默认根据x设置自动调整，可选为： left' | 'right' | 'center
        /// </summary>
        public string TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; }
        }

        /// <summary>
        /// 标题边框颜色
        /// </summary>
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 标题边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 	标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 主副标题纵向间隔，单位px，默认为5
        /// </summary>
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        }

        /// <summary>
        /// 主标题文本样式
        /// </summary>
        public TextStyle TextStyle
        {
            get { return _textStyle; }
            set { _textStyle = value; }
        }

        /// <summary>
        /// 副标题文本样式
        /// </summary>
        public TextStyle SubtextStyle
        {
            get { return _subtextStyle; }
            set { _subtextStyle = value; }
        }

        public EChartsComponentTitle()
        {
            _textStyle.FontSize = "18";
            _textStyle.FontWeight = "bolder";
            _textStyle.Color = "#333";

            _subtextStyle.Color = "#aaa";
        }
    }
}
