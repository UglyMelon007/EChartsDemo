using EChartsOption;
using EChartsOption.Component;
using EChartsOption.Component.Axis;
using EChartsOption.Component.Legend;
using EChartsOption.Component.Title;
using EChartsOption.Component.Toolbox;
using EChartsOption.Component.Tooltip;
using EChartsOption.Series.MarkLine;
using EChartsOption.Series.MarkPoint;
using EChartsOption.Series.SeriesDataType;
using EChartsOption.Series.SeriesType;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using AxisLabel = EChartsOption.Component.Axis.AxisLabel;

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
            string json = JsonConvert.SerializeObject(option, Formatting.Indented,
                 new JsonSerializerSettings
                 {
                     DefaultValueHandling = DefaultValueHandling.Ignore,//去掉默认值
                     ContractResolver = new CamelCasePropertyNamesContractResolver(),//属性名字首字母小写
                 });
            json = json.Replace("dataGroup", "data");
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

            MarkLine ml = new MarkLine
            {
                //Data = new MarkLineData[]
                //{
                //    new MarkLineDataThree {Name = "最小", Type = "min"},
                //    new MarkLineDataThree {Name = "最大", Type = "max"},
                //    new MarkLineDataThree {Name = "平均", Type = "average"},
                //},
                DataGroup = new MarkLineData[,]
                {
                    {
                         new MarkLineDataThree {Name = "最小", Type = "min"},
                    new MarkLineDataThree {Name = "最大", Type = "max"},
                    }
                },
            };
            series.MarkLine = ml;

            series.Data = new SeriesData[]
            {
                new SeriesDataOne{Value = "12"},
                new SeriesDataOne{Value = "11"},
                new SeriesDataOne{Value = "13"},
                new SeriesDataOne{Value = "14"},
                new SeriesDataOne{Value = "12"},
                new SeriesDataOne{Value = "18"},
                new SeriesDataOne{Value = "19"},
                new SeriesDataOne{Value = "22"},
            };
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
            xAxis.Data = new[] {
                new AxisData{Value ="Monday"}, 
                new AxisData{Value ="Tuesday"},
                new AxisData{Value="Wednesday"},
                new AxisData{Value = "Thursday"},
                new AxisData{Value = "Friday"},
                new AxisData{Value = "Saturday"},
                new AxisData{Value = "Sunday"}
            };
            option.XAxis = xAxis;

            EChartsComponentAxis yAxis = new EChartsComponentAxis { Type = "value" };
            AxisLabel axisLabel = new AxisLabel { Formatter = "{value} °C" };
            yAxis.AxisLabel = axisLabel;
            option.YAxis = yAxis;

            EChartsComponentToolbox toolbox = new EChartsComponentToolbox();
            toolbox.Show = "true";
            Feature feature = new Feature();
            Mark mark = new Mark { Show = "true" };
            DataView dataView = new DataView { Show = "true", ReadOnly = "false" };
            MagicType magicType = new MagicType { Show = "true", Type = new[] { "line", "bar" } };
            Restore restore = new Restore { Show = "true" };
            SaveAsImage saveAsImage = new SaveAsImage { Show = "true" };
            feature.Mark = mark;
            feature.DataView = dataView;
            feature.MagicType = magicType;
            feature.Restore = restore;
            feature.SaveAsImage = saveAsImage;
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
