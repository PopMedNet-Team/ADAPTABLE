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

namespace Lpp.Dns.HealthCare.DataChecker.Views
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
    
    #line 1 "..\..\Views\DispensingRxAmtResponse.cshtml"
    using Lpp.Mvc;
    
    #line default
    #line hidden
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DispensingRxAmtResponse.cshtml")]
    public partial class DispensingRxAmtResponse : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.DataChecker.Models.ResponseModel>
    {
        public DispensingRxAmtResponse()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!--[if lt IE 9]><script type=\"text/javascript\" src=\"/scripts/excanvas.js\"></scri" +
"pt><![endif]-->\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/jquery.jqplot.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.barRenderer.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.pieRenderer.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.categoryAxisRenderer.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.canvasAxisLabelRenderer.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.canvasAxisTickRenderer.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.canvasTextRenderer.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.pointLabels.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/scripts/jqplot/plugins/jqplot.highlighter.js\"");

WriteLiteral("></script>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 857), Tuple.Create("\"", 904)
            
            #line 14 "..\..\Views\DispensingRxAmtResponse.cshtml"
, Tuple.Create(Tuple.Create("", 863), Tuple.Create<System.Object, System.Int32>(this.Resource("datachecker.charting.js")
            
            #line default
            #line hidden
, 863), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 998), Tuple.Create("\"", 1041)
            
            #line 16 "..\..\Views\DispensingRxAmtResponse.cshtml"
, Tuple.Create(Tuple.Create("", 1004), Tuple.Create<System.Object, System.Int32>(this.Resource("responses.common.js")
            
            #line default
            #line hidden
, 1004), false)
);

WriteLiteral("></script>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 1061), Tuple.Create("\"", 1122)
            
            #line 17 "..\..\Views\DispensingRxAmtResponse.cshtml"
, Tuple.Create(Tuple.Create("", 1067), Tuple.Create<System.Object, System.Int32>(this.Resource("ViewModels/DispensingRxAmtResponse.js")
            
            #line default
            #line hidden
, 1067), false)
);

WriteLiteral("></script>\r\n");

WriteLiteral("\r\n\r\n");

            
            #line 20 "..\..\Views\DispensingRxAmtResponse.cshtml"
  
    Html.Stylesheet("/scripts/jqplot/jquery.jqplot.css");
    this.Stylesheet("datachecker.responses.css");
    if (Model.IsExternalView)
    {
        this.Stylesheet(CssMediaType.screen | CssMediaType.print, "datachecker.responses.external.css");
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div ");

            
            #line 29 "..\..\Views\DispensingRxAmtResponse.cshtml"
Write(Html.Section( title: "Response", cssClass: "ui-form", settingsKey: "ResponseContainer" ));

            
            #line default
            #line hidden
WriteLiteral(" id=\"ResponseContainer\">\r\n    <div");

WriteLiteral(" id=\"ResponseViewHeader\"");

WriteLiteral(">\r\n");

            
            #line 31 "..\..\Views\DispensingRxAmtResponse.cshtml"
        
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\DispensingRxAmtResponse.cshtml"
         if (Model.IsExternalView == false)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" data-bind=\"click: function() { window.open(\'/response/");

            
            #line 33 "..\..\Views\DispensingRxAmtResponse.cshtml"
                                                                                       Write(Model.RequestID);

            
            #line default
            #line hidden
WriteLiteral("/external/");

            
            #line 33 "..\..\Views\DispensingRxAmtResponse.cshtml"
                                                                                                                 Write(Model.ResponseToken);

            
            #line default
            #line hidden
WriteLiteral("\') }\"");

WriteLiteral(" id=\"btnOpenExternal\"");

WriteLiteral(" class=\"open-external btn btn-default\"");

WriteLiteral("><img");

WriteLiteral(" data-bind=\"click: function() { window.open(\'/response/");

            
            #line 33 "..\..\Views\DispensingRxAmtResponse.cshtml"
                                                                                                                                                                                                                                                                 Write(Model.RequestID);

            
            #line default
            #line hidden
WriteLiteral("/external/");

            
            #line 33 "..\..\Views\DispensingRxAmtResponse.cshtml"
                                                                                                                                                                                                                                                                                           Write(Model.ResponseToken);

            
            #line default
            #line hidden
WriteLiteral("\') }\"");

WriteLiteral(" src=\"/content/img/icons/open_in_new_window.png\"");

WriteLiteral(" height=\"24\"");

WriteLiteral(" alt=\"Open results in a new window.\"");

WriteLiteral(" /></a>\r\n");

            
            #line 34 "..\..\Views\DispensingRxAmtResponse.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <select");

WriteLiteral(" id=\"metric_select\"");

WriteLiteral(" class=\"responseview_selector\"");

WriteLiteral(" data-bind=\"options: Metrics, optionsText: \'title\', value: SelectedMetric\"");

WriteLiteral("></select>\r\n        <h2");

WriteLiteral(" data-bind=\"text:SelectedMetric().title\"");

WriteLiteral("></h2>\r\n    </div>\r\n    \r\n    <div");

WriteLiteral(" id=\"rxamt_overall\"");

WriteLiteral(" class=\"metricview\"");

WriteLiteral(" data-bind=\"visible: (SelectedMetric().value == 0)\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" data-bind=\"visible:HasResults\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" style=\"width:35%\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">RXAmt</th>\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">n</th>\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">%</th>\r\n                    </tr>\r\n                </thead>\r\n                <tb" +
"ody");

WriteLiteral(" data-bind=\"foreach: OverallMetrics\"");

WriteLiteral(">\r\n                    <tr>\r\n                        <td");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(" data-bind=\"text: RxAmt_Display\"");

WriteLiteral("></td>\r\n                        <td");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(" data-bind=\"text: n\"");

WriteLiteral(" class=\"number\"");

WriteLiteral("></td>\r\n                        <td");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(" data-bind=\"text: Percent\"");

WriteLiteral(" class=\"percent\"");

WriteLiteral("></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>" +
"\r\n            <div");

WriteLiteral(" id=\"OverallMetricsChart\"");

WriteLiteral(" class=\"overallmetric_barchart\"");

WriteLiteral("></div>\r\n            <p>*Selected data partners include: <span");

WriteLiteral(" data-bind=\"text: DataPartners.join(\', \')\"");

WriteLiteral("></span></p>\r\n            <br />\r\n            <div");

WriteLiteral(" id=\"OverallMetricsPieChart\"");

WriteLiteral(" class=\"overallmetric_piechart\"");

WriteLiteral("></div>\r\n            <p>*Selected data partners include: <span");

WriteLiteral(" data-bind=\"text: DataPartners.join(\', \')\"");

WriteLiteral("></span></p>\r\n        </div> \r\n        <p");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" style=\"text-align:center;\"");

WriteLiteral(" data-bind=\"visible:HasResults == false\"");

WriteLiteral(">No results were found for the specified criteria.</p>      \r\n    </div>\r\n\r\n    <" +
"div");

WriteLiteral(" id=\"rxamt_countbydp\"");

WriteLiteral(" class=\"metricview\"");

WriteLiteral(" data-bind=\"visible: (SelectedMetric().value == 1)\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" data-bind=\"visible:HasResults\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" style=\"width:100%;\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">RxAmt</th>\r\n                        <!-- ko foreach: DataPartners -->\r\n         " +
"               <th");

WriteLiteral(" data-bind=\"text: $data\"");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral("></th>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n        " +
"            <tr>\r\n                        <th></th>\r\n                        <!-" +
"- ko foreach: DataPartners -->\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">N</th>\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">%</th>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n       " +
"         </thead>\r\n                <tbody");

WriteLiteral(" data-bind=\"foreach: PartnersByCode\"");

WriteLiteral(">\r\n                    <tr>\r\n                        <td");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(" data-bind=\"text: RxAmt_Display\"");

WriteLiteral("></td>\r\n                        <!-- ko foreach: { data: Partners, as: \'partner\'}" +
" -->\r\n                        <td");

WriteLiteral(" data-bind=\"text: partner.Count\"");

WriteLiteral(" class=\"numbers\"");

WriteLiteral("></td>\r\n                        <td");

WriteLiteral(" data-bind=\"text: $root.toPercent(partner.Count, partner.Total)\"");

WriteLiteral(" class=\"percent\"");

WriteLiteral("></td>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n        " +
"        </tbody>\r\n            </table>\r\n\r\n            <div");

WriteLiteral(" id=\"DataPartnerMetricsPercent\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" id=\"DataPartnersMetricsPie\"");

WriteLiteral("></div>\r\n        </div> \r\n        <p");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" style=\"text-align:center;\"");

WriteLiteral(" data-bind=\"visible:HasResults == false\"");

WriteLiteral(">No results were found for the specified criteria.</p> \r\n    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"rxamt_percentcontribution\"");

WriteLiteral(" class=\"metricview\"");

WriteLiteral(" data-bind=\"visible: (SelectedMetric().value == 2)\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" data-bind=\"visible:HasResults\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" style=\"width:100%;\"");

WriteLiteral(">\r\n                <thead>\r\n                    <tr>\r\n                        <th" +
"");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">RxAmt</th>\r\n                        <!-- ko foreach: DataPartners -->\r\n         " +
"               <th");

WriteLiteral(" data-bind=\"text: $data\"");

WriteLiteral(" colspan=\"2\"");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral("></th>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n        " +
"            <tr>\r\n                        <th></th>\r\n                        <!-" +
"- ko foreach: DataPartners -->\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">N</th>\r\n                        <th");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(">%</th>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n       " +
"         </thead>\r\n                <tbody");

WriteLiteral(" data-bind=\"foreach: { data: PartnersByCode, as: \'item\' }\"");

WriteLiteral(">\r\n                    <tr>\r\n                        <td");

WriteLiteral(" style=\"text-align:right;\"");

WriteLiteral(" data-bind=\"text: item.RxAmt_Display\"");

WriteLiteral("></td>\r\n                        <!-- ko foreach: { data: item.Partners, as: \'part" +
"ner\'} -->\r\n                        <td");

WriteLiteral(" data-bind=\"text: partner.Count\"");

WriteLiteral(" class=\"numbers\"");

WriteLiteral("></td>\r\n                        <td");

WriteLiteral(" data-bind=\"text: $root.toPercent(partner.Count, item.Total)\"");

WriteLiteral(" class=\"percent\"");

WriteLiteral("></td>\r\n                        <!-- /ko -->\r\n                    </tr>\r\n        " +
"        </tbody>\r\n            </table>\r\n            <div");

WriteLiteral(" id=\"PercentDataPartnerContribution\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" id=\"PercentDataPartnerContribution_Pie\"");

WriteLiteral("></div>\r\n        </div> \r\n        <p");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" style=\"text-align:center;\"");

WriteLiteral(" data-bind=\"visible:HasResults == false\"");

WriteLiteral(">No results were found for the specified criteria.</p> \r\n    </div>\r\n\r\n</div>\r\n\r\n" +
"<script>\r\n    $(function () {\r\n        var model = ");

            
            #line 139 "..\..\Views\DispensingRxAmtResponse.cshtml"
               Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n        DataChecker.RxAmt.init(model, $(\'#ResponseContainer\'));\r\n    });\r\n</sc" +
"ript>");

        }
    }
}
#pragma warning restore 1591
