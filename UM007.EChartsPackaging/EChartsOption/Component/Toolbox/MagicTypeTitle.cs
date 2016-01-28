using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class MagicTypeTitle
    {
        private string _line = "null";
        private string _bar = "null";
        private string _stack = "null";
        private string _tiled = "null";

        /// <summary>
        /// line文字描述
        /// </summary>
        [DefaultValue("null")]
        public string Line
        {
            get { return _line; }
            set { _line = value; }
        }

        /// <summary>
        /// bar文字描述
        /// </summary>
        [DefaultValue("null")]
        public string Bar
        {
            get { return _bar; }
            set { _bar = value; }
        }

        /// <summary>
        /// stack文字描述
        /// </summary>
        [DefaultValue("null")]
        public string Stack
        {
            get { return _stack; }
            set { _stack = value; }
        }

        /// <summary>
        /// tiled文字描述
        /// </summary>
        [DefaultValue("null")]
        public string Tiled
        {
            get { return _tiled; }
            set { _tiled = value; }
        }
    }
}
