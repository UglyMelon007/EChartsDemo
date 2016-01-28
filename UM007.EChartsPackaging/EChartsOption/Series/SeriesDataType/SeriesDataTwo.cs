namespace EChartsOption.Series.SeriesDataType
{
    /// <summary>
    /// 当图表类型为scatter（散点图或气泡图）时，其数值设置比较特殊，
    /// 他的横纵坐标轴都可能为数值型，并且气泡图时需要指定气泡大小
    /// </summary>
    public class SeriesDataTwo : SeriesData
    {
        /// <summary>
        /// [
        ///  {
        ///  value : [10, 25, 5]     //[xValue, yValue, rValue]，数组内依次为横值，纵值，大小(可选)
        ///  },
        ///  [12, 15, 1]
        ///  ]
        /// </summary>
        public string[] Data { get; set; }
    }
}
