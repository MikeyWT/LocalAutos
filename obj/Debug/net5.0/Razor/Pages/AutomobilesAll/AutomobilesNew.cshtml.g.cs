#pragma checksum "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe6103f6e12063c177b5b44a63c1f5d22c528d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LocalAutos.Pages.AutomobilesAll.Pages_AutomobilesAll_AutomobilesNew), @"mvc.1.0.razor-page", @"/Pages/AutomobilesAll/AutomobilesNew.cshtml")]
namespace LocalAutos.Pages.AutomobilesAll
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\CIDM-3312\Lab1\LocalAutos\Pages\_ViewImports.cshtml"
using LocalAutos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6103f6e12063c177b5b44a63c1f5d22c528d5f", @"/Pages/AutomobilesAll/AutomobilesNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a596a5df0926eae1b3ad585f146967473c2dd581", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AutomobilesAll_AutomobilesNew : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./CreateAuto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AutomobilesNew", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Index</h1>\r\n<br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6103f6e12063c177b5b44a63c1f5d22c528d5f4248", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   <!--This Create New anchor will direct the user to the Create page -->\r\n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th>\r\n");
#nullable restore
#line 11 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                  
                    var firstSort = "first_asc";
                    if (Model.CurrentSort == "first_asc")
                    {
                        firstSort = "first_desc";
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6103f6e12063c177b5b44a63c1f5d22c528d5f5987", async() => {
                WriteLiteral(" ");
#nullable restore
#line 18 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                                                                  Write(Html.DisplayNameFor(model => model.AutoTwo[0].Make));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CurrentSort", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                                               WriteLiteral(firstSort);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CurrentSort"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CurrentSort", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CurrentSort"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n      <th scope=\"col\">");
#nullable restore
#line 20 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                 Write(Html.DisplayNameFor(model => model.AutoTwo[0].Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>   <!-- This will seperate the columns of the table by Make, Model, Year of Automobile, price and if the owner is Selling or Trading -->\r\n      <th scope=\"col\">");
#nullable restore
#line 21 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                 Write(Html.DisplayNameFor(model => model.AutoTwo[0].YearMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
#nullable restore
#line 22 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                 Write(Html.DisplayNameFor(model => model.AutoTwo[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th scope=\"col\">");
#nullable restore
#line 23 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                 Write(Html.DisplayNameFor(model => model.AutoTwo[0].SaleTrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 27 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
       foreach (var item in Model.AutoTwo){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 29 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
     Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 30 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
     Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>      \r\n      <td>");
#nullable restore
#line 31 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
     Write(Html.DisplayFor(modelItem => item.YearMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
     Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 33 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
     Write(Html.DisplayFor(modelItem => item.SaleTrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 35 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("     <!--The above foreach loop will cycle through the entity class and return all appropriate attributes that have been coded to return from the database. -->\r\n  </tbody>\r\n      \r\n</table>\r\n");
#nullable restore
#line 39 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
  
    var prevDisabled="";
    if(Model.PageNum <= 1)
    {
        prevDisabled = "disabled";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav aria-label=\"Page navigation example\">\r\n  <ul class=\"pagination\">\r\n    <li");
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1938, 2);
            WriteAttributeValue("", 1915, "page-item", 1915, 9, true);
#nullable restore
#line 48 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
WriteAttributeValue(" ", 1924, prevDisabled, 1925, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6103f6e12063c177b5b44a63c1f5d22c528d5f12593", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PageNum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                                                                                                 WriteLiteral(Model.PageNum - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageNum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PageNum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageNum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"page-item\"><a class=\"page-link\" href=\"#\">1</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" href=\"#\">2</a></li>\r\n    <li class=\"page-item\"><a class=\"page-link\" href=\"#\">3</a></li>\r\n    <li class=\"page-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe6103f6e12063c177b5b44a63c1f5d22c528d5f15167", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PageNum", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\CIDM-3312\Lab1\LocalAutos\Pages\AutomobilesAll\AutomobilesNew.cshtml"
                                                                                   WriteLiteral(Model.PageNum + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageNum"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PageNum", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageNum"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n  </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocalAutos.Pages.AutomobilesAll.AutoModels> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LocalAutos.Pages.AutomobilesAll.AutoModels> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LocalAutos.Pages.AutomobilesAll.AutoModels>)PageContext?.ViewData;
        public LocalAutos.Pages.AutomobilesAll.AutoModels Model => ViewData.Model;
    }
}
#pragma warning restore 1591
