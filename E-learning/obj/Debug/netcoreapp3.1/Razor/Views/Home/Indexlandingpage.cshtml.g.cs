#pragma checksum "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cca780d123ce7e15e5611c9c5cc53217e12e9756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Indexlandingpage), @"mvc.1.0.view", @"/Views/Home/Indexlandingpage.cshtml")]
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
#line 1 "E:\Internship final project\E-learning\E-learning\E-learning\Views\_ViewImports.cshtml"
using E_learning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Internship final project\E-learning\E-learning\E-learning\Views\_ViewImports.cshtml"
using E_learning.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca780d123ce7e15e5611c9c5cc53217e12e9756", @"/Views/Home/Indexlandingpage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23ee5d6484b2cae01d12209b36147c3399dee59", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Indexlandingpage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
   Layout = "/Views/Shared/_LayoutLandingpage.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"﻿

<style>
    .carousel-cell {
        border-radius: 5px;
        counter-increment: carousel-cell;
    }



        /* cell number */
        .carousel-cell:before {
            display: block;
        }





    .fcrse_1:hover {
        -ms-transform: scale(1.1); /* IE 9 */
        -webkit-transform: scale(1.0); /* Safari 3-8 */
        transform: scale(1.1);
    }
</style>
<!--our featured courses-->

<!----!!!!!!!!!! CAROUSEL IS LEFT (CAROUSEL LIKE STUDENT AND TEACHER DASHBOARD) TRIED TO ADD BUT NOT WORKING IN LANDING PAGE !!!!!!!!!!  -->

<div class=""container-fluid "">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""aligncenter"">
                <h1 class=""aligncenter"">Our Featured Courses</h1><span class=""clear spacer_responsive_hide_mobile "" style=""height:13px;display:block;""></span>

            </div>
        </div>
    </div>
</div>

















<!--content featured courses-->
<section id=""content"">
    <di");
            WriteLiteral("v class=\"container-fluid\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 69 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
             foreach (DataRow row in Model.Rows)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-6\">\r\n                    <div class=\"fcrse_1 mt-30\">\r\n                        <!--Image of Course-->\r\n                        <a class=\"fcrse_img\">\r\n\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1461, "\"", 1487, 1);
#nullable restore
#line 76 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
WriteAttributeValue("", 1467, row["course_image"], 1467, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1488, "\"", 1494, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 170.59px \">\r\n\r\n\r\n                        </a>\r\n                        <div class=\"fcrse_content\">\r\n\r\n                            <!--Course Details-->\r\n");
            WriteLiteral("\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1831, "\"", 1911, 2);
            WriteAttributeValue("", 1838, "/TeacherArea/CourseDetails/IndexCourseDetails?Course_id=", 1838, 56, true);
#nullable restore
#line 85 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
WriteAttributeValue("", 1894, row["Course_id"], 1894, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"crse-cate\">");
#nullable restore
#line 85 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
                                                                                                                             Write(row["Course_Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            <a href=\"#\" class=\"crse-cate\">");
#nullable restore
#line 86 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
                                                     Write(row["Course_Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            <a href=\"#\" class=\"crse-cate\">");
#nullable restore
#line 87 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
                                                     Write(row["Course_Level"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>


                        </div>
                        <div class=""_215b05"">
                            <ul class=""_215b31"">
                                <li><button class=""main-btn color"" style=""margin-left: 160px; background-color: red; color: white"" data-toggle=""modal"" data-target=""#CheckUserModal"">Enroll Now</button></li>
                            </ul>
                        </div>
                    </div>
                </div>");
#nullable restore
#line 97 "E:\Internship final project\E-learning\E-learning\E-learning\Views\Home\Indexlandingpage.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n<!--content featured courses end-->\r\n\r\n\r\n<script type=\"text/javascript\">\r\n    function CheckUser() {\r\n        alert(\"ok\")\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
