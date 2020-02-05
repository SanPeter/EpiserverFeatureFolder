//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using EPiServer;
//using EPiServer.Core;
//using EPiServer.Framework.DataAnnotations;
//using EPiServer.Web;
//using EPiServer.Web.Mvc;

//namespace FeatureFolder.Features.Paragraph
//{
//    public class ParagraphBlockController : BlockController<ParagraphBlock>
//    {
//        public override ActionResult Index(ParagraphBlock currentBlock)
//        {
//            return PartialView("~/Features/Paragraph/ParagraphBlock.cshtml", currentBlock);
//        }
//    }

//    [TemplateDescriptor(Tags = new[] { "mockup" }, AvailableWithoutTag = false)]
//    public class MockupParagraphBlockController : BlockController<ParagraphBlock>
//    {
//        public override ActionResult Index(ParagraphBlock currentBlock)
//        {
//            return PartialView("~/Mockups/Blocks/Paragraph/ParagraphBlock.cshtml", currentBlock);
//        }
//    }
//}
