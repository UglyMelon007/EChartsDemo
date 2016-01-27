using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Component.Title
{
    public class EChartsComponentTitle : EChartsComponent
    {
        #region 字符串属性
        private string _text = "null";
        private string _link = "null";
        private string _target = "null";
        private string _subtext = "null";
        private string _sublink = "null";
        private string _subtarget = "null";
        private string _x = "null";
        private string _y = "null";
        private string _textAlign = "null";
        private string _borderColor = "null";
        private string _borderWidth = "null";
        private string _padding = "null";
        private string _itemGap = "null";

        /// <summary>
        /// 主标题文本，'\n'指定换行
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// 主标题文本超链接
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }

        /// <summary>
        /// 指定窗口打开主标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Target
        {
            get { return _target; }
            set { _target = value; }
        }

        /// <summary>
        /// 副标题文本，'\n'指定换行
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Subtext
        {
            get { return _subtext; }
            set { _subtext = value; }
        }

        /// <summary>
        /// 副标题文本超链接
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Sublink
        {
            get { return _sublink; }
            set { _sublink = value; }
        }

        /// <summary>
        /// 指定窗口打开副标题超链接，支持'self' | 'blank'，不指定等同为'blank'（新窗口）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Subtarget
        {
            get { return _subtarget; }
            set { _subtarget = value; }
        }

        /// <summary>
        /// 水平安放位置，默认为左侧，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// 水平对齐方式，默认根据x设置自动调整，可选为： left' | 'right' | 'center
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string TextAlign
        {
            get { return _textAlign; }
            set { _textAlign = value; }
        }

        /// <summary>
        /// 标题边框颜色
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        /// <summary>
        /// 标题边框线宽，单位px，默认为0（无边框）
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string BorderWidth
        {
            get { return _borderWidth; }
            set { _borderWidth = value; }
        }

        /// <summary>
        /// 	标题内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string Padding
        {
            get { return _padding; }
            set { _padding = value; }
        }

        /// <summary>
        /// 主副标题纵向间隔，单位px，默认为5
        /// </summary>
        [System.ComponentModel.DefaultValue("null")]
        public string ItemGap
        {
            get { return _itemGap; }
            set { _itemGap = value; }
        }
        
        #endregion

        #region 对象属性
        /// <summary>
        /// 主标题文本样式
        /// </summary>
        public TextStyle TextStyle { get; set; }

        /// <summary>
        /// 副标题文本样式
        /// </summary>
        public TextStyle SubtextStyle { get; set; } 
        #endregion

    }
}
