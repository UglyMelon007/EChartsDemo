using System.ComponentModel;

namespace EChartsOption.Component.Toolbox
{
    public class DataZoomTitle
    {
        private string _dataZoom = "null";
        private string _dataZoomReset = "null";

        /// <summary>
        ///区域缩放 
        /// </summary>
        [DefaultValue("null")]
        public string DataZoom
        {
            get { return _dataZoom; }
            set { _dataZoom = value; }
        }

        /// <summary>
        ///区域缩放后退 
        /// </summary>
        [DefaultValue("null")]
        public string DataZoomReset
        {
            get { return _dataZoomReset; }
            set { _dataZoomReset = value; }
        }
    }
}
