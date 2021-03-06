#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\MVC-FRONTEND\MVC-FRONTEND\Views\Contact\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c51865f852bb362e25980f56753565d6387a78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Contact), @"mvc.1.0.view", @"/Views/Contact/Contact.cshtml")]
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
#line 1 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\MVC-FRONTEND\MVC-FRONTEND\Views\_ViewImports.cshtml"
using MVC_FRONTEND;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\MVC-FRONTEND\MVC-FRONTEND\Views\_ViewImports.cshtml"
using MVC_FRONTEND.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c51865f852bb362e25980f56753565d6387a78", @"/Views/Contact/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaacb3572841b08a585fa41cfcd1fe4128dac39f", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""contact-main"">
    <div class=""container"">
        <div class=""row"">
            <h1>CONTACT US</h1>

            <p>We've found most questions can be answered or solved without contacting our team.</p>
            <h3>Start a Return or Exchange? </h3>
            <p>Follow the easy steps in our return portal here:<a href=""#"">https://killcrew.co/a/returns</a></p>
            <h3>What is the status of my Return or Exchange:</h3>
            <p>
                If you have already gone through our online process to return, exchange or get store credit for you
                item please allow 5-7 business days for processing. Once your return is processed someone from our
                team will email you to confirm.
            </p>
            <h3>Where�s my package:</h3>
            <p>
                It's challenging running a small brand right now and things are a bit backed up on our end. Due to
                social distancing we only have 1 person in the warehouse right ");
            WriteLiteral(@"now to process, pack and ship orders.
                Rest assured, we�re working hard to deliver your order as soon as possible, while caring for the
                health and safety of our small crew. We expect most orders to ship in 1-3 weeks. Your tracking link
                will update as soon as your package is picked up by USPS. Don't worry you didn't make a mistake, we
                have your order, and we're taking care of it as fast as we can. Thanks again for having patience
                with us during these times and supporting our brand.
            </p>
            <h3>Where's my order confirmation?</h3>
            <p>
                Did you place the order with a different email than your primary? Did you check your spam folder?
                Maybe you fat fingered it and misspelled it. If you still can't find it, please email us at
                hello@killcrew.co with (Order #, No Confirmation Email) please allow our team 2-4 business days to
                respond.");
            WriteLiteral(@"
            </p>
            <h3>Wrong item delivered or missing item(s):</h3>
            <p>
                If we sent you the wrong order or forgot to put items in your order, please email hello@killcrew.co
                with pictures of the packing slip and item. We will send the correct order out to you after
                confirming.
            </p>
            <h3>Did you enter the wrong shipping address at checkout?</h3>
            <p>
                If you fat fingered your shipping address or simply made a mistake. Email us with subject line
                (Order
                number, shipping address) and include the correct address in the body of your email. Please email
                hello@killcrew.co with
            </p>
            <h3>Tracking number says my package was delivered?</h3>
            <p>
                It happens sometimes, if your tracking information shows �delivered� to your address but you never
                received your package, we ask fo");
            WriteLiteral(@"r you file a �lost� package claim with USPS or UPS:
            </p>
            <p>USPS:<a href=""#"">https://www.usps.com/help/missing-mail.htm</a></p>
            <p>UPS:<a href=""#"">https://www.ups.com/us/en/help-center/sri/infonotice.page</a></p>
            <h3>If you read through our FAQ'S and still need help or have a question please send an email to:</h3>
            <h5>hello@killcrew.co </h5>
            <p>(please include a subject line)</p>
            <div class=""address"">
                <h5>Kill Crew Shipping Address:</h5>
                <p>5490 McFadden Avenue</p>
                <p>Huntington Beach, Ca, 92649</p>
            </div>

            <div class=""row"">
                <div class=""col-12 top-inputs"">
                    <div class="" name-box"">
                        <label for=""name"">
                            Name
                            <span>*</span>
                        </label>
                        <input type=""text"" id=""name"">
                  ");
            WriteLiteral(@"  </div>
                    <div class="" lastname-box"">
                        <label for=""email"">
                            Email
                            <span>*</span>
                        </label>
                        <input type=""email"" id=""email"">
                    </div>
                    <div class=""text"">
                        <label for=""message"">
                            Message
                            <span>*</span>
                        </label>
                        <textarea name=""Message"" id=""message"">Message</textarea>
                    </div>
                    <div class=""send-button"">
                        <button>Send</button>
                    </div>



                </div>
            </div>


        </div>
    </div>

</div>");
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
