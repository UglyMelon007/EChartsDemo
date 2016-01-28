EChartsOption(EChars选项组装):
共分三大部分：Component（组件）、Style（各种样式）、Series（数据）
Component（组件共十一种，目前支持九种）
	1.Axis(xAxis, yAxis)
	2.DataZoom
	3.Grid
	4.Legend
	5.Timeline 时间轴（详见timeline），每个图表最多仅有一个时间轴控件
	6.Title
	7.Toolbox
	8.Tooltip
Style（各种样式）
	1.AreaStyle
	2.ItemStyle
	3.Label
	4.LabelLine
	5.LineStyle
	6.TextStyle
Series（数据）
	Series共十四种目前支持五种
		1.直角系	2.饼图
		3.仪表盘	4.漏斗图
		5.矩形树图
	数据类型共六种目前支持四种
		1.SeriesDataOne 
			[
				12, 34,
				{
					value : 56,
					tooltip:{},             //自定义特殊tooltip，仅对该item有效，详见tooltip
					itemStyle:{}            //自定义特殊itemStyle，仅对该item有效，详见itemStyle
				},
				..., 10, 23
			]
		2.SeriesDataTwo(当图表类型为scatter（散点图或气泡图）时
			[
			    {
			        value : [10, 25, 5]     //[xValue, yValue, rValue]，数组内依次为横值，纵值，大小(可选)
			    },
			    [12, 15, 1]
			    ...
			]
		3.SeriesDataThree(当图表类型为饼图时，需要说明每部分数据的名称name，可设置选中状态)
			[
			    {
			        value : 12，
			        name : 'apple'          //每部分数据的名称
			    },
			    ...
			]
		4.Data(矩形树图)
			[
				name: '三星',
				itemStyle: { },
				value: 6,
				children: [
				{
					name: 'Galaxy S4',
					value: 2
				},
				]	
			]		
			
			
	
