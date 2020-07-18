#pragma checksum "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5a2aa055f95081c1707f17d9b29601287f0efd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Members), @"mvc.1.0.view", @"/Views/Room/Members.cshtml")]
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
#line 1 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/_ViewImports.cshtml"
using MentorMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/_ViewImports.cshtml"
using MentorMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5a2aa055f95081c1707f17d9b29601287f0efd8", @"/Views/Room/Members.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbab53756600d2da816218cdb97ce93e400b173e", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Members : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MentorMe.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
  
    Layout = "~/Views/Shared/_MainLayout.cshtml";
    ViewData["Title"] = "Members";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr>

<style>
    .outer {
        position: relative;
        margin: auto auto auto 10px;
        width: 50px;
        cursor: pointer;
    }

    .inner {
        width: inherit;
        text-align: center;
    }

    label {
        font-size: .8em;
        line-height: 2em;
        text-transform: uppercase;
        color: red;
        transition: all .3s ease-in;
        opacity: 0;
        cursor: pointer;
        margin-bottom: 0px !important;
    }

    .inner:before, .inner:after {
        position: absolute;
        content: '';
        height: 1px;
        width: inherit;
        background: red;
        left: 0;
        transition: all .3s ease-in;
    }

    .inner:before {
        top: 50%;
        transform: rotate(45deg);
    }

    .inner:after {
        bottom: 50%;
        transform: rotate(-45deg);
    }

    .outer:hover label {
        opacity: 1;
    }

    .outer:hover .inner:before,
    .outer:hover .inner:after {
        transform:");
            WriteLiteral(" rotate(0);\r\n    }\r\n\r\n    .outer:hover .inner:before {\r\n        top: 0;\r\n    }\r\n\r\n    .outer:hover .inner:after {\r\n        bottom: 0;\r\n    }\r\n</style>\r\n\r\n");
#nullable restore
#line 73 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
 if (!ViewBag.isAdmin)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"display:flex; flex-direction:row; justify-content: space-evenly;\">\r\n\r\n        <div class=\"lefty\" style=\"width:30%;\">\r\n            <p style=\"color:blue\"> Room Mentors :</p>\r\n\r\n\r\n");
#nullable restore
#line 82 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
             if (ViewBag.NoMentors)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size: small; color:grey;\">-Room without mentors </p>\r\n");
#nullable restore
#line 85 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

              
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-group\">\r\n");
#nullable restore
#line 91 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                     foreach (var mentors in ViewBag.Mentors)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"margin-bottom:5px;\" class=\"list-group-item list-group-item-action list-group-item-success\">");
#nullable restore
#line 94 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                                                                                                                        Write(mentors.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 95 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 99 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n        <div class=\"righty\" style=\"width:30%;\">\r\n            <p style=\"color:blue\"> Room Subscribers:</p>\r\n\r\n\r\n");
#nullable restore
#line 107 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
             if (ViewBag.NoSubscribers)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size: small; color:grey;\">-Room without subscribers: </p>\r\n");
#nullable restore
#line 110 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

             
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"list-group\">\r\n");
#nullable restore
#line 116 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                     foreach (var subscribers in ViewBag.Subscribers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a style=\"margin-bottom:5px;\" class=\"list-group-item list-group-item-action list-group-item-success\">");
#nullable restore
#line 118 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                                                                                                                        Write(subscribers.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 119 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 124 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 128 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"display:flex; flex-direction:row; justify-content: space-evenly;\">\r\n\r\n    <div class=\"lefty\" style=\"width:30%;\">\r\n        <p style=\"color:blue\"> Room Mentors:</p>\r\n\r\n\r\n");
#nullable restore
#line 138 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
         if (ViewBag.NoMentors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-size: small; color:grey;\">--Room without mentors  </p>\r\n");
#nullable restore
#line 141 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"


        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list-group\">\r\n");
#nullable restore
#line 147 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                 foreach (var mentors in ViewBag.Mentors)
                {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"margin-bottom:5px;\" id=\"button\" onclick=\"return myFunc()\"");
            BeginWriteAttribute("href", " href=\'", 3417, "\'", 3482, 1);
#nullable restore
#line 151 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue("", 3424, Url.Action("Demote", "Room", new { id = mentors.UserID }), 3424, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action list-group-item-success teste \">");
#nullable restore
#line 151 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                                                                                                                                                                                                                                   Write(mentors.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 152 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 156 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n    <div class=\"righty\" style=\"width:30%;\">\r\n        <p style=\"color:blue\"> Room Subscribers :</p>\r\n\r\n\r\n");
#nullable restore
#line 164 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
         if (ViewBag.NoSubscribers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-size: small; color:grey;\">-Room without subscribers !</p>\r\n");
#nullable restore
#line 167 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"


        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"list-group\">\r\n");
#nullable restore
#line 173 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
         foreach (var subscribers in ViewBag.Subscribers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"display: flex\">\r\n                <a style=\"margin-bottom:5px;\" id=\"button\" onclick=\"return myFunc()\"");
            BeginWriteAttribute("href", " href=\'", 4157, "\'", 4227, 1);
#nullable restore
#line 176 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue("", 4164, Url.Action("Promote", "Room", new { id = subscribers.UserID }), 4164, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action list-group-item-success teste \">");
#nullable restore
#line 176 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
                                                                                                                                                                                                                                    Write(subscribers.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                <div class=\"outer\">\r\n                    <div class=\"inner\">\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4440, "\"", 4486, 3);
            WriteAttributeValue("", 4450, "showDeleteModal(", 4450, 16, true);
#nullable restore
#line 180 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue("", 4466, subscribers.UserID, 4466, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4485, ")", 4485, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >\r\n                            <label>Remove</label>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 4666, "\"", 4693, 2);
            WriteAttributeValue("", 4671, "id", 4671, 2, true);
#nullable restore
#line 189 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue(" ", 4673, subscribers.UserID, 4674, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"modal\">\r\n                <span onclick=\"document.getElementById(\'id01\').style.display=\'none\'\" class=\"close\" title=\"Close Modal\">×</span>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5a2aa055f95081c1707f17d9b29601287f0efd815461", async() => {
                WriteLiteral(@"
                    <div class=""container"">
                        <h1>Kick Member</h1>
                        <p>Are you sure you want to kick this member?</p>

                        <div class=""clearfix"">
                            <button type=""button""");
                BeginWriteAttribute("onclick", " onclick=\"", 5177, "\"", 5257, 3);
                WriteAttributeValue("", 5187, "document.getElementById(\'id", 5187, 27, true);
#nullable restore
#line 197 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue(" ", 5214, subscribers.UserID, 5215, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5234, "\').style.display=\'none\'", 5234, 23, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"cancelbtn\">Cancel</button>\r\n                            <a");
                BeginWriteAttribute("href", " href=\'", 5324, "\'", 5397, 1);
#nullable restore
#line 198 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue("", 5331, Url.Action("KickMember", "Room", new { id = subscribers.UserID }), 5331, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" > \r\n                            <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5452, "\"", 5532, 3);
                WriteAttributeValue("", 5462, "document.getElementById(\'id", 5462, 27, true);
#nullable restore
#line 199 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
WriteAttributeValue(" ", 5489, subscribers.UserID, 5490, 19, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5509, "\').style.display=\'none\'", 5509, 23, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"deletebtn\">Delete</button>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 205 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 208 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n  \r\n\r\n</div>\r\n");
#nullable restore
#line 216 "/Users/etiennecosta/Desktop/LI4/MentorMe/Views/Room/Members.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>

    function showDeleteModal(n) {

        // Get the modal

        var modal = document.getElementById('id ' + n);
        modal.style.display = 'block';
        // When the user clicks anywhere outside of the modal, close it
        window.onclick = function (event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }

    }

</script>


<hr />


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MentorMe.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591
