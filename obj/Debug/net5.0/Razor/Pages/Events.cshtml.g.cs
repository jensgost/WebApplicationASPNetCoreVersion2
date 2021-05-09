#pragma checksum "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b209981f2ac6e281e9982636661d0a49082b4cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplicationASPNetCoreVersion2.Pages.Pages_Events), @"mvc.1.0.razor-page", @"/Pages/Events.cshtml")]
namespace WebApplicationASPNetCoreVersion2.Pages
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
#line 1 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\_ViewImports.cshtml"
using WebApplicationASPNetCoreVersion2;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b209981f2ac6e281e9982636661d0a49082b4cf", @"/Pages/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18063f4f2e09984c1e0a1c52db1762d2fa8fb6ba", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./JoinEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
  
    ViewData["Title"] = "Events";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Events</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Title</th>
            <th>Description</th>
            <th>Organizer</th>
            <th>Place</th>
            <th>Address</th>
            <th>Date</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
         foreach (var item in Model.Events)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(Html.DisplayFor(modelItem => item.Organizer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
           Write(item.Date.ToString("yyyy/MM/dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 45 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
                 if (item.SpotsAvailable > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b209981f2ac6e281e9982636661d0a49082b4cf6810", async() => {
                WriteLiteral("Join");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Not available</p>\r\n");
#nullable restore
#line 52 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Jens\Documents\Programmering\GitHub\WebApplicationASPNetCoreVersion2\WebApplicationASPNetCoreVersion2\Pages\Events.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationASPNetCoreVersion2.Pages.EventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationASPNetCoreVersion2.Pages.EventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationASPNetCoreVersion2.Pages.EventsModel>)PageContext?.ViewData;
        public WebApplicationASPNetCoreVersion2.Pages.EventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
