#pragma checksum "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c15c1f8e20d971b8b62cd27d064dbc1ee47ccd00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Piatto_Index), @"mvc.1.0.view", @"/Views/Piatto/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\_ViewImports.cshtml"
using Academy.TestWeek5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\_ViewImports.cshtml"
using Academy.TestWeek5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\_ViewImports.cshtml"
using Academy.TestWeek5.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\_ViewImports.cshtml"
using Academy.TestWeek5.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15c1f8e20d971b8b62cd27d064dbc1ee47ccd00", @"/Views/Piatto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adbe55ebfb7983e086e66bbdbb8596877a3a57d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Piatto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Piatto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   ViewBag.NumPiatti = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
 if (User.IsInRole("Ristoratore"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c15c1f8e20d971b8b62cd27d064dbc1ee47ccd004461", async() => {
                WriteLiteral("New Piatto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
#nullable restore
#line 11 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<td></td>
<td></td>
<td></td>


<table class=""table"" border=""1"" height=""600"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Descrizione</th>
            <th>Tipologia</th>
            <th>Prezzo</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 33 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(item.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 36 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(item.Tipologia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 37 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(item.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n\n        ");
#nullable restore
#line 40 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 41 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n        ");
#nullable restore
#line 42 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </td>\n</tr>");
#nullable restore
#line 45 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n    <tfoot>\n        <tr>\n            <td># Piatti</td>\n            <td></td>\n            <td></td>\n            <td></td>\n            <td></td>\n");
            WriteLiteral("            <td>");
#nullable restore
#line 56 "C:\Users\mariangela.leone\Desktop\Academy.TestWeek5\Academy.TestWeek5\Academy.TestWeek5\Views\Piatto\Index.cshtml"
           Write(ViewBag.NumPiatti);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Piatto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
