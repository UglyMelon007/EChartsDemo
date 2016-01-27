using System;
using System.ComponentModel;
using log4net;

namespace EChartsOption.Component
{
    public class EChartsComponent
    {
        private readonly log4net.ILog _log = LogManager.GetLogger(typeof(EChartsComponent));
        private string _show = "null";
        private string _zlevel = "null";
        private string _z = "null";
        private string _backgroundColor = "null";

        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        [DefaultValue("null")]
        public string Show
        {
            get { return _show; }
            set { _show = value; }
        }

        /// <summary>
        /// 一级层叠控制。默认0
        /// 每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。
        /// zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        [DefaultValue("null")]
        public string ZLevel
        {
            get { return _zlevel; }
            set { _zlevel = value; }
        }

        /// <summary>
        /// 二级层叠控制。默认4
        /// 同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        [DefaultValue("null")]
        public string Z
        {
            get { return _z; }
            set { _z = value; }
        }

        /// <summary>
        /// 背景颜色，默认透明
        /// </summary>
        [DefaultValue("null")]
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }
    }
}
