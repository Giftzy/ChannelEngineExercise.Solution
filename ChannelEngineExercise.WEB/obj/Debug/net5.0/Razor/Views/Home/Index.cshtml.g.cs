#pragma checksum "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b6f75e344ebfc7bc1b0da4cc0fcd9c8ec0fbe12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\_ViewImports.cshtml"
using ChannelEngineExercise.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\_ViewImports.cshtml"
using ChannelEngineExercise.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b6f75e344ebfc7bc1b0da4cc0fcd9c8ec0fbe12", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e485d5bc660ec71d97da7402127720873a8a64c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ChannelEngineExercise.WEB.Models.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var no = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"modal fade\" id=\"mysuccessmodal\" role=\"dialog\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 371, "\"", 384, 0);
            EndWriteAttribute();
            WriteLiteral("><span>×</span></button>\r\n            </div>\r\n\r\n            <div class=\"modal-body\">\r\n\r\n                <div class=\"thank-you-pop\">\r\n                    <img src=\"http://goactionstations.co.uk/wp-content/uploads/2017/03/Green-Round-Tick.png\"");
            BeginWriteAttribute("alt", " alt=\"", 626, "\"", 632, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h1>Success!</h1>
                    <p><label id=""successMsg""></label></p>
                </div>

            </div>

        </div>
    </div>
</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Product Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""productname"" class=""form-control-label"">Name:</label>
                    <input type=""text"" class=""form-control"" id=""productname"" readonly>
                </div>
                <div cla");
            WriteLiteral(@"ss=""form-group"">
                    <label for=""merchant-productno"" class=""form-control-label"">Merchant Product No:</label>
                    <input type=""text"" class=""form-control"" id=""merchant-productno"" readonly>
                </div>
                <div class=""form-group"">
                    <label for=""productstock"" class=""form-control-label"">Stock:</label>
                    <input type=""text"" value=""25"" class=""form-control"" id=""productstock"" readonly>
                    <label id=""stockLocationId"" hidden></label>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-dark"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline-primary"" onclick=""UpdateProductStock()"">Update product stock</button>
            </div>
        </div>
    </div>
</div>

<div class=""whole-wrap"">
    <div class=""container box_1170"">
        <div class=""section-top-border"">
      ");
            WriteLiteral(@"      <h3 class=""mb-30"">Product Listing</h3>
            <div class=""progress-table-wrap"">
                <div class=""progress-table"">
                    <div class=""table-head"">
                        <div class=""serial"">#</div>
                        <div class=""country"">Name</div>
                        <div class=""visit"">GTIN</div>
                        <div class=""percentage"">Quantity</div>
                        <div class=""percentage"">Action</div>
                    </div>
");
#nullable restore
#line 74 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                      
                        if (Model != null && Model.Count > 0)
                        {
                            foreach (var item in Model)
                            {
                                no++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"table-row\">\r\n                                    <div class=\"serial\">");
#nullable restore
#line 81 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                                                   Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"country\"> ");
#nullable restore
#line 82 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"visit\"> ");
#nullable restore
#line 83 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                                                   Write(item.GTIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"percentage\"> ");
#nullable restore
#line 84 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                                                        Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 3830, "\"", 3838, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3839, "\"", 3937, 9);
            WriteAttributeValue("", 3849, "callProductFunc(\'", 3849, 17, true);
#nullable restore
#line 85 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 3866, item.ProductName, 3866, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3883, "\',", 3883, 2, true);
            WriteAttributeValue(" ", 3885, "\'", 3886, 2, true);
#nullable restore
#line 85 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 3887, item.MerchantProductNo, 3887, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3910, "\',", 3910, 2, true);
            WriteAttributeValue(" ", 3912, "\'", 3913, 2, true);
#nullable restore
#line 85 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 3914, item.StockLocationId, 3914, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3935, "\')", 3935, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a href=\"#\" class=\"genric-btn link-border\">Update Product Stock</a>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 89 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                            }
                        }
                        else
                        {
                            no++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"table-row\">\r\n                                No record found!\r\n                            </div>\r\n");
#nullable restore
#line 97 "C:\Users\OGIFT\Desktop\Gift'sPersonalDoc\CodeProjects\Giftzy\ChannelEngineExercise.Solution\ChannelEngineExercise.WEB\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ChannelEngineExercise.WEB.Models.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
