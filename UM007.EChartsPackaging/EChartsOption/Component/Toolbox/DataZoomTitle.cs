using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EChartsOption.Component.Toolbox
{
    public class DataZoomTitle
    {
        private string _dataZoom = "区域缩放";
        private string _dataZoomReset = "区域缩放后退";

        /// <summary>
        ///区域缩放 
        /// </summary>
        public string DataZoom
        {
            get { return _dataZoom; }
            set { _dataZoom = value; }
        }

        /// <summary>
        ///区域缩放后退 
        /// </summary>
        public string DataZoomReset
        {
            get { return _dataZoomReset; }
            set { _dataZoomReset = value; }
        }
    }
}
