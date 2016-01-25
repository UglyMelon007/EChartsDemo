using System.Web;
using System.Web.Mvc;

namespace UM007.EChartsPackaging
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}