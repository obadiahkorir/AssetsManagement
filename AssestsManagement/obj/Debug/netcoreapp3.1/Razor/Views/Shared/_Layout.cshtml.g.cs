#pragma checksum "C:\Projects\AssestsManagement\AssestsManagement\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee8acbbf572dcf01018dc3ad8aecab13edba5b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Projects\AssestsManagement\AssestsManagement\Views\_ViewImports.cshtml"
using AssestsManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\AssestsManagement\AssestsManagement\Views\_ViewImports.cshtml"
using AssestsManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee8acbbf572dcf01018dc3ad8aecab13edba5b2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50618f4e41ca2d2c49a5217b10ada9a0294451d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideBarMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Scripts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b25226", async() => {
                WriteLiteral("\n   ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b25485", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b27328", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <header class=""main-header"">
            <a href=""index2.html"" class=""logo"">
                <span class=""logo-mini""><b>A</b>LT</span>
                <span class=""logo-lg""><b>Admin</b>LTE</span>
            </a>
            <nav class=""navbar navbar-static-top"">
                <a href=""#"" class=""sidebar-toggle"" data-toggle=""push-menu"" role=""button"">
                    <span class=""sr-only"">Toggle navigation</span>
                </a>

                <div class=""navbar-custom-menu"">
                    <ul class=""nav navbar-nav"">
                        <li class=""dropdown messages-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-envelope-o""></i>
                                <span class=""label label-success"">4</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""header"">You have 4 messages</l");
                WriteLiteral(@"i>
                                <li>
                                    <ul class=""menu"">
                                        <li>
                                            <a href=""#"">
                                                <div class=""pull-left"">
                                                    <img src=""dist/img/user2-160x160.jpg"" class=""img-circle"" alt=""User Image"">
                                                </div>
                                                <h4>
                                                    Support Team
                                                    <small><i class=""fa fa-clock-o""></i> 5 mins</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
             ");
                WriteLiteral(@"                                   <div class=""pull-left"">
                                                    <img src=""dist/img/user3-128x128.jpg"" class=""img-circle"" alt=""User Image"">
                                                </div>
                                                <h4>
                                                    AdminLTE Design Team
                                                    <small><i class=""fa fa-clock-o""></i> 2 hours</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""pull-left"">
                                                    <img src=""dist/img/user4-128x128.jpg"" class=""img-circle"" alt=""User Image"">
              ");
                WriteLiteral(@"                                  </div>
                                                <h4>
                                                    Developers
                                                    <small><i class=""fa fa-clock-o""></i> Today</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""pull-left"">
                                                    <img src=""dist/img/user3-128x128.jpg"" class=""img-circle"" alt=""User Image"">
                                                </div>
                                                <h4>
                                                    Sales Department
                                                 ");
                WriteLiteral(@"   <small><i class=""fa fa-clock-o""></i> Yesterday</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <div class=""pull-left"">
                                                    <img src=""dist/img/user4-128x128.jpg"" class=""img-circle"" alt=""User Image"">
                                                </div>
                                                <h4>
                                                    Reviewers
                                                    <small><i class=""fa fa-clock-o""></i> 2 days</small>
                                                </h4>
                                                <p>Why not buy a new awesome theme?</p>
            ");
                WriteLiteral(@"                                </a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""footer""><a href=""#"">See All Messages</a></li>
                            </ul>
                        </li>
                        <li class=""dropdown notifications-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-bell-o""></i>
                                <span class=""label label-warning"">10</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""header"">You have 10 notifications</li>
                                <li>
                                    <ul class=""menu"">
                                        <li>
                                            <a href=""#"">
                                                <i clas");
                WriteLiteral(@"s=""fa fa-users text-aqua""></i> 5 new members joined today
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""fa fa-warning text-yellow""></i> Very long description here that may not fit into the
                                                page and may cause design problems
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""fa fa-users text-red""></i> 5 new members joined
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                           ");
                WriteLiteral(@"     <i class=""fa fa-shopping-cart text-green""></i> 25 sales made
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <i class=""fa fa-user text-red""></i> You changed your username
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""footer""><a href=""#"">View all</a></li>
                            </ul>
                        </li>
                        <li class=""dropdown tasks-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <i class=""fa fa-flag-o""></i>
                                <span class=""label label-danger"">9</span>
                            </a>
                  ");
                WriteLiteral(@"          <ul class=""dropdown-menu"">
                                <li class=""header"">You have 9 tasks</li>
                                <li>
                                    <ul class=""menu"">
                                        <li>
                                            <a href=""#"">
                                                <h3>
                                                    Design some buttons
                                                    <small class=""pull-right"">20%</small>
                                                </h3>
                                                <div class=""progress xs"">
                                                    <div class=""progress-bar progress-bar-aqua"" style=""width: 20%"" role=""progressbar""
                                                         aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                        <span class=""sr-only"">20% Complete</span>
                               ");
                WriteLiteral(@"                     </div>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <h3>
                                                    Create a nice theme
                                                    <small class=""pull-right"">40%</small>
                                                </h3>
                                                <div class=""progress xs"">
                                                    <div class=""progress-bar progress-bar-green"" style=""width: 40%"" role=""progressbar""
                                                         aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                        <span class=""sr-only"">40% Complete</span>
                                                    <");
                WriteLiteral(@"/div>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <h3>
                                                    Some task I need to do
                                                    <small class=""pull-right"">60%</small>
                                                </h3>
                                                <div class=""progress xs"">
                                                    <div class=""progress-bar progress-bar-red"" style=""width: 60%"" role=""progressbar""
                                                         aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                        <span class=""sr-only"">60% Complete</span>
                                                    </div>
               ");
                WriteLiteral(@"                                 </div>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <h3>
                                                    Make beautiful transitions
                                                    <small class=""pull-right"">80%</small>
                                                </h3>
                                                <div class=""progress xs"">
                                                    <div class=""progress-bar progress-bar-yellow"" style=""width: 80%"" role=""progressbar""
                                                         aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100"">
                                                        <span class=""sr-only"">80% Complete</span>
                                                    </div>
                             ");
                WriteLiteral(@"                   </div>
                                            </a>
                                        </li>
                                    </ul>
                                </li>
                                <li class=""footer"">
                                    <a href=""#"">View all tasks</a>
                                </li>
                            </ul>
                        </li>
                        <li class=""dropdown user user-menu"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">
                                <img src=""dist/img/user2-160x160.jpg"" class=""user-image"" alt=""User Image"">
                                <span class=""hidden-xs"">Alexander Pierce</span>
                            </a>
                            <ul class=""dropdown-menu"">
                                <li class=""user-header"">
                                    <img src=""dist/img/user2-160x160.jpg"" class=""img-circle"" alt=""User Image"">

         ");
                WriteLiteral(@"                           <p>
                                        Alexander Pierce - Web Developer
                                        <small>Member since Nov. 2012</small>
                                    </p>
                                </li>
                                <li class=""user-body"">
                                    <div class=""row"">
                                        <div class=""col-xs-4 text-center"">
                                            <a href=""#"">Followers</a>
                                        </div>
                                        <div class=""col-xs-4 text-center"">
                                            <a href=""#"">Sales</a>
                                        </div>
                                        <div class=""col-xs-4 text-center"">
                                            <a href=""#"">Friends</a>
                                        </div>
                                    </div>
                                </li>
   ");
                WriteLiteral(@"                             <li class=""user-footer"">
                                    <div class=""pull-left"">
                                        <a href=""#"" class=""btn btn-default btn-flat"">Profile</a>
                                    </div>
                                    <div class=""pull-right"">
                                        <a href=""#"" class=""btn btn-default btn-flat"">Sign out</a>
                                    </div>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href=""#"" data-toggle=""control-sidebar""><i class=""fa fa-gears""></i></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b223551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n        <div class=\"content-wrapper\">\n            ");
#nullable restore
#line 252 "C:\Projects\AssestsManagement\AssestsManagement\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        </div>
        <footer class=""main-footer"">
            <div class=""pull-right hidden-xs"">
                <b>Version</b> 2.4.18
            </div>
            <strong>Copyright &copy; 2014-2019 <a href=""https://adminlte.io"">AdminLTE</a>.</strong> All rights
            reserved.
        </footer>
        <aside class=""control-sidebar control-sidebar-dark"" style=""display: none;"">
            <ul class=""nav nav-tabs nav-justified control-sidebar-tabs"">
                <li><a href=""#control-sidebar-home-tab"" data-toggle=""tab""><i class=""fa fa-home""></i></a></li>
                <li><a href=""#control-sidebar-settings-tab"" data-toggle=""tab""><i class=""fa fa-gears""></i></a></li>
            </ul>
            <div class=""tab-content"">
                <div class=""tab-pane"" id=""control-sidebar-home-tab"">
                    <h3 class=""control-sidebar-heading"">Recent Activity</h3>
                    <ul class=""control-sidebar-menu"">
                        <li>
                            <a href=""javascript:");
                WriteLiteral(@"void(0)"">
                                <i class=""menu-icon fa fa-birthday-cake bg-red""></i>

                                <div class=""menu-info"">
                                    <h4 class=""control-sidebar-subheading"">Langdon's Birthday</h4>

                                    <p>Will be 23 on April 24th</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <i class=""menu-icon fa fa-user bg-yellow""></i>

                                <div class=""menu-info"">
                                    <h4 class=""control-sidebar-subheading"">Frodo Updated His Profile</h4>

                                    <p>New phone +1(800)555-1234</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
              ");
                WriteLiteral(@"                  <i class=""menu-icon fa fa-envelope-o bg-light-blue""></i>

                                <div class=""menu-info"">
                                    <h4 class=""control-sidebar-subheading"">Nora Joined Mailing List</h4>

                                    <p>nora@example.com</p>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <i class=""menu-icon fa fa-file-code-o bg-green""></i>

                                <div class=""menu-info"">
                                    <h4 class=""control-sidebar-subheading"">Cron Job 254 Executed</h4>

                                    <p>Execution time 5 seconds</p>
                                </div>
                            </a>
                        </li>
                    </ul>
                    <h3 class=""control-sidebar-heading"">Tasks Progress</h3>
                    ");
                WriteLiteral(@"<ul class=""control-sidebar-menu"">
                        <li>
                            <a href=""javascript:void(0)"">
                                <h4 class=""control-sidebar-subheading"">
                                    Custom Template Design
                                    <span class=""label label-danger pull-right"">70%</span>
                                </h4>

                                <div class=""progress progress-xxs"">
                                    <div class=""progress-bar progress-bar-danger"" style=""width: 70%""></div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <h4 class=""control-sidebar-subheading"">
                                    Update Resume
                                    <span class=""label label-success pull-right"">95%</span>
                                </h4>

                        ");
                WriteLiteral(@"        <div class=""progress progress-xxs"">
                                    <div class=""progress-bar progress-bar-success"" style=""width: 95%""></div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <h4 class=""control-sidebar-subheading"">
                                    Laravel Integration
                                    <span class=""label label-warning pull-right"">50%</span>
                                </h4>

                                <div class=""progress progress-xxs"">
                                    <div class=""progress-bar progress-bar-warning"" style=""width: 50%""></div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href=""javascript:void(0)"">
                                <h4 class=""control-sideba");
                WriteLiteral(@"r-subheading"">
                                    Back End Framework
                                    <span class=""label label-primary pull-right"">68%</span>
                                </h4>

                                <div class=""progress progress-xxs"">
                                    <div class=""progress-bar progress-bar-primary"" style=""width: 68%""></div>
                                </div>
                            </a>
                        </li>
                    </ul>

                </div>
                <div class=""tab-pane"" id=""control-sidebar-stats-tab"">Stats Tab Content</div>
                <div class=""tab-pane"" id=""control-sidebar-settings-tab"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b231146", async() => {
                    WriteLiteral(@"
                        <h3 class=""control-sidebar-heading"">General Settings</h3>

                        <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Report panel usage
                                <input type=""checkbox"" class=""pull-right"" checked>
                            </label>

                            <p>
                                Some information about this general settings option
                            </p>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Allow mail redirect
                                <input type=""checkbox"" class=""pull-right"" checked>
                            </label>

                            <p>
                                Other sets of options are available
                            </p>
                        </div>
           ");
                    WriteLiteral(@"             <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Expose author name in posts
                                <input type=""checkbox"" class=""pull-right"" checked>
                            </label>

                            <p>
                                Allow the user to show his name in blog posts
                            </p>
                        </div>
                        <h3 class=""control-sidebar-heading"">Chat Settings</h3>

                        <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Show me as online
                                <input type=""checkbox"" class=""pull-right"" checked>
                            </label>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Turn of");
                    WriteLiteral(@"f notifications
                                <input type=""checkbox"" class=""pull-right"">
                            </label>
                        </div>

                        <div class=""form-group"">
                            <label class=""control-sidebar-subheading"">
                                Delete chat history
                                <a href=""javascript:void(0)"" class=""text-red pull-right""><i class=""fa fa-trash-o""></i></a>
                            </label>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n        </aside>\n        <div class=\"control-sidebar-bg\"></div>\n    </div>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ee8acbbf572dcf01018dc3ad8aecab13edba5b235498", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
