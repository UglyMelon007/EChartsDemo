using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Style
{
    public class ItemStyle
    {
        private ItemStyleBase _normal = new ItemStyleBase();
        private ItemStyleBase _emphasis = new ItemStyleBase();

        /// <summary>
        /// 默认样式
        /// </summary>
        public ItemStyleBase Normal
        {
            get { return _normal; }
            set { _normal = value; }
        }

        /// <summary>
        /// 强调样式
        /// </summary>
        public ItemStyleBase Emphasis
        {
            get { return _emphasis; }
            set { _emphasis = value; }
        }

        public ItemStyle()
        {
            _normal.Color = "blue";
            _emphasis.Color = "red";
        }
    }
}
