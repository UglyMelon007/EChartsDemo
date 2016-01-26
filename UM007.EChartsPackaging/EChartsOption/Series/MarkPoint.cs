using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EChartsOption.Style;

namespace EChartsOption.Series
{
    public class MarkPoint
    {
        private string _clickable = "true";
        private string _symbol = "pin";
        private string _symbolSize = "10";
        private string _symbolRotate = "null";
        private string _large = "false";
        private MarkPointEffect _effect = new MarkPointEffect();
        private ItemStyle _itemStyle = new ItemStyle();
        private MarkPointData[] _data = new MarkPointData[]();

        /// <summary>
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭
        /// </summary>
        public string Clickable
        {
            get { return _clickable; }
            set { _clickable = value; }
        }

        /// <summary>
        /// 标注类型
        /// </summary>
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        /// <summary>
        /// 标注大小
        /// </summary>
        public string SymbolSize
        {
            get { return _symbolSize; }
            set { _symbolSize = value; }
        }

        /// <summary>
        /// 标注图形旋转角度
        /// </summary>
        public string SymbolRotate
        {
            get { return _symbolRotate; }
            set { _symbolRotate = value; }
        }

        /// <summary>
        /// 是否启动大规模标注模式
        /// </summary>
        public string Large
        {
            get { return _large; }
            set { _large = value; }
        }

        /// <summary>
        /// 标注图形炫光特效: 
        /// show 是否开启，默认关闭 
        /// type 特效类型，默认为'scale'（放大），可选还有'bounce'（跳动） 
        /// loop 循环动画，默认开启, period 运动周期，无单位，值越大越慢，默认为15
        ///  scaleSize 放大倍数，以markPoint symbolSize为基准，type为scale时有效 
        /// bounceDistance 跳动距离，单位为px，type为bounce时有效 
        /// color 炫光颜色，默认跟随markPoint itemStyle定义颜色, 
        /// shadowColor 光影颜色，默认跟随color 
        /// shadowBlur 光影模糊度，默认为0 
        /// </summary>
        public MarkPointEffect Effect
        {
            get { return _effect; }
            set { _effect = value; }
        }

        /// <summary>
        /// 标注图形样式属性
        /// </summary>
        public ItemStyle ItemStyle
        {
            get { return _itemStyle; }
            set { _itemStyle = value; }
        }

        /// <summary>
        /// 标注图形数据
        /// </summary>
        public MarkPointData[] Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
