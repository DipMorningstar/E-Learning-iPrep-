#pragma checksum "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45032b31322fbd62987717c9f7d26be6043e959d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_StudentArea_Views_StudentTest_IndexStudentTest), @"mvc.1.0.view", @"/Areas/StudentArea/Views/StudentTest/IndexStudentTest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45032b31322fbd62987717c9f7d26be6043e959d", @"/Areas/StudentArea/Views/StudentTest/IndexStudentTest.cshtml")]
    public class Areas_StudentArea_Views_StudentTest_IndexStudentTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45032b31322fbd62987717c9f7d26be6043e959d2912", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, shrink-to-fit=9"">
 
    <title>Test View</title>

    <link rel=""icon"" type=""image/png"" href=""../../images/fav.png"">

    <link href=""../../https://fonts.googleapis.com/css?family=Roboto:400,700,500"" rel='stylesheet'>
    <link href='../../vendor/unicons-2.0.1/css/unicons.css' rel='stylesheet'>
    <link href=""../../css/vertical-responsive-menu.min.css"" rel=""stylesheet"">
    <link href=""../../css/style.css"" rel=""stylesheet"">
    <link href=""../../css/responsive.css"" rel=""stylesheet"">
    <link href=""../../css/night-mode.css"" rel=""stylesheet"">

    <link href=""../../vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"">
    <link href=""../../vendor/OwlCarousel/assets/owl.carousel.css"" rel=""stylesheet"">
    <link href=""../../vendor/OwlCarousel/assets/owl.theme.default.min.css"" rel=""stylesheet"">
    <link href=""../../vendor/bootstrap/css/bootstrap.min");
                WriteLiteral(".css\" rel=\"stylesheet\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"../../vendor/semantic/semantic.min.css\">\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45032b31322fbd62987717c9f7d26be6043e959d5114", async() => {
                WriteLiteral(@"
    <!--HEADER PART(LOGO, AND SOME BUTTON)-->
    <header class=""header clearfix"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""back_link"">
                        <a href=""../StudentHome/IndexStudentHome"" class=""hde151"">Back To dasbord</a>
                        <a href=""../StudentHome/IndexStudentHome"" class=""hde152"">Back</a>
                    </div>
                    <div class=""ml_item"">
                        <div class=""main_logo main_logo15"" id=""logo"">
                            <a href=""../StudentHome/IndexStudentHome""><img src=""../../images/logo_iprep.png""");
                BeginWriteAttribute("alt", " alt=\"", 1879, "\"", 1885, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                            <a href=\"../StudentHome/IndexStudentHome\"><img class=\"logo-inverse\" src=\"../../images/logo_iprep.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2022, "\"", 2028, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </header>


  <!--QUESTION, TIMER, ANSWER OPTION -->

    <div class=""wrapper _bg4586 _new89"">
        <div class=""_215b15"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""title125"">
                            <div class=""titleleft"">
                                <div class=""ttl121"">
                                    <nav aria-label=""breadcrumb"">
                                        <ol class=""breadcrumb"">
                                            <li class=""breadcrumb-item""><a href=""../StudentHome/IndexStudentHome"">Home</a></li>

");
                WriteLiteral(@"                                        </ol>
                                    </nav>
                                </div>
                            </div>

                        </div>
                        <div class=""title126"">
                            <h2></h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""faq1256"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6"">
                        <div class=""certi_form rght1528"">
                            <div class=""test_timer_bg"">
                                <ul class=""test_timer_left"">
                                    <li>
                                        <div class=""timer_time"">
                                            <h4>3</h4>
                                            <p>Questions</p>
                                        </div>
        ");
                WriteLiteral(@"                            </li>

                                    <li>
                                        <div class=""timer_time"">
                                            <h4 id=""timer"">10</h4>
                                            <p>Minutes</p>
                                        </div>
                                    </li>
                                   
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-7 col-md-6"">
                        <div class=""certi_form"">
");
#nullable restore
#line 105 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"
                               
                                string startindex = "0";
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"
                             foreach (var item in ViewData["Question"] as List<E_learning.Areas.StudentArea.Model.StudentTest>)
                            {



#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"all_ques_lest\">\r\n                                    <div class=\"ques_item\">\r\n");
#nullable restore
#line 113 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"
                                         if (startindex.ToString() != item.QuestionsId.ToString())
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <div class=\"ques_title\">\r\n                                                ");
#nullable restore
#line 116 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"
                                           Write(item.Questions);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </div>\r\n");
#nullable restore
#line 118 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"

                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        <div class=""ui form"">
                                            <div class=""grouped fields"">
                                                <div class=""field fltr-radio"">
                                                    <div class=""ui radio checkbox"">
                                                        <input type=""radio"" name=""example1"" tabindex=""0"" class=""hidden"">
                                                        <label>");
#nullable restore
#line 126 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"
                                                          Write(item.Question_option);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                    </div>


                                </div>
");
#nullable restore
#line 136 "E:\Internship final project\E-learning\E-learning\E-learning\Areas\StudentArea\Views\StudentTest\IndexStudentTest.cshtml"

                               
                                startindex = item.QuestionsId;


                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <button class=""test_submit_btn"" type=""submit"">Submit Test</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <script data-cfasync=""false"" src=""../../cdn-cgi/scripts/5c5dd728/cloudflare-static/email-decode.min.js""></script>
    <script src=""../../js/jquery-3.3.1.min.js""></script>
    <script src=""../../vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""../../vendor/OwlCarousel/owl.carousel.js""></script>
    <!--<script src=""../../vendor/semantic/semantic.min.js""></script>-->
    <script src=""../../js/custom.js""></script>
    <script type=""text/javascript"">
        document.getElementById('timer').innerHTML =
  10 + "":"" + 00;
startTimer();

function startTimer() {
  var presentTime = document.getElementById('timer').innerHTML;
  var timeArray = presentTime.split(/[:]+/);
  var m = timeArray[0];
  var s = checkSecond((timeArray[1] - 1));
  if(s==59){m=m-1}
  /");
                WriteLiteral(@"/if(m<0){alert('timer completed')}
    
  
  document.getElementById('timer').innerHTML =
    m + "":"" + s;
  console.log(m)
  setTimeout(startTimer, 1000);
}

function checkSecond(sec) {
  if (sec < 10 && sec >= 0) {sec = ""0"" + sec}; // add zero in front of numbers < 10
  if (sec < 0) {sec = ""59""};
  return sec;
}
    </script>


    <script src=""../../js/night-mode.js""></script>

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
            WriteLiteral("\r\n\r\n</html>");
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
