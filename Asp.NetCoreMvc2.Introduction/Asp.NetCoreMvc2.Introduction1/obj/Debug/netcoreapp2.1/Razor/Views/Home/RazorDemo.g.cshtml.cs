#pragma checksum "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba416da1fdfae3ffb5cc22d7bd090f3f4519d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RazorDemo), @"mvc.1.0.view", @"/Views/Home/RazorDemo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RazorDemo.cshtml", typeof(AspNetCore.Views_Home_RazorDemo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba416da1fdfae3ffb5cc22d7bd090f3f4519d71", @"/Views/Home/RazorDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd9d3b11353bc288e0db4ed28e1646084a54c9e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RazorDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Asp.NetCoreMvc2.Introduction1.employeeListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(89, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(118, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae2a810da4546d89cc5d3f5923716e5", async() => {
                BeginContext(124, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>RazorDemo</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 1933, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a17a2769897a491da568ea33d9878c5d", async() => {
                BeginContext(230, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(249, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b063a6e43cbc425aa860797f82c0167e", async() => {
                    BeginContext(272, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
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
                EndContext();
                BeginContext(286, 263, true);
                WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>

                <th>FirstName</th>
                <th>LastName</th>
                <th>CityId</th>
            </tr>
        </thead>
        <tbody>
");
                EndContext();
#line 29 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
             foreach (var item in Model.Employees)
            {

#line default
#line hidden
                BeginContext(616, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(663, 7, false);
#line 32 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                   Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(670, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(702, 13, false);
#line 33 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                   Write(item.FirtName);

#line default
#line hidden
                EndContext();
                BeginContext(715, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(747, 13, false);
#line 34 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                   Write(item.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(760, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(792, 11, false);
#line 35 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                   Write(item.CityId);

#line default
#line hidden
                EndContext();
                BeginContext(803, 31, true);
                WriteLiteral(".</td>\r\n                </tr>\r\n");
                EndContext();
#line 37 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
            }

#line default
#line hidden
                BeginContext(849, 39, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>");
                EndContext();
                BeginContext(889, 12, false);
#line 40 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
                EndContext();
                BeginContext(901, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 41 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
       var Date = DateTime.Now - TimeSpan.FromDays(3);

#line default
#line hidden
                BeginContext(964, 22, true);
                WriteLiteral("    <p>3 days ago was ");
                EndContext();
                BeginContext(987, 4, false);
#line 42 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                 Write(Date);

#line default
#line hidden
                EndContext();
                BeginContext(991, 8, true);
                WriteLiteral("</p>\r\n\r\n");
                EndContext();
#line 44 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
      var number = 10;

#line default
#line hidden
                BeginContext(1024, 7, true);
                WriteLiteral("    <p>");
                EndContext();
                BeginContext(1032, 6, false);
#line 45 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
  Write(number);

#line default
#line hidden
                EndContext();
                BeginContext(1038, 8, true);
                WriteLiteral("</p>\r\n\r\n");
                EndContext();
#line 47 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     if (number < 10)
    {

#line default
#line hidden
                BeginContext(1076, 39, true);
                WriteLiteral("        <p>Number is less than 10</p>\r\n");
                EndContext();
#line 50 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
    }
    else if (number == 10)
    {

#line default
#line hidden
                BeginContext(1157, 33, true);
                WriteLiteral("        <p>Number number 10</p>\r\n");
                EndContext();
#line 54 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1214, 44, true);
                WriteLiteral("        <p>your number greater then 10</p>\r\n");
                EndContext();
#line 58 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
                BeginContext(1265, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 60 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     switch (number)
    {
        case 10:

#line default
#line hidden
                BeginContext(1312, 24, true);
                WriteLiteral("<p>Your Number is 10</p>");
                EndContext();
#line 62 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                                        break;
        case 11:

#line default
#line hidden
                BeginContext(1360, 25, true);
                WriteLiteral(" <p>Your Number is 10</p>");
                EndContext();
#line 63 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                                         break;
        case 12:

#line default
#line hidden
                BeginContext(1409, 25, true);
                WriteLiteral(" <p>Your Number is 10</p>");
                EndContext();
#line 64 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                                         break;

        default:

#line default
#line hidden
                BeginContext(1460, 38, true);
                WriteLiteral("<p>I have no idea about the number</p>");
                EndContext();
#line 66 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
                                                      break;
    }

#line default
#line hidden
                BeginContext(1513, 11, true);
                WriteLiteral("\r\n    FOR\r\n");
                EndContext();
#line 70 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     for (int i = 0; i < Model.Employees.Count; i++)
    {

#line default
#line hidden
                BeginContext(1585, 17, true);
                WriteLiteral("        <br /><b>");
                EndContext();
                BeginContext(1603, 27, false);
#line 72 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
            Write(Model.Employees[i].FirtName);

#line default
#line hidden
                EndContext();
                BeginContext(1630, 6, true);
                WriteLiteral("</b>\r\n");
                EndContext();
#line 73 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
                BeginContext(1643, 26, true);
                WriteLiteral("\r\n    <br /><i>WHİLE</i>\r\n");
                EndContext();
#line 76 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
       var counter = 0;

#line default
#line hidden
                BeginContext(1695, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 77 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     while (counter < Model.Employees.Count)
    {

#line default
#line hidden
                BeginContext(1748, 17, true);
                WriteLiteral("        <br /><b>");
                EndContext();
                BeginContext(1766, 33, false);
#line 79 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
            Write(Model.Employees[counter].FirtName);

#line default
#line hidden
                EndContext();
                BeginContext(1799, 6, true);
                WriteLiteral("</b>\r\n");
                EndContext();
#line 80 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
        counter++;
    }

#line default
#line hidden
                BeginContext(1832, 16, true);
                WriteLiteral("\r\n    DO-WHİLE\r\n");
                EndContext();
#line 84 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
       var counter2 = 0;

#line default
#line hidden
                BeginContext(1875, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 85 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     do
    {

#line default
#line hidden
                BeginContext(1891, 17, true);
                WriteLiteral("        <br /><b>");
                EndContext();
                BeginContext(1909, 34, false);
#line 87 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
            Write(Model.Employees[counter2].FirtName);

#line default
#line hidden
                EndContext();
                BeginContext(1943, 6, true);
                WriteLiteral("</b>\r\n");
                EndContext();
#line 88 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
        counter2++;
    } while (counter2 < Model.Employees.Count);

#line default
#line hidden
                BeginContext(2019, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 90 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
                BeginContext(2057, 86, true);
                WriteLiteral("        <input type=\"text\" name=\"\" id=\"\"/>\r\n        <button type=\"submit\" ></button>\r\n");
                EndContext();
#line 94 "C:\Users\FURKAN\source\repos\Asp.NetCoreMvc2.Introduction\Asp.NetCoreMvc2.Introduction1\Views\Home\RazorDemo.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2157, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Asp.NetCoreMvc2.Introduction1.employeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591