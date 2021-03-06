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

namespace Lpp.Dns.Portal.Views.Request
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
    using Lpp.Dns;
    using Lpp.Dns.Data;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    
    #line 1 "..\..\Views\Request\List.cshtml"
    using Lpp.Dns.Portal.Views.Request;
    
    #line default
    #line hidden
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Request/List.cshtml")]
    public partial class List : System.Web.Mvc.WebViewPage<RequestListModel>
    {
        public List()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Request\List.cshtml"
   var id = Html.UniqueId(); 
            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n<div");

WriteLiteral(" class=\"RequestsPage\"");

WriteAttribute("id", Tuple.Create(" id=\"", 122), Tuple.Create("\"", 130)
            
            #line 5 "..\..\Views\Request\List.cshtml"
, Tuple.Create(Tuple.Create("", 127), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 127), false)
);

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Request\List.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Request\List.cshtml"
     if ( Model.AllProjects != null ) {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"Scroller Left\"");

WriteLiteral(">&lt;</a>\r\n");

WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"Scroller Right\"");

WriteLiteral(">&gt;</a>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"ProjectTabs\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Request\List.cshtml"
            
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Request\List.cshtml"
             foreach( var p in Model.AllProjects.StartWith( (Lpp.Dns.Data.Project) null ) ) {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-project=\"");

            
            #line 11 "..\..\Views\Request\List.cshtml"
                                      Write( p == null ? "" : p.ID.ToString() );

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                    ");

            
            #line 12 "..\..\Views\Request\List.cshtml"
               Write(Html.Raw( p == Model.Project ? "class=\"Selected\"" : "" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 12 "..\..\Views\Request\List.cshtml"
                                                                            Write( p == null ? "All Projects" : p.Name );

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 13 "..\..\Views\Request\List.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

WriteLiteral("        <script>\r\n            $(function ($) {\r\n                $(\"#");

            
            #line 17 "..\..\Views\Request\List.cshtml"
                Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > .ProjectTabs > a\").click(function () {\r\n                    var id = $(this).d" +
"ata(\"project\");\r\n                    $(\".RequestsGrid .ProjectFilterLink\").filte" +
"r(function () { return $(this).data(\"project\") == id; }).click();\r\n             " +
"       $(\"#");

            
            #line 20 "..\..\Views\Request\List.cshtml"
                    Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > .ProjectTabs > a\").removeClass(\"Selected\");\r\n                    $(this).addCl" +
"ass(\"Selected\");\r\n                    return false;\r\n                });\r\n      " +
"      });\r\n        </script>\r\n");

            
            #line 26 "..\..\Views\Request\List.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"ui-section ui-no-padding ui-has-header\"");

WriteLiteral(" title-text=\"Requests\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 28 "..\..\Views\Request\List.cshtml"
    Write(Html.Partial<ListBody>());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function() {\r\n\r\n            var root = $(\"#");

            
            #line 33 "..\..\Views\Request\List.cshtml"
                       Write(id);

            
            #line default
            #line hidden
WriteLiteral("\");\r\n            var tabs = $(\"#");

            
            #line 34 "..\..\Views\Request\List.cshtml"
                       Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > .ProjectTabs\");\r\n            var left = $(\"#");

            
            #line 35 "..\..\Views\Request\List.cshtml"
                       Write(id);

            
            #line default
            #line hidden
WriteLiteral(" > .Scroller.Left\");\r\n            var right = $(\"#");

            
            #line 36 "..\..\Views\Request\List.cshtml"
                        Write(id);

            
            #line default
            #line hidden
WriteLiteral(@" > .Scroller.Right"");

            function updateScrollers(showLeft, showRight) {
                if (showLeft === undefined) showLeft = tabs.scrollLeft() > 0;
                if (showRight === undefined) {
                    var lastTab = tabs.find(""a:last"");
                    showRight = tabs.scrollLeft() + tabs.width() < lastTab.position().left + lastTab.width();
                }

                left.toggle( showLeft );
                right.toggle( showRight );
            }
            updateScrollers();

            $(""#");

            
            #line 50 "..\..\Views\Request\List.cshtml"
            Write(id);

            
            #line default
            #line hidden
WriteLiteral(@" > .Scroller.Left"").click(function () {
                var newLeft = tabs.scrollLeft() - 100;
                tabs.scrollLeft(newLeft);
                updateScrollers(tabs.scrollLeft() <= newLeft);
                return false;
            });
            $(""#");

            
            #line 56 "..\..\Views\Request\List.cshtml"
            Write(id);

            
            #line default
            #line hidden
WriteLiteral(@" > .Scroller.Right"").click(function () {
                var newLeft = tabs.scrollLeft() + 100;
                tabs.scrollLeft(newLeft);
                updateScrollers( undefined, tabs.scrollLeft() >= newLeft );
                return false;
            });

        });
    </script>
</div>");

        }
    }
}
#pragma warning restore 1591
