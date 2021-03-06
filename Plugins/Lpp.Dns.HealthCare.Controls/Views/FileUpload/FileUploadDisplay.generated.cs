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

namespace Lpp.Dns.HealthCare.Views.FileUpload
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
    using Lpp.Dns.General.CriteriaGroup;
    using Lpp.Dns.General.CriteriaGroup.Models;
    using Lpp.Dns.HealthCare;
    using Lpp.Dns.HealthCare.Controllers;
    using Lpp.Dns.HealthCare.Models;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Utilities.Legacy;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FileUpload/FileUploadDisplay.cshtml")]
    public partial class FileUploadDisplay : System.Web.Mvc.WebViewPage<Lpp.Dns.HealthCare.Models.FileUploadModel>
    {
        public FileUploadDisplay()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\FileUpload\FileUploadDisplay.cshtml"
   
    this.Stylesheet("FileUpload.css");
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
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 703), Tuple.Create("\"", 715)
            
            #line 25 "..\..\Views\FileUpload\FileUploadDisplay.cshtml"
, Tuple.Create(Tuple.Create("", 708), Tuple.Create<System.Object, System.Int32>(gridID
            
            #line default
            #line hidden
, 708), false)
);

WriteLiteral(" class=\"DocumentGrid\"");

WriteLiteral("></div>\r\n<script>\r\n    var dataSource = ");

            
            #line 27 "..\..\Views\FileUpload\FileUploadDisplay.cshtml"
                Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.RequestFileList.Select(d => new { Name = d.FileName, MimeType = d.MimeType, Length = d.Size, LengthFormatted = formatBodySize(d.Size), ID = d.ID })) + ';'));

            
            #line default
            #line hidden
WriteLiteral("\r\n    $(\'#");

            
            #line 28 "..\..\Views\FileUpload\FileUploadDisplay.cshtml"
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
</script>
<br");

WriteLiteral(" class=\"clear\"");

WriteLiteral("/>");

        }
    }
}
#pragma warning restore 1591
