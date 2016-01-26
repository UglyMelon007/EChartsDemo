using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class MagicType
    {
        private string _show = "true";
        private string[] _type = {"line", "bar", "stack", "tiled",};
        private MagicTypeTitle _title = new MagicTypeTitle();

        //可选，可传入切换是动态修改的配置，将复写series内的数组项
        // private string option = null;

        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        public string[] Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public MagicTypeTitle Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
