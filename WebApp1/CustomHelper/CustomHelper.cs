using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.CustomHelper
{
    public static class CustomHelper
    {
        public static MvcHtmlString SubmitButon(this HtmlHelper htmlHelper, string name, object value)
        {
            string str = "<input type='submit' value='"+value+"' name='"+name+"' />";
            return new MvcHtmlString(str);
        }

        public static string strSubmitButon(this HtmlHelper htmlHelper, string name, object value)
        {
            return "<input type='submit' value='" + value + "' name='" + name + "' />";
        }
    }
}