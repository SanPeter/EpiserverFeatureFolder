using EPiServer.Framework.Web;
using EPiServer.Web.Mvc;
using FeatureFolder.Features.Paragraph;


namespace FeatureFolder.Features.Blocks.List
{
    public class ViewTemplateModelRegistrator : IViewTemplateModelRegistrator
    {
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(ListBlock),
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "List",
                    Description = "Displays a List",
                    Path = "~/Features/Blocks/List/ListBlock.cshtml",
                    AvailableWithoutTag = true
                },
                new EPiServer.DataAbstraction.TemplateModel()
                {
                    Name = "MockupList",
                    Description = "Displays a List mockup.",
                    Path = "~/Mockups/Blocks/List/ListBlock.cshtml",
                    Tags = new string[] { "mockup" }
                });
        }
    }
}