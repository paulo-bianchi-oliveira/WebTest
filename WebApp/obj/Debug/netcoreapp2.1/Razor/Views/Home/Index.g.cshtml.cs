#pragma checksum "C:\Users\casa\Desktop\webtest-master\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97214627b1e92032857f4baac84a2cb25efe9cc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97214627b1e92032857f4baac84a2cb25efe9cc0", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\casa\Desktop\webtest-master\WebApp\Views\Home\Index.cshtml"
  

    Layout = "_Layout";

    ViewData["Title"] = "...Index Title...";


#line default
#line hidden
            BeginContext(86, 881, true);
            WriteLiteral(@"<table border=""1"">
    <tr><td>ID</td><td><input type=""text"" id=""txtId"" value=""0"" size=""10"" maxlength=""50"" readonly=""readonly"" /></td></tr>
    <tr><td>NAME</td><td><input type=""text"" id=""txtName"" value="""" size=""50"" maxlength=""50"" /></td></tr>
    <tr><td>AGE</td><td><input type=""text"" id=""txtAge"" value="""" size=""3"" maxlength=""2"" class=""positive"" /></td></tr>
    <tr><td>ADDRESS</td><td><input type=""text"" id=""txtAddr"" value="""" size=""50"" maxlength=""50"" /></td></tr>
    <tr><td><input type=""button"" value=""ADD NEW USER"" id=""btnAdd"" /></td><td><input type=""button"" value=""CLEAR FIELDS"" id=""btnCle"" /><input type=""button"" value=""DELETE USER"" id=""btnDel"" /></td></tr>
</table>
<p>CLICK ON ID FIELD TO EDIT/DELETE USER...</p><p><input type=""text"" size=""10"" maxlength=""50"" id=""txtSearch"" /><input type=""button"" id=""btnSea"" value=""SEARCH NAME"" /></p>
<div id=""ret_div""></div>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591