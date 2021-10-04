#pragma checksum "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf845eda266e5ac597a9ad3db69f0c41b05b243e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Entry12), @"mvc.1.0.view", @"/Views/Employee/Entry12.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf845eda266e5ac597a9ad3db69f0c41b05b243e", @"/Views/Employee/Entry12.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425e0a4a6ad73ad41f8797b3de7d5a531ff88622", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Entry12 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.ViewModel.EntryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
  
    ViewData["Title"] = "Time Entry";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
 using (Html.BeginForm("Entry","Employee",FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-12 text-center"">
            <h3>Entry Form</h3>
        </div>
    </div>
    <div class=""row justify-content-center mt-3"">
        <div class=""col-12 col-sm-2 align-self-center"">
            ");
#nullable restore
#line 21 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
       Write(Html.LabelFor(model => model.Date, new { @class = "control-lable" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12 col-sm-4\">\r\n            <input class=\"form-control\" type=\"date\" data-val=\"true\" data-val-required=\"Date is Required\" id=\"date\" name=\"date\" />\r\n        </div>\r\n        ");
#nullable restore
#line 26 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
   Write(Html.ValidationMessageFor(model => model.Date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row justify-content-center mt-3\">\r\n        <div class=\"col-12 col-sm-2 align-self-center\">\r\n            ");
#nullable restore
#line 30 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
       Write(Html.LabelFor(model => model.InTime, new { @class = "control-lable" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12 col-sm-4 \">\r\n            <input class=\"form-control\" type=\"time\" data-val=\"true\" data-val-required=\"InTime is Required\" id=\"intime\" name=\"intime\" />\r\n        </div>\r\n        ");
#nullable restore
#line 35 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
   Write(Html.ValidationMessageFor(model => model.InTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row justify-content-center mt-3\">\r\n        <div class=\"col-12 col-sm-2 align-self-center\">\r\n            ");
#nullable restore
#line 39 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
       Write(Html.LabelFor(model => model.OutTime, new { @class = "control-lable" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-12 col-sm-4\">\r\n            <input class=\"form-control\" type=\"time\" data-val=\"true\" data-val-required=\"OutTime is Required\" id=\"outtime\" name=\"outtime\" />\r\n        </div>\r\n        ");
#nullable restore
#line 44 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
   Write(Html.ValidationMessageFor(model => model.OutTime, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""row justify-content-center mt-3"">
        <div class=""col-12 col-sm-6"">
            <table id=""BreakTable"" class=""table table-striped table-sm"">
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
#line 62 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
                     for (int i = 0; i < Model.BreakList.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
                           Write(Html.EditorFor(model => model.BreakList[i].BreakIn, new { htmlAttributes = new { @class = "form-comtrol" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
                           Write(Html.EditorFor(model => model.BreakList[i].BreakOut, new { htmlAttributes = new { @class = "form-comtrol" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <button id=\"btndummmy\" type=\"button\" class=\"btn btn-sm invisible\">Dummy</button>\r\n\r\n                                <button");
            BeginWriteAttribute("id", " id=\"", 3238, "\"", 3252, 2);
            WriteAttributeValue("", 3243, "btnadd-", 3243, 7, true);
#nullable restore
#line 74 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
WriteAttributeValue("", 3250, i, 3250, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-sm btn-secondary visible""
                                        onclick=""AddItem(this)"" style=""left:90%;position:absolute;"">
                                    Add
                                </button>
                                <button");
            BeginWriteAttribute("id", " id=\"", 3535, "\"", 3552, 2);
            WriteAttributeValue("", 3540, "btnremove-", 3540, 10, true);
#nullable restore
#line 78 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
WriteAttributeValue("", 3550, i, 3550, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""button"" class=""btn btn-sm btn-danger invisible""
                                        onclick=""DeleteItem(this)"" style=""left:90%;position:absolute;"">
                                    Delete
                                </button>
                            </td>
                        </tr>
");
#nullable restore
#line 84 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <input type=\"hidden\" id=\"hasLastIndex\" value=\"0\" />\r\n\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n");
#nullable restore
#line 115 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n");
#nullable restore
#line 119 "D:\Training\Assign\External\MVC\29-Sep-2021\EmployeeManagement\Views\Employee\Entry12.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script type=""text/javascript"">

        function DeleteItem(btn) {
            $(btn).closest('div').remove();
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
            new.innerHTML = rowOuterHtml;

            var btnAddID = btn.id;
            var btnDeleteID = btnAddID");
                WriteLiteral(@".replaceAll('btnadd', 'btnremove');

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
