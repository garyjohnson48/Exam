#pragma checksum "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bca2f821be92324645cbb964353f5970f8dad9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Exam.Models.Views_Exam_UserPage), @"mvc.1.0.view", @"/Views/Exam/UserPage.cshtml")]
namespace Exam.Models
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bca2f821be92324645cbb964353f5970f8dad9", @"/Views/Exam/UserPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999fc272ae79c73499df8e2c071004ea98d96b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Exam_UserPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"row mt-4\">\r\n        <div class=\"col-12 d-flex justify-content-end align-items-end\">\r\n            <a href=\"/bright_ideas\" class=\"mr-2\">Bright Ideas</a>\r\n            <a href=\"/logout\">Logout</a>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("<div class=\"row mt-4\">\r\n    <div class=\"col-1\"></div>\r\n    <div class=\"col-6\">\r\n        <p>Name: ");
#nullable restore
#line 14 "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml"
            Write(ViewBag.user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Alias: ");
#nullable restore
#line 15 "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml"
             Write(ViewBag.user.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Email: ");
#nullable restore
#line 16 "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml"
             Write(ViewBag.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-5\"></div>\r\n\r\n</div>\r\n");
            WriteLiteral("<hr class=\"mt-4 mb-4\">\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-1\"></div>\r\n    <div class=\"col-6\">\r\n        <p>Total Number of Post:");
#nullable restore
#line 27 "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml"
                           Write(ViewBag.user.IdeasCreated.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        <p>Total Number of Likes:");
#nullable restore
#line 28 "E:\Coding_Dojo\dojo_assignments\C#\Exam\Views\Exam\UserPage.cshtml"
                            Write(ViewBag.user.Liked.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-5\"></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
