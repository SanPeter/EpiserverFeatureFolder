using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using FeatureFolder.Features.Paragraph;


namespace FeatureFolder.Features.Blocks.Paragraph
{
    public class ViewTemplateModelRegistrator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(ParagraphBlock),
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "Paragraph",
                    Description = "Displays a Paragraph",
                    Path = "~/Features/Blocks/Paragraph/ParagraphBlock.cshtml",
                    AvailableWithoutTag = true
                },
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "MockupParagraph",
                    Description = "Displays a paragraph mockup.",
                    Path = "~/Mockups/Blocks/Paragraph/ParagraphBlock.cshtml",
                    Tags = new string[] { "mockup" }
                });
        }
    }
}