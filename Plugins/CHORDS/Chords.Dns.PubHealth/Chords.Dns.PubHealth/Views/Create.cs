﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.PubHealth.Views {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using Lpp;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    using Lpp.Dns.PubHealth;
    using Lpp.Dns.PubHealth.Models;
    
    
    public partial class Create : System.Web.Mvc.WebViewPage<Lpp.Dns.PubHealth.Models.PubHealthModel> {
        
#line hidden

        
        public Create() {
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        
        public override void Execute() {


            
            #line 2 "C:\Users\Administrator\Documents\Projects\DNS\Source\PMN-OS\trunk\Plugins\CHORDS\Chords.Dns.PubHealth\Chords.Dns.PubHealth\Views\Create.cshtml"
   
    this.Stylesheet("PubHealth.css");
    var id = Html.UniqueId();


            
            #line default
            #line hidden
WriteLiteral(@"
 
<div class=""SqlEditor ui-form"">
    <div class=""ui-form"">
        <div id='errorLocation' style=""font-size: small; color: Gray;""></div>
        <div class=""ui-groupbox"">
            <div class=""ui-groupbox-header""><span>Sql Query</span></div>
            <label>Enter the query string to execute at DataMarts</label>
            ");


            
            #line 14 "C:\Users\Administrator\Documents\Projects\DNS\Source\PMN-OS\trunk\Plugins\CHORDS\Chords.Dns.PubHealth\Chords.Dns.PubHealth\Views\Create.cshtml"
       Write(Html.TextAreaFor(m => m.SqlQuery));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>        \r\n</div>\r\n ");


        }
    }
}
