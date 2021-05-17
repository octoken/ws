#pragma checksum "D:\Personal\Daps\ProveToken\provetoken.io\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e92a4f2b77ab71366443d359f260658fdc204fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e92a4f2b77ab71366443d359f260658fdc204fc", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 677, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73b1dfa376e24bce8074c4547e9c8cd7", async() => {
                BeginContext(41, 664, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Online Certification Token</title>
    <meta name=""keywords"" content=""Online Certification Token,oc-token.com,Binance,online certification"" />
    <meta name=""description"" content=""The 1st online decentralized certification platform, Binance Token, online certification, helps companies finding candidates who fit their needs"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <!-- My CSS -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""shortcut icon"" type=""image/png"" href=""/favicon.png"" id=""favicon"" />
");
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
            BeginContext(712, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(714, 11597, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c095ee00a2b246d7be7f6ee04e940e32", async() => {
                BeginContext(720, 11584, true);
                WriteLiteral(@"

    <header class=""header"">
        <div class=""header-container"">
            <div class=""header-logo"">
                <img src=""img/logo64x64.png"" alt=""logo"" class=""logo"">
                <div class=""header-logo__text"">
                    <span>Online Certification Token</span>
                </div>
            </div>

            <!-- header desktop menu -->
            <div class=""header-desktop"">
                <div class=""header-desktop__links"">
                    <a href=""#preview"">Preview</a>
                    <a href=""#actors"">Actors</a>
                    <a href=""#roadmap"">Roadmap</a>
                    <a href=""#links"">Exchanges</a>
                    <a href=""#contact"">Contact Us</a>
                </div>

                <div class=""header-desktop__download"">
                    <a href=""javascript:void(0)"" onclick=""goToWhitepaper()"">Whitepaper</a>
                </div>
            </div>
            <!-- header mobile menu -->
            <div class=""head");
                WriteLiteral(@"er-mobile"" id=""header-mobile"">
                <div class=""icon"" "">
                    <div class=""menuIcon""></div>
                    <div class=""menuIcon""></div>
                    <div class=""menuIcon""></div>
                </div>
                <div class=""header-mobile-menu hide"">
                    <div class=""header-mobile__links"">
                        <a href=""#preview"">Preview</a>
                        <a href=""#actors"">Actors</a>
                        <a href=""#roadmap"">Roadmap</a>
                        <a href=""#links"">Exchanges</a>
                        <a href=""#contact"">Contact</a>
                    </div>

                    <div class=""header-mobile__download"">
                        <a href=""javascript:void(0)"" onclick=""goToWhitepaper()"">Whitepaper</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.header-container -->

    </header>
    <!-- /.header -->
    <section class=""preview"" id=""preview""");
                WriteLiteral(@">
        <div class=""preview-container"">
            <div class=""preview-content"">
                <h1 class=""preview-content__title"">
                    Online Certification Token
                </h1>
                <h2 class=""preview-content__subtitle"">
                    The 1st online decentralized certification platform
                </h2>
                <p class=""preview-content__description"">
                    This is an incentive platform which helps companies to find people who have To accomplish a specific task. Candidates also benefit from using this platform by proving their real expertise.
                </p>

                <button class=""preview-content__download"" onclick=""goToWhitepaper()"">Witepaper</button>
            </div>
            <div class=""preview-image"">
                <img src=""img/content_image.png"" alt=""content image"">
            </div>
        </div>
        <!-- /.preview-container -->
        <div class=""preview-container tokenDetails"">
    ");
                WriteLiteral(@"        <div class=""preview-content"">
                <h1 class=""preview-content__title"">
                    Token Details
                </h1>
                <table>
                    <tr>
                        <td>Token Name</td>
                        <td>Online Certification Token</td>
                    </tr>
                    <tr>
                        <td>Token Compliant</td>
                        <td>BEP-20</td>
                    </tr>
                    <tr>
                        <td>Token Technology Platform</td>
                        <td>Binance</td>
                    </tr>
                    <tr>
                        <td>Token Decimal Points</td>
                        <td>18</td>
                    </tr>
                    <tr>
                        <td>Token Symbol</td>
                        <td>OCT</td>
                    </tr>
                    <tr>
                        <td>Total Supply</td>
                        <td>630 000");
                WriteLiteral(@" 000</td>
                    </tr>
                    <tr>
                        <td>Maximum Supply</td>
                        <td>1 000 000 000</td>
                    </tr>
                </table>
            </div>
            <div class=""preview-image"">
            </div>
        </div>
    </section>
    <!-- /.preview -->
    <section class=""actors"" id=""actors"">
        <div class=""actors-container"">
            <h1>Actors</h1>
            <div class=""actors-content"">
                <div class=""actors-content__element"">
                    <img src=""img/student.png"" alt=""student"">
                    <h2>Candidate</h2>
                    <ul>
                        <li>- free to create an account</li>
                        <li>- pays only for taking tests</li>
                        <li>- share his/her proved expertise</li>
                    </ul>
                </div>
                <div class=""actors-content__element"">
                    <img src=""img/publ");
                WriteLiteral(@"isher.png"" alt=""publisher"">
                    <h2>Publisher</h2>
                    <ul>
                        <li>- fully free</li>
                        <li>- rewarded based on using of tests they create</li>
                        <li>- free to set the price for each test</li>           
                    </ul>
                </div>
                <div class=""actors-content__element"">
                    <img src=""img/company.jpg"" alt=""company"">
                    <h2>Company</h2>
                    <ul>
                        <li>- free to create an account</li>
                        <li>- pays only for using publishers’ tests</li>
                        <li>- demands custom tests</li>
                        <li>- evaluates publishers</li>
                        <li>- selects the right candidates based on their results</li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /.actors-container -->
    </section>
    <!-");
                WriteLiteral(@"- /.actors -->
    <section class=""roadmap"" id=""roadmap"">
        <div class=""roadmap-container"">
            <h1>Roadmap</h1>
            <div class=""roadmap-content"">
                <div class=""roadmap-element-outside-first"">
                    <div class=""roadmap-element__quarter"">
                        <h1>Q2 - 2021</h1>
                        <ul>
                            <li><img src=""img/check.png"" alt=""arrow""> whitepaper release</li>
                            <li><img src=""img/check.png"" alt=""arrow""> presentation website release</li>
                            <li><img src=""img/check.png"" alt=""arrow""> create Binance BEP-20 token</li>
                        </ul>
                    </div>
                    <div class=""roadmap-element__quarter"">
                        <h1>Q4 - 2021</h1>
                        <ul>
                            <li>alpha platform release</li>
                            <li>additional exchange listing</li>
                            <li");
                WriteLiteral(@">start to create partnerships <br />with&nbsp;&nbsp; top publishers</li>
                        </ul>
                    </div>
                </div>
                <div class=""roadmap-element-first"">
                    <span>&lt;</span>
                    <span>&lt;</span>
                </div>
                <div class=""roadmap-element-center"">
                    <div class=""roadmap__progressBar""><span></span></div>
                </div>
                <div class=""roadmap-element-second"">
                    <span>&gt;</span>
                    <span>&gt;</span>
                    <span>&gt;</span>
                </div>
                <div class=""roadmap-element-outside-second"">
                    <div class=""roadmap-element__quarter"">
                        <h1>Q1 - 2021</h1>
                        <ul>
                            <li><img src=""img/check.png"" alt=""arrow""> marketing research</li>
                            <li><img src=""img/check.png"" alt=""arrow""> pro");
                WriteLiteral(@"ject planning</li>
                        </ul>
                    </div>
                    <div class=""roadmap-element__quarter"">
                        <h1>Q3 - 2021</h1>
                        <ul>
                            <li><img src=""img/check.png"" alt=""arrow""> exchange listing</li>
                            <li><img src=""img/check.png"" alt=""arrow""> hire 1 project manager and 2 developers</li>
                            <li>coinmarketap listing</li>
                        </ul>
                    </div>
                    <div class=""roadmap-element__quarter"">
                        <h1>Q1 - 2022</h1>
                        <ul>
                            <li>full web platform release</li>
                            <li>android app release</li>
                            <li>iOS app release</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.roadmap-container -->
    </section>
 ");
                WriteLiteral(@"   <!-- /.roadmap -->
    <section class=""links"" id=""links"">
        <div class=""links-container"">
            <h1>Exchanges</h1>
            <div class=""links-content"">
                <div class=""links-content__item"">
                    <img src=""img/pancake.png"" alt=""Pancake"" class=""logo"">
                </div>
            </div>
        </div>
        <!-- /.links-container -->
    </section>
    <!-- /.links -->
    <section class=""contactUs"" id=""contact"">
        <div class=""contactUs-container"">
            <h1>Contact Us</h1>
            <h2>Got a question? We'll get back to you shortly.</h2>
            <form class=""contactUs-form"">
                <div  class=""contactUs-form__item contactError"">
                     <label id=""lblErrorMessage""></label>
                </div>
                <div class=""contactUs-form__item"">
                    <label for=""question"">Question</label>
                    <textarea id=""txtQuestion""></textarea>
                </div>
         ");
                WriteLiteral(@"       <br>
                <div class=""contactUs-form__item"">
                    <label for=""email"">E-mail</label>
                    <input type=""email"" id=""txtEmail"">
                </div>
                <br>
                <button class=""contactUs-send"" id=""btnSend"" onclick=""return sendEmail();"">Send</button>
                <br />
                <h3 class=""contactUs-form__item sendMessage"">
                    <label id=""lblSendMessage""></label>
                </h3>
            </form>
        </div>
        <!-- /.contactUs-container -->
    </section>
    <!-- /.contactUs -->
    <footer class=""footer"">
        <div class=""footer-container"">
            <h3>Copyright 2021 © Online Certification Token. All Rights Reserved</h3>
            <div class=""footer-social"">
                <a href=""https://twitter.com/onlinecerttoken""><img src=""img/twitter.svg"" alt=""twitter""></a>
            </div>
        </div>
        <!-- /.footer-container -->
    </footer>
    <!-- /.footer");
                WriteLiteral(@" -->
    <!-- Optional JavaScript -->
    <!-- jQuery -->
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous"" defer></script>
    <!-- My JS -->
    <script src=""js/main.js"" defer></script>
");
                EndContext();
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
            BeginContext(12311, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
