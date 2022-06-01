using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Phase2Section2._32.TagHelpers
{
    [HtmlTargetElement("email", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";
        public string MailTo { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";  //Replaces <email> with <a> tag
            var content = await output.GetChildContentAsync();
            var target = content.GetContent() + "@" + EmailDomain;
            var outputContent = "Email " + content.GetContent();
            if (MailTo != null)
            {
                target = MailTo;
                outputContent = content.GetContent();
            }
            
            output.Attributes.SetAttribute("href", "mailto:" + target);
            output.Content.SetContent(outputContent);
        }

    }
}
