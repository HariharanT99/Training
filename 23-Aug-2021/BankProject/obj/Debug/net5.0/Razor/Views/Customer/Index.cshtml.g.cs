#pragma checksum "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43913fc7e91c0299d84d67e6eaed40b5c459f38f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\Training\Assign\23-Aug-2021\BankProject\Views\_ViewImports.cshtml"
using BankProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Assign\23-Aug-2021\BankProject\Views\_ViewImports.cshtml"
using BankProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43913fc7e91c0299d84d67e6eaed40b5c459f38f", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f213fbc9e96c287385b4b4be463c60fa15143b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-end\">\r\n    <div class=\"col-4 col-sm-4\">\r\n        <h2>Customer Details</h2>\r\n    </div>\r\n    <div class=\"col-2 col-sm-6\">\r\n    </div>\r\n    <div class=\"col-4 col-sm-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43913fc7e91c0299d84d67e6eaed40b5c459f38f4159", async() => {
                WriteLiteral("Add Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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



<div class=""row justify-content-center mt-3"">
    <div class=""col-12"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th scope=""col"" width=""10%"">Id</th>
                    <th scope=""col"" width=""20%"">Name</th>
                    <th scope=""col"" width=""30%"">Address</th>
                    <th scope=""col"" width=""10%"">Age</th>
                    <th scope=""col"" width=""10%"">Gender</th>
                    <th scope=""col"" width=""20%"">Opening Balance</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                 foreach (var customer in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"10%\">");
#nullable restore
#line 39 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"20%\">");
#nullable restore
#line 40 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"40%\">");
#nullable restore
#line 41 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"10%\">");
#nullable restore
#line 42 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"10%\">");
#nullable restore
#line 43 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"10%\">");
#nullable restore
#line 44 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                               Write(customer.OpeningBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "D:\Training\Assign\23-Aug-2021\BankProject\Views\Customer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
