using System.Web;
using System.Web.Mvc;

namespace _5951071089_ToVoNhuQuynh_Demob3API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
