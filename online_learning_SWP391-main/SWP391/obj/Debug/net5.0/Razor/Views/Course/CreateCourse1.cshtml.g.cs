#pragma checksum "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/CreateCourse1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57214d80c74e8a6e03bd406726bfac60d4f181ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CreateCourse1), @"mvc.1.0.view", @"/Views/Course/CreateCourse1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57214d80c74e8a6e03bd406726bfac60d4f181ff", @"/Views/Course/CreateCourse1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38fe7300b161082b990fc27df38220b188bff0fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_CreateCourse1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWP391.Views.ViewModel.NewCourseVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit-profile m-b30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""db-breadcrumb"">
        <h4 class=""breadcrumb-title"">Add listing</h4>
        <ul class=""db-breadcrumb-list"">
            <li><a href=""#""><i class=""fa fa-home""></i>Home</a></li>
            <li>Add listing</li>
        </ul>
    </div>
    <div class=""row"">
        <!-- Your Profile Views Chart -->
        <div class=""col-lg-12 m-b30"">
            <div class=""widget-box"">
                <div class=""wc-title"">
                    <h4>Add listing</h4>
                </div>
                <div class=""widget-inner"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57214d80c74e8a6e03bd406726bfac60d4f181ff5204", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""ml-auto"">
                                    <h3>1. Basic info</h3>
                                </div>
                            </div>
                            <div class=""form-group col-6"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57214d80c74e8a6e03bd406726bfac60d4f181ff5835", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 27 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/CreateCourse1.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Course.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <div>\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "57214d80c74e8a6e03bd406726bfac60d4f181ff7480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 29 "/Users/macos/Downloads/online_learning_SWP391-main/SWP391/Views/Course/CreateCourse1.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Course.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group col-6"">
                                <label class=""col-form-label"">Course title</label>
                                <div>
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1572, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""form-group col-6"">
                                <label class=""col-form-label"">Course start</label>
                                <div>
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1904, "\"", 1912, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""form-group col-6"">
                                <label class=""col-form-label"">Course expire</label>
                                <div>
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2245, "\"", 2253, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""form-group col-6"">
                                <label class=""col-form-label"">Teacher name</label>
                                <div>
                                    <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2585, "\"", 2593, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""seperator""></div>

                            <div class=""col-12 m-t20"">
                                <div class=""ml-auto m-b5"">
                                    <h3>2. Description</h3>
                                </div>
                            </div>
                            <div class=""form-group col-12"">
                                <label class=""col-form-label"">Course description</label>
                                <div>
                                    <textarea class=""form-control""> </textarea>
                                </div>
                            </div>
                            <div class=""col-12 m-t20"">
                                <div class=""ml-auto"">
                                    <h3 class=""m-form__section"">3. Add Item</h3>
                                </div>
                            </div>
                            <div cla");
                WriteLiteral(@"ss=""col-12"">
                                <table id=""item-add"" style=""width:100%;"">
                                    <tr class=""list-item"">
                                        <td>
                                            <div class=""row"">
                                                <div class=""col-md-4"">
                                                    <label class=""col-form-label"">Course Name</label>
                                                    <div>
                                                        <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4197, "\"", 4205, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    <label class=""col-form-label"">Course Category</label>
                                                    <div>
                                                        <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 4652, "\"", 4660, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </div>
                                                </div>
                                                <div class=""col-md-3"">
                                                    <label class=""col-form-label"">Course Category</label>
                                                    <div>
                                                        <input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 5107, "\"", 5115, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </div>
                                                </div>
                                                <div class=""col-md-2"">
                                                    <label class=""col-form-label"">Close</label>
                                                    <div class=""form-group"">
                                                        <a class=""delete"" href=""#""><i class=""fa fa-close""></i></a>
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <div class=""col-12"">
                                <button type=""button"" class=""btn-secondry add-item m-r5""><i class=""fa fa-fw fa-plus-circle""></i>Add Item</button>
                         ");
                WriteLiteral("       <button type=\"reset\" class=\"btn\">Save changes</button>\n                            </div>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <!-- Your Profile Views Chart END-->\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWP391.Views.ViewModel.NewCourseVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591