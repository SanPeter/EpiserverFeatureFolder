using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace FeatureFolder.Features.Blocks.List
{
    [ContentType(DisplayName = "ListBlock", GUID = "dcb95ad6-a6ce-46af-8185-323f3fa2e453", Description = "")]
    public class ListBlock : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}