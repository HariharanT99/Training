#pragma checksum "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63151aed455e1fa02882e0c4f6f8f11dea307036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_CreateEntry), @"mvc.1.0.view", @"/Views/Employee/CreateEntry.cshtml")]
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
#line 1 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63151aed455e1fa02882e0c4f6f8f11dea307036", @"/Views/Employee/CreateEntry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425e0a4a6ad73ad41f8797b3de7d5a531ff88622", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_CreateEntry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.ViewModel.EntryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("val"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEntry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button button-emp btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
  
    ViewBag.Title = "CreateEntry";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row ml-2"">
    <div class=""col-12 col-sm-4 ml-3"">
        <h1>CreateEntry</h1>
    </div>
</div>

<div class=""row justify-content-start"">
    <div class=""col-sm-7"">
        <hr />
    </div>
    <div class=""col-sm-3 text-right"">
        <h2>User Info</h2>
    </div>
</div>

    <div class=""row"">
    <div class=""col-12 col-sm-8"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63151aed455e1fa02882e0c4f6f8f11dea3070367208", async() => {
                WriteLiteral(@"
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12 col-sm-10 text-center text-floral"">
                        <h3>Entry Form</h3>
                    </div>
                </div>

                <div class=""row justify-content-center mt-3"">
                    <div class=""col-12 col-sm-2 align-self-center"">
                        ");
#nullable restore
#line 34 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                   Write(Html.LabelFor(model => model.Date, new { @class = "control-lable text-lg" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-sm-3 mr-5"">
                        <input class=""form-control"" type=""date"" data-val=""true"" data-val-required=""Date is Required"" id=""date"" name=""date"" />
                    </div>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63151aed455e1fa02882e0c4f6f8f11dea3070368488", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Date);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"row justify-content-center mt-3\">\r\n                    <div class=\"col-12 col-sm-2 align-self-center\">\r\n                        ");
#nullable restore
#line 44 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                   Write(Html.LabelFor(model => model.InTime, new { @class = "control-lable text-lg" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-sm-3 mr-5 "">
                        <input class=""form-control"" type=""time"" data-val=""true"" data-val-required=""InTime is Required"" id=""intime"" name=""intime"" />
                    </div>
                    ");
#nullable restore
#line 49 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
               Write(Html.ValidationMessageFor(model => model.InTime, "", new { @class = "text-white" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"row justify-content-center mt-3\">\r\n                    <div class=\"col-12 col-sm-2 align-self-center\">\r\n                        ");
#nullable restore
#line 54 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                   Write(Html.LabelFor(model => model.OutTime, new { @class = "control-lable text-lg" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <div class=""col-12 col-sm-3 mr-5"">
                        <input class=""form-control"" type=""time"" data-val=""true"" data-val-required=""OutTime is Required"" id=""outtime"" name=""outtime"" />
                    </div>
                    ");
#nullable restore
#line 59 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
               Write(Html.ValidationMessageFor(model => model.OutTime, "", new { @class = "text-white" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

                <div class=""row justify-content-start"">
                    <div class=""col-sm-11"">
                        <hr />
                    </div>
                </div>

                <div class=""row justify-content-center mt-3"">
                    <div class=""col-12 col-sm-10 offset-sm-2 align-self-center"">
                        <table id=""BreakTable"" class=""table table-borderless table-sm"">
                            <thead>
                                <tr>
                                    <th>
                                        BreakFrom
                                    </th>
                                    <th>
                                        BreakTo
                                    </th>
                                    <th>
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 84 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                                 for (int i = 0; i < Model.BreakList.Count; i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 88 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                                       Write(Html.EditorFor(model => model.BreakList[i].BreakIn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 91 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                                       Write(Html.EditorFor(model => model.BreakList[i].BreakOut, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n\r\n                                            <button");
                BeginWriteAttribute("id", " id=\"", 4350, "\"", 4364, 2);
                WriteAttributeValue("", 4355, "btnadd-", 4355, 7, true);
#nullable restore
#line 95 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
WriteAttributeValue("", 4362, i, 4362, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-sm btn-info btn-outline-dark visible bta""
                                                    onclick=""AddItem(this)"">
                                                <i class=""fa fa-plus""> Add</i>
                                            </button>
                                            <button");
                BeginWriteAttribute("id", " id=\"", 4688, "\"", 4705, 2);
                WriteAttributeValue("", 4693, "btnremove-", 4693, 10, true);
#nullable restore
#line 99 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
WriteAttributeValue("", 4703, i, 4703, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-sm btn-danger btn-outline-dark btd invisible""
                                                    onclick=""DeleteItem(this)"">
                                                <i class=""fa fa-trash-alt""> Delete</i>
                                            </button>
                                        </td>
                                    </tr>
");
#nullable restore
#line 105 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <input type=""hidden"" id=""hasLastIndex"" value=""0"" />
                </div>

                <div class=""row justify-content-center"">
                    <div class=""col-12 col-sm-2 offset-sm-8"">
                        <input type=""submit"" class=""btn bts"" value=""save"" />
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"col-sm-3 ml-5 mt-4\">\r\n        <h5>Id:</h5>\r\n        <h5 class=\"mt-3\">Name:</h5>\r\n        <h5 class=\"mt-3\">Email:</h5>\r\n        <div class=\"d-grid gap-2 mt-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63151aed455e1fa02882e0c4f6f8f11dea30703619111", async() => {
                WriteLiteral("<span><i class=\"fa fa-chart-line\"> Dashboard</i> </span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"d-grid gap-2 mt-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63151aed455e1fa02882e0c4f6f8f11dea30703620766", async() => {
                WriteLiteral("<span><i class=\"fa fa-home\"> Home</i> </span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 136 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\CreateEntry.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script type=""text/javascript"">

        function DeleteItem(btn) {
            $(btn).closest('tr').remove();
        }

        function AddItem(btn) {
            var table = document.getElementById('BreakTable');
            var rows = table.getElementsByTagName('tr');

            var rowOuterHtml = rows[rows.length - 1].outerHTML;

            var lastrowIdx = document.getElementById('hasLastIndex').value;

            var nextrowIdx = eval(lastrowIdx) + 1;

            document.getElementById('hasLastIndex').value = nextrowIdx;

            rowOuterHtml = rowOuterHtml.replaceAll('_' + lastrowIdx + '_', '_' + nextrowIdx + '_');
            rowOuterHtml = rowOuterHtml.replaceAll('[' + lastrowIdx + ']', '[' + nextrowIdx + ']');
            rowOuterHtml = rowOuterHtml.replaceAll('_' + lastrowIdx, '_' + nextrowIdx);

            var newRow = table.insertRow();
            newRow.innerHTML = rowOuterHtml;

            var btnAddID = btn.id;

            var btnDeleteID = btnA");
                WriteLiteral(@"ddID.replaceAll('btnadd', 'btnremove');

            var delbtn = document.getElementById(btnDeleteID);
            delbtn.classList.add('visible');
            delbtn.classList.remove('invisible');

            var addbtn = document.getElementById(btnAddID);
            addbtn.classList.remove('visible');
            addbtn.classList.add('invisible');

        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.ViewModel.EntryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
