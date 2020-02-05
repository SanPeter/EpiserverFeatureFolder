using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace FeatureFolder.Features.Paragraph
{
    [ContentType(DisplayName = "Paragraph", GUID = "3e2ee98d-19b4-472d-8a2d-e9236f9b1224", Description = "")]
    public class ParagraphBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "Content",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Content { get; set; }

    }
}