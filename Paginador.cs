using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using X.PagedList;
using X.PagedList.Mvc;
using X.PagedList.Mvc.Common;

namespace Application.Models
{
    public static class Paginador<T> where T : class
    {
        public static void Setup(TempDataDictionary tempData, IEnumerable<T> t, int? page)
        {
            int pageNumer = page ?? 1;
            tempData["paginador"] = t.ToPagedList(pageNumer, 10);
        }

        public static PagedList<T> Get(TempDataDictionary tempData)
        {
            return (PagedList<T>)tempData["paginador"];
        }

        public static HtmlString Paginar(IPagedList<T> paged, Func<int, string> pam)
        {
            return X.PagedList.Mvc.HtmlHelper.PagedListPager(new System.Web.Mvc.HtmlHelper<T>(new ViewContext(), new ViewPage()), paged, pam, new PagedListRenderOptionsBase()
            {
                LiElementClasses = new string[] { "page-item" },
                PageClasses = new string[] { "page-link" }
            });
        }
    }
}