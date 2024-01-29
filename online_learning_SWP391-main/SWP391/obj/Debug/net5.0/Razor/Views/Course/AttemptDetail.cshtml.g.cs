#pragma checksum "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378f77034cb679c385beeec715384fdec5ff7dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_AttemptDetail), @"mvc.1.0.view", @"/Views/Course/AttemptDetail.cshtml")]
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
#line 1 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378f77034cb679c385beeec715384fdec5ff7dfe", @"/Views/Course/AttemptDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fe7300b161082b990fc27df38220b188bff0fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_AttemptDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SWP391.Models.Attempt>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "ATTEMPT DETAILED";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-content bg-white"">
    <div class=""breadcrumb-row"">
        <div class=""container"">
            <ul class=""list-inline"">
                <li><a href=""#"">Home</a></li>
                <li>Attempt</li>
            </ul>
        </div>
    </div>
    <div class=""content-block"">
        <div class=""section-area section-sp1"">
            <h2 style=""text-align:center"">Record</h2>
            <div class=""container"">
                <table class=""table table-bordered"" >
                    <thead style=""background-color: #00c5dc"">
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Start time</th>
                            <th scope=""col"">Mark</th>
                            <th scope=""col"">Question Preview</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 31 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                         if (Model.Count > 0)
                        {
                            int count = 0;
                            foreach (var at in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 37 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                    Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 38 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                    Write(String.Format("{0:MM/dd/yyyy}", at.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 39 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                   Write(at.TotalMark);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                    <td>
                                        <table class=""table"">
                                            <thead style=""background-color: #00c5dc"">
                                                <tr>
                                                    
                                                    <th scope=""col"">Id</th>
                                                    <th scope=""col"">User Answer</th>
                                                    <th scope=""col"">Correct Answer</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 51 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                                 foreach(var atd in at.AttemptDetaileds) 
                                                { 
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\n                                                    <td>");
#nullable restore
#line 55 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                                   Write(atd.QuestionBank.QuestionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 56 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                                   Write(atd.UserAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 57 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                                   Write(atd.QuestionBank.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                </tr>\n");
#nullable restore
#line 59 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\n                                        </table>\n                                        \n                                    </td>\n                                </tr>\n");
#nullable restore
#line 65 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n                ");
#nullable restore
#line 69 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/AttemptDetail.cshtml"
           Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SWP391.Models.Attempt>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591