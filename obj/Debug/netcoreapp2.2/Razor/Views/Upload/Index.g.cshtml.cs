#pragma checksum "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bd28d487c702435416ae23e924b07a95079ea1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Upload_Index), @"mvc.1.0.view", @"/Views/Upload/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Upload/Index.cshtml", typeof(AspNetCore.Views_Upload_Index))]
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
#line 1 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\_ViewImports.cshtml"
using Podcast;

#line default
#line hidden
#line 2 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\_ViewImports.cshtml"
using Podcast.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bd28d487c702435416ae23e924b07a95079ea1", @"/Views/Upload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f9923518f35453d14514479a9dd08185503067", @"/Views/_ViewImports.cshtml")]
    public class Views_Upload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UploadModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPodcast", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("offset-md-2 col-md-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPlaylist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(107, 774, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""row"">
            <ul class=""nav nav-tabs"" id=""manageTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""podcast-tab"" data-toggle=""tab"" href=""#podcast"" role=""tab"" aria-controls=""podcast"" aria-selected=""true"">Podcast</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""playlist-tab"" data-toggle=""tab"" href=""#playlist"" role=""tab"" aria-controls=""playlist"" aria-selected=""false"">Playlist</a>
                </li>
            </ul>
        </div>
        <div class=""tab-content"">
            <div class=""tab-pane active"" id=""podcast"" role=""tabpanel"" aria-labelledby=""podcast-tab"">
");
            EndContext();
#line 21 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                 if (Model.Playlists.Count() > 0)
                {

#line default
#line hidden
            BeginContext(951, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(971, 1930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bd28d487c702435416ae23e924b07a95079ea16727", async() => {
                BeginContext(1068, 188, true);
                WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            <label for=\"PodcastPlaylist\">Playlist</label>\r\n                            <select id=\"PodcastPlaylist\">\r\n");
                EndContext();
#line 28 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                                 foreach (var option in Model.Playlists)
                                {

#line default
#line hidden
                BeginContext(1365, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1401, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bd28d487c702435416ae23e924b07a95079ea17690", async() => {
                    BeginContext(1410, 42, false);
#line 30 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => option.Title));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1461, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(1498, 1396, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""PodcastTitle"">Titel</label>
                            <input id=""PodcastTitle"" type=""text"" name=""PodcastTitle"" placeholder=""Titel"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""PodcastDescription"">Beschrijving</label>
                            <textarea id=""PodcastDescription"" name=""PodcastDescription""></textarea>
                        </div>
                        <div class=""form-group"">
                            <label for=""PodcastAgeRestriction"">Leeftijdsbeperking (18+)</label>
                            <input id=""PodcastAgeRestriction"" type=""checkbox"" name=""PodcastAgeRestriction"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""PodcastImage"">Afbeelding</label>
              ");
                WriteLiteral(@"              <input id=""PodcastImage"" type=""file"" name=""PodcastImage"" />
                        </div>
                        <div class=""form-group"">
                            <label for=""PodcastAudio"">Audio-file</label>
                            <input id=""PodcastAudio"" type=""file"" name=""PodcastAudio"" />
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2901, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2963, 214, true);
            WriteLiteral("                    <div>\r\n                        <h2>U heeft nog geen afspeellijst(en)</h2><br />\r\n                        <p>Ga naar \"Playlist\" om een afspeellijst toe te voegen</p>\r\n                    </div>\r\n");
            EndContext();
#line 62 "C:\Users\Gebruiker\Desktop\Podcast\Podcast\Podcast\Views\Upload\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3196, 133, true);
            WriteLiteral("            </div>\r\n            <div class=\"tab-pane\" id=\"playlist\" role=\"tabpanel\" aria-labelledby=\"playlist-tab\">\r\n                ");
            EndContext();
            BeginContext(3329, 1076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bd28d487c702435416ae23e924b07a95079ea113512", async() => {
                BeginContext(3457, 941, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""PlaylistTitle"">Titel</label>
                        <input type=""text"" class=""form-control"" id=""PlaylistTitle"" name=""PlaylistTitle"" placeholder=""Titel"">
                    </div>
                    <div class=""form-group"">
                        <label for=""PlaylistDescription"">Description</label>
                        <input type=""text"" class=""form-control"" id=""PlaylistDescription"" name=""PlaylistDescription"" placeholder=""Beschrijving"">
                    </div>
                    <div class=""form-group"">
                        <label for=""PlaylistImage"">Afbeelding</label>
                        <input type=""file"" class=""form-control"" id=""PlaylistImage"" name=""PlaylistImage"" placeholder=""Afbeelding"">
                    </div>
                    <button type=""submit"" class=""btn login-btn"">Toevoegen</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4405, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UploadModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
