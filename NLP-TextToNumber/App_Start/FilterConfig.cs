using System.Web;
using System.Web.Mvc;

namespace NLP_TextToNumber
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
