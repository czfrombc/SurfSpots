#pragma checksum "C:\Users\czfro_jam\Desktop\C#_Surf_Project\SurfSpots\SurfSpots\Pages\Breaks\Forecast.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3546ce4d6e50a5d98a53742e011272304b8e8cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SurfSpots.Pages.Breaks.Pages_Breaks_Forecast), @"mvc.1.0.razor-page", @"/Pages/Breaks/Forecast.cshtml")]
namespace SurfSpots.Pages.Breaks
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
#line 1 "C:\Users\czfro_jam\Desktop\C#_Surf_Project\SurfSpots\SurfSpots\Pages\_ViewImports.cshtml"
using SurfSpots;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{surfBreakId:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3546ce4d6e50a5d98a53742e011272304b8e8cc6", @"/Pages/Breaks/Forecast.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2db0fd5ed6777ca7bc1e41e0bb964324e8d589", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Breaks_Forecast : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\czfro_jam\Desktop\C#_Surf_Project\SurfSpots\SurfSpots\Pages\Breaks\Forecast.cshtml"
  
    ViewData["Title"] = "Forecast";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2> Current Conditions and Forecast </h2>\r\n<h2> ");
#nullable restore
#line 8 "C:\Users\czfro_jam\Desktop\C#_Surf_Project\SurfSpots\SurfSpots\Pages\Breaks\Forecast.cshtml"
Write(Model.SurfBreak.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h1> The API key is ");
#nullable restore
#line 9 "C:\Users\czfro_jam\Desktop\C#_Surf_Project\SurfSpots\SurfSpots\Pages\Breaks\Forecast.cshtml"
               Write(Model.RegisteredId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<a href=\"http://magicseaweed.com\"><img src=\"https://im-1-uk.msw.ms/msw_powered_by.png\"></a>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3546ce4d6e50a5d98a53742e011272304b8e8cc64249", async() => {
                WriteLiteral(" All Surf Breaks");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurfBreaks.Pages.Breaks.ForecastModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurfBreaks.Pages.Breaks.ForecastModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SurfBreaks.Pages.Breaks.ForecastModel>)PageContext?.ViewData;
        public SurfBreaks.Pages.Breaks.ForecastModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
