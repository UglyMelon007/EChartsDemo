using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class MagicTypeTitle
    {
        private string _line = "折线图切换";
        private string _bar = "柱形切换";
        private string _stack = "堆积";
        private string _tiled = "平铺";

        /// <summary>
        /// line文字描述
        /// </summary>
        public string Line
        {
            get { return _line; }
            set { _line = value; }
        }

        /// <summary>
        /// bar文字描述
        /// </summary>
        public string Bar
        {
            get { return _bar; }
            set { _bar = value; }
        }

        /// <summary>
        /// stack文字描述
        /// </summary>
        public string Stack
        {
            get { return _stack; }
            set { _stack = value; }
        }

        /// <summary>
        /// tiled文字描述
        /// </summary>
        public string Tiled
        {
            get { return _tiled; }
            set { _tiled = value; }
        }
    }
}
