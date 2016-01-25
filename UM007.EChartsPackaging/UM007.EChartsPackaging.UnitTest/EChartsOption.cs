using System;
using EChartsOption;
using EChartsOption.Component;
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
    }
}
