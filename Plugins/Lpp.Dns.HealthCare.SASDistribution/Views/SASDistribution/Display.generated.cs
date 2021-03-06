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

namespace Lpp.Dns.HealthCare.SASDistribution.Views.SASDistribution
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
    using Lpp.Dns.HealthCare.SASDistribution;
    using Lpp.Dns.HealthCare.SASDistribution.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SASDistribution/Display.cshtml")]
    public partial class Display : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.SASDistribution.Models.SASDistributionModel>
    {
        public Display()
        {
        }
        public override void Execute()
        {
WriteLiteral("How ");

            
            #line 2 "..\..\Views\SASDistribution\Display.cshtml"
   
    this.Stylesheet("SASDistribution.css");
    var kilobyte = 1024;
    var megabyte = kilobyte * 1024;
    var gigabyte = megabyte * 1024;
    var formatBodySize = new Func<long, string>((size) =>
    {
        if (size > gigabyte)
        {
            return (size / gigabyte).ToString("0.00") + " Gb";
        }
        if (size > megabyte)
        {
            return (size / megabyte).ToString("0.00") + " Mb";
        }
        if (size > kilobyte)
        {
            return (size / kilobyte).ToString("0.00") + " Kb";
        }
        return size + " bytes";
    });
    var gridID = "grid_" + Html.UniqueId();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 735), Tuple.Create("\"", 747)
            
            #line 26 "..\..\Views\SASDistribution\Display.cshtml"
, Tuple.Create(Tuple.Create("", 740), Tuple.Create<System.Object, System.Int32>(gridID
            
            #line default
            #line hidden
, 740), false)
);

WriteLiteral(" class=\"DocumentGrid\"");

WriteLiteral("></div>\r\n<script>\r\n    var dataSource = ");

            
            #line 28 "..\..\Views\SASDistribution\Display.cshtml"
                Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.RequestFileList.Select(d => new { ID = d.ID, Name = d.FileName, MimeType = d.MimeType, Length = d.Size, LengthFormatted = formatBodySize(d.Size) })) + ';'));

            
            #line default
            #line hidden
WriteLiteral("\r\n    $(\'#");

            
            #line 29 "..\..\Views\SASDistribution\Display.cshtml"
   Write(gridID);

            
            #line default
            #line hidden
WriteLiteral(@"').kendoGrid({
        columns: [
            { field: 'Name', title: 'Name' },
            { field: 'MimeType', title: 'Type', width:200 },
            { field: 'LengthFormatted', title: 'Size', width: 150 },
            { field: 'ID', title: ' ', width: 110, attributes: { style: 'text-align:center;' }, template: function (item) { return '<a href=""/document/' + item.ID + '/download"">[download]</a>'; } }
        ],
        dataSource: dataSource
    });
</script> ");

        }
    }
}
#pragma warning restore 1591
