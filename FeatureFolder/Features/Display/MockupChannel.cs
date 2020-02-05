using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureFolder.Features.Display
{
    public class MockupChannel : DisplayChannel { 
        public override string ChannelName { 
            get { return "mockup"; } 
        } 
        public override bool IsActive(HttpContextBase context) { return context.Request.Browser.IsMobileDevice; } }
}