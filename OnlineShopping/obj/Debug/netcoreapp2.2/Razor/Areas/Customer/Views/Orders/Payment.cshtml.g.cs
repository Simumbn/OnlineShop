#pragma checksum "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\Orders\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c136894c3027b9ef99abdd0333458e6222089ca5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Orders_Payment), @"mvc.1.0.view", @"/Areas/Customer/Views/Orders/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Orders/Payment.cshtml", typeof(AspNetCore.Areas_Customer_Views_Orders_Payment))]
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
#line 1 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShopping;

#line default
#line hidden
#line 2 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\_ViewImports.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c136894c3027b9ef99abdd0333458e6222089ca5", @"/Areas/Customer/Views/Orders/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1692c2495c9d4687dd5fa20601122c0273159d1f", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Orders_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\Orders\Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 3777, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c136894c3027b9ef99abdd0333458e6222089ca54815", async() => {
                BeginContext(53, 3764, true);
                WriteLiteral(@"
    <style>
        * {
            margin: 0;
            padding: 0;
        }

        body {
            height: 100vh;
            overflow: hidden;
            background: linear-gradient(-40deg,white,lightgrey);
            box-sizing: border-box;
            font-family: ""Montserrat"", sans-serif;
        }

        #wrapper {
            height: 480px;
            width: 700px;
            background: #fff;
            border: 1px solid grey;
            border-radius: 10px;
            margin: 3em auto 0 auto;
            overflow: hidden;
            box-shadow: 0px 2px 25px #000;
        }

        .row {
            display: flex;
            justify-content: center;
        }

            .row:nth-of-type(1) .col-xs-5 {
                display: flex;
                flex-direction: column;
                align-items: center;
                background: #e6e6e6;
                /*   border:solid 1px transparent; */
                border-radius: 4px;
       ");
                WriteLiteral(@"         margin: 1em 5px;
            }

                .row:nth-of-type(1) .col-xs-5 #cards {
                    display: flex;
                    flex-direction: row;
                    flex-wrap: nowrap;
                    justify-content: center;
                }

                    .row:nth-of-type(1) .col-xs-5 #cards img {
                        width: 100px;
                        height: 100px;
                    }

            .row:nth-of-type(2) .col-xs-5 {
                display: flex;
                flex-direction: column;
                justify-content: space-around;
                flex-basis: 45%;
            }

                .row:nth-of-type(2) .col-xs-5 input {
                    border: 2px solid lightgrey;
                    height: 35px;
                    border-radius: 10px;
                    padding-left: 10px;
                }

            .row .col-xs-5 input:focus, .row:nth-of-type(3) .col-xs-2 input:focus {
                border-co");
                WriteLiteral(@"lor: green;
                outline: 0;
            }

        label {
            position: relative;
        }

        .fa {
            position: absolute;
            right: 25px;
            bottom: 10px;
        }

        .row-three {
            display: flex;
            justify-content: space-around;
            align-items: baseline;
            align-content: space-between;
            margin: 2em 1em 2.4em 1em;
        }

        .row:nth-of-type(3) .col-xs-2 {
            flex-basis: 50%;
        }

        .row:nth-of-type(3) .col-xs-5 {
            flex-basis: 40%;
            align-items: baseline;
        }

        .row:nth-of-type(3) .col-xs-2 input {
            height: 35px;
            border: 2px solid lightgrey;
            border-radius: 10px;
            padding-left: 10px;
        }

        .row:nth-of-type(3) .col-xs-5 .small {
            font-size: .70em;
        }

        footer {
            height: 80px;
            ;
          ");
                WriteLiteral(@"  background: #e6e6e6;
            display: flex;
            flex-direction: row;
            justify-content: space-between;
            align-items: center;
        }

            footer .btn {
                margin: 50px 15px 55px 15px;
                border-radius: 20px;
                padding: .65em 1.6em;
            }

            footer :nth-child(1) {
                background-color: #fff;
                color: #f62f5e;
            }

            footer :nth-child(2) {
                background-color: #f62f5e;
                color: #fff;
            }

        .col-xs-5.highlight {
            border: solid 1px blue;
        }
    </style>
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
            BeginContext(3824, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3826, 2978, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c136894c3027b9ef99abdd0333458e6222089ca59872", async() => {
                BeginContext(3832, 2661, true);
                WriteLiteral(@"
    <div id=""wrapper"">
        <div class=""row"">
            <div class=""col-xs-5"">
                <div id=""cards"">
                    <img src=""http://icons.iconarchive.com/icons/designbolts/credit-card-payment/256/Visa-icon.png"">
                    <img src=""http://icons.iconarchive.com/icons/designbolts/credit-card-payment/256/Master-Card-icon.png"">
                </div><!--#cards end-->
                <div class=""form-check"">
                    <label class=""form-check-label"" for='card'>
                        <input id=""card"" class=""form-check-input"" type=""checkbox"" value="""">
                        Pay with credit card
                    </label>
                </div>
            </div><!--col-xs-5 end-->
            <div class=""col-xs-5"">
                <div id=""cards"">
                    <img src=""http://icons.iconarchive.com/icons/designbolts/credit-card-payment/256/Paypal-icon.png"">
                </div><!--#cards end-->
                <div class=""form-check"">
     ");
                WriteLiteral(@"               <label class=""form-check-label"" for='paypal'>
                        <input id=""paypal"" class=""form-check-input"" type=""checkbox"" value="""">
                        Pay with PayPal
                    </label>
                </div>
            </div><!--col-xs-5 end-->
        </div><!--row end-->
        <div class=""row"">
            <div class=""col-xs-5"">
                <i class=""fa fa fa-user""></i>
                <label for=""cardholder"">Cardholder's Name</label>
                <input type=""text"" id=""cardholder"">
            </div><!--col-xs-5-->
            <div class=""col-xs-5"">
                <i class=""fa fa-credit-card-alt""></i>
                <label for=""cardnumber"">Card Number</label>
                <input type=""text"" id=""cardnumber"">
            </div><!--col-xs-5-->
        </div><!--row end-->
        <div class=""row row-three"">
            <div class=""col-xs-2"">
                <i class=""fa fa-calendar""></i>
                <label for=""date"">Valid thru</l");
                WriteLiteral(@"abel>
                <input type=""text"" placeholder=""MM/YY"" id=""date"">
            </div><!--col-xs-3-->
            <div class=""col-xs-2"">
                <i class=""fa fa-lock""></i>
                <label for=""date"">CVV / CVC *</label>
                <input type=""text"">
            </div><!--col-xs-3-->
            <div class=""col-xs-5"">
                <span class=""small"">* CVV or CVC is the card security code, unique three digits number on the back of your card seperate from its number.</span>
            </div><!--col-xs-6 end-->
        </div><!--row end-->
        <footer>
            ");
                EndContext();
                BeginContext(6493, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c136894c3027b9ef99abdd0333458e6222089ca513078", async() => {
                    BeginContext(6542, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6558, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(6685, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(6697, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c136894c3027b9ef99abdd0333458e6222089ca514758", async() => {
                    BeginContext(6738, 4, true);
                    WriteLiteral("Next");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6746, 51, true);
                WriteLiteral("\r\n        </footer>\r\n    </div><!--wrapper end-->\r\n");
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
            BeginContext(6804, 173, true);
            WriteLiteral("\r\n<script>\r\n$(\'input[type=\"checkbox\"]\').on(\'click\',function(){\r\nvar selected = $(this).parent().parent().parent();    $(selected).toggleClass(\'highlight\');\r\n});\r\n</script>\r\n");
            EndContext();
#line 214 "F:\BITM\P1\OnlineShopping\OnlineShopping\Areas\Customer\Views\Orders\Payment.cshtml"
  
    ViewData["Title"] = "Payment";

#line default
#line hidden
            BeginContext(7020, 22, true);
            WriteLiteral("\r\n<h1>Payment</h1>\r\n\r\n");
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
