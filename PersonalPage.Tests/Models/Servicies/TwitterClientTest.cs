using System;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models.Servicies.Twitter;
using Spring.Context;

namespace PersonalPage.Tests.Models.Servicies
{ 
    [TestFixture]
    public class TwitterClientTest
    {
        [Test, Category("UnitTest")]
        public void DoesGetUserTimelineJsonThrowsArgumentNullException()
        {
            // try instantiating context
            IApplicationContext ctx = ContextHelper.GetProductionContext();

            // try resolving FroniusMonitor
            var twitterClient = (TwitterClient)ctx.GetObject("TwitterClient");

            Assert.Throws<ArgumentNullException>(() => twitterClient.GetRequest(null));
        }
    }
}
