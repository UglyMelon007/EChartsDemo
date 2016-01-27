using System;
using System.Text.RegularExpressions;
using EChartsOption;
using EChartsOption.Component;
using EChartsOption.Component.Axis;
using EChartsOption.Component.Legend;
using EChartsOption.Component.Title;
using EChartsOption.Component.Toolbox;
using EChartsOption.Component.Tooltip;
using EChartsOption.Series;
using EChartsOption.Series.MarkLine;
using EChartsOption.Series.MarkPoint;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UM007.EChartsPackaging.UnitTest
{
    [TestClass]
    public class EChartsOption
    {
        [TestMethod]
        public void AttributeTest()
        {
            EChartsComponent ec = new EChartsComponent();
            ec.Show = "hello";
            string json = JsonConvert.SerializeObject(ec);
            string test = json;
        }

        /// <summary>
        /// 基本属性书写基本完成
        /// 属性拼装测试
        /// </summary>
        [TestMethod]
        public void OptionTest()
        {
            Option option = new Option();
            OptionAttribute(option);
            OptionComponent(option);
            OptionSeries(option);
            string json = JsonConvert.SerializeObject(option, Newtonsoft.Json.Formatting.Indented,
                 new Newtonsoft.Json.JsonSerializerSettings
                 {
                     DefaultValueHandling = Newtonsoft.Json.DefaultValueHandling.Ignore,//去掉默认值
                     ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),//属性名字首字母小写
                 });
        }

        /// <summary>
        /// 数据项初始化
        /// </summary>
        /// <param name="option"></param>
        private void OptionSeries(Option option)
        {
            SeriesRectangle series = new SeriesRectangle { Name = "最高温度", Type = "line" };

            MarkPoint mp = new MarkPoint();
            MarkPointDataThree markPointData = new MarkPointDataThree { Type = "max", Name = "最大" };
            MarkPointDataThree markPointDataT = new MarkPointDataThree { Type = "min", Name = "最小的值" };
            mp.Data = new MarkPointData[] { markPointData, markPointDataT };
            series.MarkPoint = mp;

            MarkLine mk = new MarkLine();
            MarkLineDataThree markLineData = new MarkLineDataThree();
            MarkLineThreeData data = new MarkLineThreeData { Name = "hello", Type = "average" };
            markLineData.Data = new[] { data };
            mk.Data = new[] { markLineData };
            series.MarkLine = mk;

            SeriesDataOne seriesData = new SeriesDataOne { Value = "12" };
            series.Data = new SeriesData[] { seriesData };
            option.Series = new Series[] { series };
        }

        /// <summary>
        /// 组件初始化
        /// </summary>
        /// <param name="option"></param>
        private void OptionComponent(Option option)
        {
            EChartsComponentTitle title = new EChartsComponentTitle { Text = "hello World", Subtext = "UglyMelon007" };
            option.Title = title;

            EChartsComponentTooltip tooltip = new EChartsComponentTooltip { Trigger = "axis" };
            option.Tooltip = tooltip;

            EChartsComponentLegend legend = new EChartsComponentLegend();
            LegendData legendData = new LegendData { Name = "最高温度" };
            legend.Data = new[] { legendData };
            option.Legend = legend;

            EChartsComponentAxis xAxis = new EChartsComponentAxis { Type = "category", BoundaryGap = "false" };
            AxisData axisData = new AxisData { Value = "周一" };
            xAxis.Data = new[] { axisData };
            option.XAxis = xAxis;

            EChartsComponentAxis yAxis = new EChartsComponentAxis { Type = "value" };
            AxisLabel axisLabel = new AxisLabel { Formatter = "{value} °C" };
            yAxis.AxisLabel = axisLabel;
            option.YAxis = yAxis;

            EChartsComponentToolbox toolbox = new EChartsComponentToolbox();
            toolbox.Show = "true";
            Feature feature = new Feature();
            toolbox.Feature = feature;
            option.Toolbox = toolbox;
        }

        /// <summary>
        /// 基本属性初始化
        /// </summary>
        /// <param name="option"></param>
        private void OptionAttribute(Option option)
        {
            option.Calculable = "true";
        }
    }
}
