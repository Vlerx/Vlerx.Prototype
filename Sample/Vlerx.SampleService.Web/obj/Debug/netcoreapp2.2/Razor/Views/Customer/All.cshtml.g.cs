#pragma checksum "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c88b86155887906b7b2a6d387e799f443b4013f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_All), @"mvc.1.0.view", @"/Views/Customer/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/All.cshtml", typeof(AspNetCore.Views_Customer_All))]
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
#line 1 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/_ViewImports.cshtml"
using Vlerx.SampleService.Web;

#line default
#line hidden
#line 2 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/_ViewImports.cshtml"
using Vlerx.SampleService.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c88b86155887906b7b2a6d387e799f443b4013f", @"/Views/Customer/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5c2a60754152889421842e7956b8b5ae31f290", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(121, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(144, 49, false);
#line 9 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
Write(Html.ActionLink("Register a Customer","Register"));

#line default
#line hidden
            EndContext();
            BeginContext(193, 91, true);
            WriteLiteral("\n<br/>\n<table id=\"myTable\" class=\"table\" cellspacing=\"0\">\n        <thead>\n            <tr>\n");
            EndContext();
#line 14 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                 foreach (var property in Model.GetType().GetGenericArguments()[0].GetProperties()
                                            .Where(predicate=>predicate.Name != "Id"))
                {

#line default
#line hidden
            BeginContext(488, 24, true);
            WriteLiteral("                    <th>");
            EndContext();
            BeginContext(513, 13, false);
#line 17 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                   Write(property.Name);

#line default
#line hidden
            EndContext();
            BeginContext(526, 6, true);
            WriteLiteral("</th>\n");
            EndContext();
#line 18 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                }

#line default
#line hidden
            BeginContext(550, 85, true);
            WriteLiteral("                <th>Relocate</th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 23 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(690, 21, true);
            WriteLiteral("                <tr>\n");
            EndContext();
#line 26 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                 foreach (var property in item.GetType().GetProperties().Where(predicate=>predicate.Name != "Id"))
                {

#line default
#line hidden
            BeginContext(844, 25, true);
            WriteLiteral("                     <td>");
            EndContext();
            BeginContext(870, 23, false);
#line 28 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                    Write(property.GetValue(item));

#line default
#line hidden
            EndContext();
            BeginContext(893, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 29 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
                }

#line default
#line hidden
            BeginContext(917, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(938, 79, false);
#line 30 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
               Write(Html.ActionLink("Relocate","Relocate","Customer",new {customerId=item.Id},null));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 32 "/home/mohsen/Desktop/Old/al/111/shared/Sample/Vlerx.SampleService.Web/Views/Customer/All.cshtml"
            }

#line default
#line hidden
            BeginContext(1059, 29, true);
            WriteLiteral("        </tbody>\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591