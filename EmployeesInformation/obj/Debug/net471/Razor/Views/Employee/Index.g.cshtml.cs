#pragma checksum "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937ff8328d4565d3410e2f451a0e8f00b62770a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\_ViewImports.cshtml"
using EmployeesInformation;

#line default
#line hidden
#line 2 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\_ViewImports.cshtml"
using EmployeesInformation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"937ff8328d4565d3410e2f451a0e8f00b62770a9", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f92872be69edf98caa8b6ce9924398cee1d7eed9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 18, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
            EndContext();
#line 4 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml"
 foreach (var e in Model)
{

#line default
#line hidden
            BeginContext(78, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(86, 4, false);
#line 6 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml"
  Write(e.Id);

#line default
#line hidden
            EndContext();
            BeginContext(90, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(104, 11, false);
#line 7 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml"
  Write(e.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(115, 13, true);
            WriteLiteral("</p>\r\n    <p>");
            EndContext();
            BeginContext(129, 10, false);
#line 8 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml"
  Write(e.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(139, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "D:\Для работы\Задание для проверкуи\версия4\EmployeesInformation\Views\Employee\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
