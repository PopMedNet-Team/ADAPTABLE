﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.HealthCare.ESPQueryBuilder.Views.ESPQueryBuilder.Terms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns.HealthCare.Controllers;
    using Lpp.Dns.HealthCare.ESPQueryBuilder;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Models;
    using Lpp.Dns.HealthCare.ESPQueryBuilder.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ESPQueryBuilder/Terms/DisplayVisits.cshtml")]
    public partial class DisplayVisits : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.ESPQueryBuilder.Models.ESPQueryViewModel>
    {
        public DisplayVisits()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\ESPQueryBuilder\Terms\DisplayVisits.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"VisitsTerm Term panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">Visits</div>\r\n    <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 8 "..\..\Views\ESPQueryBuilder\Terms\DisplayVisits.cshtml"
   Write(Model.Base.MinVisits);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591