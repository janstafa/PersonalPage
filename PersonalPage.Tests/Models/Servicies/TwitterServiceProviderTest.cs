using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using NUnit.Framework;
using PersonalPage.Models.Servicies.Twitter;
using PersonalPage.Tests.Helpers;

namespace PersonalPage.Tests.Models.Servicies
{
    [TestFixture, Category("UnitTest")]
    public class TwitterServiceProviderTest
    {
        [Test]
        public void GetUserTimeline()
        {
            var container = ContainerHelperTest.GetBuilder();
            var twitterClient = MockingHelper.GetITwitterClientMockReturnsUserTweetsJsonString();
            container.RegisterInstance(twitterClient).AsImplementedInterfaces();
            var build = container.Build();


            var twitterServiceProvider = build.Resolve<TwitterService>();
            var tweets = twitterServiceProvider.GetCompleteUserTimeline();

            Assert.Greater(tweets.Count(), 0, "Number of tweets should be more then 0!");
        }
    }
}
