#pragma checksum "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f135963191b9caba55a2a48c4a4a51aa6670f6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monsters_Index), @"mvc.1.0.view", @"/Views/Monsters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monsters/Index.cshtml", typeof(AspNetCore.Views_Monsters_Index))]
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
#line 1 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\_ViewImports.cshtml"
using monster_tracker_asp;

#line default
#line hidden
#line 2 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\_ViewImports.cshtml"
using monster_tracker_asp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f135963191b9caba55a2a48c4a4a51aa6670f6d", @"/Views/Monsters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e840036fb23ca8d2f1728c48155e7d81f6a22e11", @"/Views/_ViewImports.cshtml")]
    public class Views_Monsters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<monster_tracker_asp.Models.Monster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("red-line-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/separator.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
  
    ViewData["Title"] = "Monsters";
    

#line default
#line hidden
            BeginContext(104, 90, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <section>\r\n        <div class=\"filter-block\">\r\n            ");
            EndContext();
            BeginContext(194, 265, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c83b7d246460432984c3e8411edb9218", async() => {
                BeginContext(214, 238, true);
                WriteLiteral("\r\n                Name: <input type=\"text\" name=\"search-name\" placeholder=\"Creature name\" class=\"filter-search-name\">\r\n\r\n                <button type=\"submit\" name=\"filter-button\" class=\"filter-search-button\">Filter</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(459, 51, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </section>\r\n    <section>\r\n");
            EndContext();
#line 19 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(612, 51, true);
            WriteLiteral("        <div class=\"stat-block-template-wrapper\">\r\n");
            EndContext();
            BeginContext(700, 58, true);
            WriteLiteral("            <button type=\"button\" class=\"btn-collapsible\">");
            EndContext();
            BeginContext(759, 9, false);
#line 23 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(768, 252, true);
            WriteLiteral("</button>\r\n            <div class=\"stat-block-template\">\r\n                <div class=\"stat-block-border\">\r\n                </div>\r\n                <div class=\"stat-block-inner\">\r\n                    <div class=\"stat-name red\">\r\n                        ");
            EndContext();
            BeginContext(1021, 9, false);
#line 29 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 112, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"stat-type black italic\">\r\n                        ");
            EndContext();
            BeginContext(1143, 9, false);
#line 32 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                   Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                         foreach (var x in item.Type)
                        {
                            if (x.TypeCode == "subtype")
                            {
                                

#line default
#line hidden
            BeginContext(1363, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1366, 6, false);
#line 37 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                   Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 1, true);
            WriteLiteral(")");
            EndContext();
#line 37 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                       
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(1517, 6, false);
#line 41 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                 Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1523, 1, true);
            WriteLiteral(",");
            EndContext();
#line 41 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                     
                            }
                        }

#line default
#line hidden
            BeginContext(1591, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1616, 14, false);
#line 44 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                   Write(item.Alignment);

#line default
#line hidden
            EndContext();
            BeginContext(1630, 77, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"stat-red-line\">");
            EndContext();
            BeginContext(1707, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "468b4730fdd54ed793fa4c78c5e76937", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1764, 153, true);
            WriteLiteral("</div>\r\n                    <div class=\"stat-armor red bold\">\r\n                        Armor class\r\n                        <span class=\"armor text red\">");
            EndContext();
            BeginContext(1918, 15, false);
#line 49 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                Write(item.ArmorClass);

#line default
#line hidden
            EndContext();
            BeginContext(1933, 191, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"stat-hit-points red bold\">\r\n                        Hit points\r\n                        <span class=\"hit-points text red\">");
            EndContext();
            BeginContext(2125, 14, false);
#line 53 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                     Write(item.HitPoints);

#line default
#line hidden
            EndContext();
            BeginContext(2139, 176, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"stat-speed red bold\">\r\n                        Speed\r\n                        <span class=\"speed text red\">");
            EndContext();
            BeginContext(2316, 10, false);
#line 57 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                Write(item.Speed);

#line default
#line hidden
            EndContext();
            BeginContext(2326, 84, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"stat-red-line\">");
            EndContext();
            BeginContext(2410, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e5e668563b64150933d25edc090f351", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2467, 725, true);
            WriteLiteral(@"</div>
                    <div class=""stat-ability-scores"">
                        <table class=""ability-scores-list"">
                            <tr>
                                <td class=""ability-score-title red bold"">STR</td>
                                <td class=""ability-score-title red bold"">DEX</td>
                                <td class=""ability-score-title red bold"">CON</td>
                                <td class=""ability-score-title red bold"">INT</td>
                                <td class=""ability-score-title red bold"">WIS</td>
                                <td class=""ability-score-title red bold"">CHA</td>
                            </tr>
                            <tr>
");
            EndContext();
#line 71 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                 foreach (var x in item.Score)
                                {
                                    if (x.ScoreTypeCode == "ability")
                                    {

#line default
#line hidden
            BeginContext(3401, 83, true);
            WriteLiteral("                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(3485, 10, false);
#line 75 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Strength);

#line default
#line hidden
            EndContext();
            BeginContext(3495, 95, true);
            WriteLiteral(" (+5)</td>\r\n                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(3591, 11, false);
#line 76 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Dexterity);

#line default
#line hidden
            EndContext();
            BeginContext(3602, 95, true);
            WriteLiteral(" (+1)</td>\r\n                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(3698, 14, false);
#line 77 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Constitution);

#line default
#line hidden
            EndContext();
            BeginContext(3712, 95, true);
            WriteLiteral(" (+1)</td>\r\n                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(3808, 14, false);
#line 78 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Intelligence);

#line default
#line hidden
            EndContext();
            BeginContext(3822, 95, true);
            WriteLiteral(" (+1)</td>\r\n                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(3918, 8, false);
#line 79 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Wisdom);

#line default
#line hidden
            EndContext();
            BeginContext(3926, 95, true);
            WriteLiteral(" (+1)</td>\r\n                                        <td class=\"ability-score-content text red\">");
            EndContext();
            BeginContext(4022, 10, false);
#line 80 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              Write(x.Charisma);

#line default
#line hidden
            EndContext();
            BeginContext(4032, 12, true);
            WriteLiteral(" (+1)</td>\r\n");
            EndContext();
#line 81 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(4118, 144, true);
            WriteLiteral("                            </tr>\r\n                        </table>\r\n                    </div>\r\n                    <div class=\"stat-red-line\">");
            EndContext();
            BeginContext(4262, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a611d2f016384b57b8db563285daa28b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4319, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 87 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                     if (item.Score.Count > 1)
                    {


#line default
#line hidden
            BeginContext(4400, 165, true);
            WriteLiteral("                    <div class=\"stat-saving-throws red bold\">\r\n                        Saving Throws\r\n                        <span class=\"saving-throws text red\">\r\n");
            EndContext();
#line 93 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             foreach (var x in item.Score)
                            {
                                if (x.ScoreTypeCode == "save")
                                {
                                    

#line default
#line hidden
            BeginContext(4793, 56, false);
#line 97 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Strength != null ? "STR +" + @x.Strength + " " : null);

#line default
#line hidden
            EndContext();
            BeginContext(4890, 58, false);
#line 98 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Dexterity != null ? "DEX +" + @x.Dexterity + " " : null);

#line default
#line hidden
            EndContext();
            BeginContext(4989, 64, false);
#line 99 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Constitution != null ? "CON +" + @x.Constitution + " " : null);

#line default
#line hidden
            EndContext();
            BeginContext(5094, 64, false);
#line 100 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Intelligence != null ? "INT +" + @x.Intelligence + " " : null);

#line default
#line hidden
            EndContext();
            BeginContext(5199, 52, false);
#line 101 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Wisdom != null ? "WIS +" + @x.Wisdom + " " : null);

#line default
#line hidden
            EndContext();
            BeginContext(5292, 50, false);
#line 102 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                Write(@x.Charisma != null ? "CHA +" + @x.Charisma : null);

#line default
#line hidden
            EndContext();
#line 102 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                                         
                                }
                            }

#line default
#line hidden
            BeginContext(5411, 61, true);
            WriteLiteral("                        </span>\r\n                    </div>\r\n");
            EndContext();
#line 107 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(5495, 160, true);
            WriteLiteral("                    <div class=\"stat-ability-skills red bold\">\r\n                        Skills\r\n                        <span class=\"ability-skills text red\">\r\n");
            EndContext();
#line 111 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             if (item.Skill.Acrobatics != null)
                            {
                                

#line default
#line hidden
            BeginContext(5789, 10, true);
            WriteLiteral("Acrobatis ");
            EndContext();
            BeginContext(5800, 21, false);
#line 113 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                           Write(item.Skill.Acrobatics);

#line default
#line hidden
            EndContext();
#line 113 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                             
                            }

#line default
#line hidden
            BeginContext(5861, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 115 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             if (item.Skill.History != null)
                            {
                                

#line default
#line hidden
            BeginContext(5992, 8, true);
            WriteLiteral("History ");
            EndContext();
            BeginContext(6001, 18, false);
#line 117 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                         Write(item.Skill.History);

#line default
#line hidden
            EndContext();
#line 117 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                        
                            }

#line default
#line hidden
            BeginContext(6059, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 119 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             if (item.Skill.Insight != null)
                            {
                                

#line default
#line hidden
            BeginContext(6190, 8, true);
            WriteLiteral("Insight ");
            EndContext();
            BeginContext(6199, 18, false);
#line 121 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                         Write(item.Skill.Insight);

#line default
#line hidden
            EndContext();
#line 121 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                        
                            }

#line default
#line hidden
            BeginContext(6257, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 123 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             if (item.Skill.Medicine != null)
                            {
                                

#line default
#line hidden
            BeginContext(6389, 9, true);
            WriteLiteral("Medicine ");
            EndContext();
            BeginContext(6399, 19, false);
#line 125 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                          Write(item.Skill.Medicine);

#line default
#line hidden
            EndContext();
#line 125 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                          
                            }

#line default
#line hidden
            BeginContext(6458, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 127 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                             if (item.Skill.Perception != null)
                            {
                                

#line default
#line hidden
            BeginContext(6592, 11, true);
            WriteLiteral("Perception ");
            EndContext();
            BeginContext(6604, 21, false);
#line 129 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                            Write(item.Skill.Perception);

#line default
#line hidden
            EndContext();
#line 129 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                              
                            }

#line default
#line hidden
            BeginContext(6665, 61, true);
            WriteLiteral("                        </span>\r\n                    </div>\r\n");
            EndContext();
#line 133 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                     if (item.Vulnerability != null)
                    {

#line default
#line hidden
            BeginContext(6803, 188, true);
            WriteLiteral("                        <div class=\"stat-vulnerabilities red bold\">\r\n                            Damage vulnerabilities\r\n                            <span class=\"vulnerabilities text red\">");
            EndContext();
            BeginContext(6992, 18, false);
#line 137 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                              Write(item.Vulnerability);

#line default
#line hidden
            EndContext();
            BeginContext(7010, 41, true);
            WriteLiteral("</span>\r\n                        </div>\r\n");
            EndContext();
#line 139 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7074, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 140 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                     if (item.Resistance != null)
                    {

#line default
#line hidden
            BeginContext(7148, 176, true);
            WriteLiteral("                        <div class=\"stat-resistances red bold\">\r\n                            Damage resistances\r\n                            <span class=\"resistances text red\">");
            EndContext();
            BeginContext(7325, 15, false);
#line 144 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                          Write(item.Resistance);

#line default
#line hidden
            EndContext();
            BeginContext(7340, 41, true);
            WriteLiteral("</span>\r\n                        </div>\r\n");
            EndContext();
#line 146 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7404, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 147 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                     if (item.Immunity != null)
                    {

#line default
#line hidden
            BeginContext(7476, 172, true);
            WriteLiteral("                        <div class=\"stat-immunities red bold\">\r\n                            Damage immunities\r\n                            <span class=\"immunitiestext red\">");
            EndContext();
            BeginContext(7649, 13, false);
#line 151 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                        Write(item.Immunity);

#line default
#line hidden
            EndContext();
            BeginContext(7662, 41, true);
            WriteLiteral("</span>\r\n                        </div>\r\n");
            EndContext();
#line 153 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7726, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 154 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                     if (item.ConditionImmunity != null)
                    {

#line default
#line hidden
            BeginContext(7807, 196, true);
            WriteLiteral("                        <div class=\"stat-condition-immunities red bold\">\r\n                            Condition immunities\r\n                            <span class=\"condition-immunities text red\">");
            EndContext();
            BeginContext(8004, 22, false);
#line 158 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                                   Write(item.ConditionImmunity);

#line default
#line hidden
            EndContext();
            BeginContext(8026, 41, true);
            WriteLiteral("</span>\r\n                        </div>\r\n");
            EndContext();
#line 160 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8090, 142, true);
            WriteLiteral("                    <div class=\"stat-senses red bold\">\r\n                        Senses\r\n                        <span class=\"senses text red\">");
            EndContext();
            BeginContext(8233, 10, false);
#line 163 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                 Write(item.Sense);

#line default
#line hidden
            EndContext();
            BeginContext(8243, 188, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"stat-languages red bold\">\r\n                        Languages\r\n                        <span class=\"languages text red\">");
            EndContext();
            BeginContext(8432, 13, false);
#line 167 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                    Write(item.Language);

#line default
#line hidden
            EndContext();
            BeginContext(8445, 213, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"stat-challenge-rating red bold\">\r\n                        Challenge Rating\r\n                        <span class=\"challenge-rating red not-bold\">");
            EndContext();
            BeginContext(8659, 20, false);
#line 171 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
                                                               Write(item.ChallengeRating);

#line default
#line hidden
            EndContext();
            BeginContext(8679, 37, true);
            WriteLiteral("</span>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(10267, 133, true);
            WriteLiteral("                </div>\r\n                <div class=\"stat-block-border\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 197 "D:\work\ASP .net core mvc\monster-tracker-asp\Views\Monsters\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(10411, 26, true);
            WriteLiteral("\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<monster_tracker_asp.Models.Monster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
