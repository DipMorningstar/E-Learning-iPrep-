#pragma checksum "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccd24a1377ef09f37c8fd2260eed5a67e36c9716"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TeacherArea_Views_CourseDetails_IndexCourseDetails), @"mvc.1.0.view", @"/Areas/TeacherArea/Views/CourseDetails/IndexCourseDetails.cshtml")]
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
#line 2 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd24a1377ef09f37c8fd2260eed5a67e36c9716", @"/Areas/TeacherArea/Views/CourseDetails/IndexCourseDetails.cshtml")]
    public class Areas_TeacherArea_Views_CourseDetails_IndexCourseDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
   Layout = "/Views/Shared/" + ViewData["layout"].ToString();




#line default
#line hidden
#nullable disable
            WriteLiteral("﻿\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccd24a1377ef09f37c8fd2260eed5a67e36c97163286", async() => {
                WriteLiteral(@"

    
    <style>
      .heart i.uil-heart{
          color:red;
      }
            
   
    </style>
    



    <!-----!!!!!!!!! THERE IS HEART IN SAVE OPTION, WHICH IS NOT WORKING LIKE HEART IS NOT FILLED WHILE USER CLICKED ON SAVE BUTTON !!!!!!!!!!!-->

    <!-----!!!!!!! ATTACHMENT DOWNLOAD IN PDF FORM IS REMAIN !!!!!!!!!!!!!!!!!!-->

    <!----!!!!!!! THERE IS PROBLEM WITH TOPIC TAB MINIMIZATION !!!!!!-->






   
<!-- TOP PART OF COURSE DETAILS PAGE-->
    <div class=""_215b01"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section3125"">
                        <div class=""row justify-content-center"">
");
#nullable restore
#line 42 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                             foreach (DataRow row in Model.Rows)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <div class=""col-xl-4 col-lg-5 col-md-6"">
                                    <div class=""preview_video"">
                                        <a class=""fcrse_img"" href=""../CourseDetails/IndexCourseDetails"">
                                            <img");
                BeginWriteAttribute("src", " src=\"", 1239, "\"", 1265, 1);
#nullable restore
#line 47 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 1245, row["course_image"], 1245, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1266, "\"", 1272, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""height:170.59px"" />
                                            <div class=""course-overlay"">
                                                <span class=""play_btn1""><i class=""uil uil-play""></i></span>
                                                <span class=""_215b02"">Preview this course</span>
                                            </div>
                                        </a>

                                    </div>
                                    <div class=""_215b10"">
                                        <a href=""#"" class=""_215b11 save"">
                                            <span><i class=""uil uil-heart"" id=""heart""");
                BeginWriteAttribute("onclick", " onclick=\"", 1946, "\"", 1981, 3);
                WriteAttributeValue("", 1956, "Save(\'", 1956, 6, true);
#nullable restore
#line 57 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 1962, row["Course_id"], 1962, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1979, "\')", 1979, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"></i></span>Save
                                        </a>
                                        <a href=""#"" class=""_215b12"">
                                            <span><i class=""uil uil-windsock""></i></span>Report abuse
                                        </a>
                                    </div>
                                </div>
");
                WriteLiteral("                                <div class=\"col-xl-8 col-lg-7 col-md-6\">\r\n                                    <div class=\"_215b03\">\r\n                                        <a href=\"#\" class=\"crse-cate\">");
#nullable restore
#line 71 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                 Write(row["Course_name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n\r\n                                        <a href=\"#\" class=\"crse-cate\">");
#nullable restore
#line 73 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                 Write(row["Course_Category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </a>\r\n                                        <a href=\"#\" class=\"crse-cate\">");
#nullable restore
#line 74 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                 Write(row["Course_Level"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                        <a herf=\"#\" class=\"crse-cate mt-2\" style=\"color:White\"><h2>");
#nullable restore
#line 75 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                                              Write(row["EnrolStatus"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2></a>\r\n\r\n                                    </div>\r\n                                    <div class=\"_215b05\">\r\n                                        <ul class=\"_215b31\">\r\n                                            <li>\r\n");
#nullable restore
#line 81 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                 if (row["EnrolStatus"].ToString() != "Enrolled")
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <a");
                BeginWriteAttribute("href", " href=\"", 3336, "\"", 3410, 2);
                WriteAttributeValue("", 3343, "/TeacherArea/CourseDetails/EnrollCourse?Course_id=", 3343, 50, true);
#nullable restore
#line 83 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 3393, row["Course_id"], 3393, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" title=\"Submit\" id=\"Enrollbtn\"\r\n                                                       class=\"btn_adcart\" value=\" \">Enroll Now</a>");
#nullable restore
#line 84 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                                                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </ul>\r\n                                        </div>\r\n                                </div>\r\n");
#nullable restore
#line 88 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>






    <!--TOPIC, ECONTENT,TEST-->


    <div class=""_215b15 _byt1458"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">

                    <div class=""course_tabs"">
                        <nav>
                            <div class=""nav nav-tabs tab_crse justify-content-center"" id=""nav-tab"" role=""tablist"">
                                <a class=""nav-item nav-link active"" id=""nav-about-tab"" data-toggle=""tab"" href=""#nav-about"" role=""tab"" aria-selected=""true"">About</a>
                                <a class=""nav-item nav-link"" id=""nav-courses-tab"" data-toggle=""tab"" href=""#nav-courses"" role=""tab"" aria-selected=""false"">Courses Content</a>
                                <!-- <a class=""nav-item nav-link"" id=""nav-reviews-tab"" data-toggle=""tab"" href=""#nav-reviews"" role=""tab"" aria-selected=""false"">Re");
                WriteLiteral(@"views</a>-->
                            </div>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""_215b17"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""course_tab_content"">
                        <div class=""tab-content"" id=""nav-tabContent"">
                            <div class=""tab-pane fade show active"" id=""nav-about"" role=""tabpanel"">
                                <div class=""_htg451"">
                                    
                                    <div class=""_htg452 mt-35"">
                                        <h3>Description</h3>
");
#nullable restore
#line 133 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                         foreach (DataRow row in Model.Rows)
                                        {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                  Write(row["Course_Description"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                 ;
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                         </div>
                                 
                                </div>
                            </div>




                            <div class=""tab-pane fade"" id=""nav-courses"" role=""tabpanel"">
                                <div class=""crse_content"">
                                    <h3>Course content</h3>
                                    <div class=""_112456"">
                                        <ul class=""accordion-expand-holder"">
                                            <li><span class=""accordion-expand-all _d1452"">Expand all</span></li>
");
                WriteLiteral(@"                                            
                                        </ul>
                                    </div>
                                    <div id=""accordion"" class=""ui-accordion ui-widget ui-helper-reset"">
                                      
                                        <div class=""section-header-left"">

");
#nullable restore
#line 159 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                             foreach (var item in ViewData["Topics"] as List<E_learning.Areas.TeacherArea.Models.Showtopic>)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <a href=""javascript:void(0)"" class=""accordion-header ui-accordion-header ui-helper-reset ui-state-default ui-accordion-icons ui-corner-all"">
                                                    <h2>
                                                        <i class='uil uil-file icon_142'>

                                                            <span class=""section-title-text"">
                                                                 ");
#nullable restore
#line 166 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                            Write(item.Topic_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                            </span>
                                                        </i>
                                                    </h2> </a>
                                                    <div class=""ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom"">


                                                        <div class=""container-fluid"">

                                                            <div class=""top"">
                                                                <div class=""title"">");
#nullable restore
#line 176 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                              Write(item.Topic_Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

                                                            </div>
                                                            <div class=""ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom mt-5"">
                                                                <h4><i class="" uil uil-presentation-play crse_icon ""> <span class=""section-title-text"">Econtent </span></i></h4>
                                                                <div class=""mt-3"">

                                                                    <table class=""table"" id=""table1"">
                                                                        <thead>
");
#nullable restore
#line 185 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                             if (item.Video != "") 
                                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                <tr>
                                                                                    <th scope=""row"" class=""uil uil-play-circle icon_142"" style=""border-bottom: 1px solid #DEE2E5""> Video</th>
                                                                                    <td style=""border-bottom: 1px solid #DEE2E5"">

                                                                                        <a href=""#""");
                BeginWriteAttribute("onclick", " onclick=\"", 9505, "\"", 9557, 5);
                WriteAttributeValue("", 9515, "GetContent(\'", 9515, 12, true);
#nullable restore
#line 191 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 9527, item.Topic_id, 9527, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9541, "\',\'", 9541, 3, true);
#nullable restore
#line 191 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 9544, item.Video, 9544, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 9555, "\')", 9555, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 191 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                                                                                                    Write(item.Video);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                                                    </td>\r\n                                                                                </tr>\r\n");
#nullable restore
#line 194 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 196 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                             if (item.external_link != "")
                                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                        <tr>
                                                                            <th scope=""row"" class=""uil uil-link-alt icon_142"" data-icon=""bi:link"" style=""border-bottom: 1px solid #DEE2E5""> External Link</th>
                                                                            <td style=""border-bottom: 1px solid #DEE2E5"">
                                                                                <a style=""border-bottom: 1px solid #DEE2E5"" href=""#""");
                BeginWriteAttribute("onclick", "  onclick=\"", 10563, "\"", 10624, 5);
                WriteAttributeValue("", 10574, "GetContent(\'", 10574, 12, true);
#nullable restore
#line 201 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 10586, item.Topic_id, 10586, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10600, "\',\'", 10600, 3, true);
#nullable restore
#line 201 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 10603, item.external_link, 10603, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 10622, "\')", 10622, 2, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 201 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                                                                                                                                              Write(item.external_link);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                                        </td>\r\n                                                                                </tr>\r\n");
#nullable restore
#line 204 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 206 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                             if (item.attachment != "")
                                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                                <tr>
                                                                                    <th scope=""row"" class=""uil uil-file-download-alt bi-filetype-html icon_142"" style=""border-bottom: 1px solid #DEE2E5""> Attachment </th>
                                                                                    <td style=""border-bottom: 1px solid #DEE2E5"">");
#nullable restore
#line 210 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                                                                            Write(item.attachment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                                                </tr>\r\n");
#nullable restore
#line 212 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                        </thead>
                                                                    </table>

                                                                </div>
                                                            </div>
                                                            

                                                            <div class=""ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom mt-3"">
                                                                <a");
                BeginWriteAttribute("href", " href=\"", 12290, "\"", 12362, 2);
                WriteAttributeValue("", 12297, "/StudentArea/StudentTest/IndexStudentTest?Topic_id=", 12297, 51, true);
#nullable restore
#line 221 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"
WriteAttributeValue("", 12348, item.Topic_id, 12348, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">  <h4 style=""font-size:1.27em""> <i class="" uil uil-file-question-alt ""> <span class=""section-title-text"">Test </span></i></h4></a>
                                                                <div class=""mt-3"">
                                                                    
                                                                </div>
                                                            </div>

                                                        </div>




                                                    </div>
");
#nullable restore
#line 233 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\TeacherArea\Views\CourseDetails\IndexCourseDetails.cshtml"

                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                            </div>
                                            <!--<div class=""section-header-right"">
                                                <span class=""num-items-in-section"">8 lectures</span>
                                                <span class=""section-header-length"">22:08</span>
                                            </div>-->
                                
                                      
                                      
                                    </div>
                                    <a class=""btn1458"" href=""#""> More Sections</a>
                                </div>
                            </div>
                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

 
    <script data-cfasync=""false"" src=""../../cdn-cgi/scripts/5c5dd728/cloudflare-static/email-decode.min.js""></script>
    <script src=""js/vertic");
                WriteLiteral(@"al-responsive-menu.min.js""></script>
    <script src=""js/jquery-3.3.1.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""vendor/OwlCarousel/owl.carousel.js""></script>
    <script src=""vendor/semantic/semantic.min.js""></script>
    <script src=""js/custom.js""></script>
    <script src=""js/night-mode.js""></script>



    <script type=""text/javascript"">
        function GetContent(TopicId,urlval) {

            $.ajax({
                url: '/TeacherArea/CourseDetails/Userlog',
                type: 'POST',
                data: { TId: TopicId},
                dataType: 'html',
                success: function (result) {

                    window.location.href = urlval;
                  
                },
                error: function () { alert(""Whooaaa! Something went wrong.."") },
            });
        }

        function Save(CourseId) {
            $.ajax({
                url: '/TeacherArea/CourseDetails/SaveCourse");
                WriteLiteral(@"',
                type: 'POST',
                data: { CId: CourseId },
                dataType: 'html',
                success: function (result) {
                    $(document).ready(function () {
                        $("".heart"").click(function () {
                            $(this).toggleClass(""heart"");

                        });
                    });
                },
                error: function () { alert(""Whooaaa! Something went wrong.."") },
            });
            
        }
    </script>
");
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
            WriteLiteral("\r\n");
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
