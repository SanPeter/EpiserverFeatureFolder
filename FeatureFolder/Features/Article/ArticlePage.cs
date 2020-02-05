using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Features.Article
{
    [ContentType(DisplayName = "ArticlePage", GUID = "889aab05-02a7-405e-9b5b-ce88478517ee", Description = "")]
    public class ArticlePage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea MainContent { get; set; }

    }
}