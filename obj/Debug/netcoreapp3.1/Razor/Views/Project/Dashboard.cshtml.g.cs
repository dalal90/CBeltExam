#pragma checksum "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "273746c429ba7ed30bb1c2790c4988c022f29c3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Dashboard), @"mvc.1.0.view", @"/Views/Project/Dashboard.cshtml")]
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
#line 1 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273746c429ba7ed30bb1c2790c4988c022f29c3e", @"/Views/Project/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d189d26e11bce5b0217e3cabc89937ce4ea744", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hobby>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
  
    int UserID = (int)Context.Session.GetInt32("uid");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""header"">
    <h3>Welcome !! </h3>
        <h3>Success Login</h3>
    <p><a href=""/logout"">Log Out</a></p>
</div>
<div>
    <a href=""/hobby/new""><button>Create a Hobby</button></a>
</div>
<div class=""content"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <td>Name</td>
                <td>Enthusiasts</td>
                <td>Action</td>

            </tr>
        </thead>
<tbody>
");
#nullable restore
#line 24 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
              
                foreach (Hobby e in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 675, "\"", 699, 2);
            WriteAttributeValue("", 682, "/hobby/", 682, 7, true);
#nullable restore
#line 28 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
WriteAttributeValue("", 689, e.HobbyId, 689, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
                                                   Write(e.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
                       Write(e.Enthusiasts.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 31 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
                              
                                // if this user is creator, delete button
                                if (e.Creator.UserId == UserID)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"><button>Edit Event</button></a>\r\n");
#nullable restore
#line 36 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1240, "\"", 1269, 2);
            WriteAttributeValue("", 1247, "/hobby/join/", 1247, 12, true);
#nullable restore
#line 40 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
WriteAttributeValue("", 1259, e.HobbyId, 1259, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Add to Hobbies</button></a>\r\n");
#nullable restore
#line 41 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
                                }
                                // else if joined, unjoin, and vice versa
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Dalal Aljohani\Desktop\BootCamp\BeltExam\Views\Project\Dashboard.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hobby>> Html { get; private set; }
    }
}
#pragma warning restore 1591
