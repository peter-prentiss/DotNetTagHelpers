﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DotNetTagHelpers.Infrastructure.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")]
    [HtmlTargetElement("a", Attributes = "bs-button-color", ParentTag = "form")]
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonColor { get; set; }
        public override void Process(TagHelperContext context,
        TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"btn btn-{BsButtonColor}");
        }
    }
}
