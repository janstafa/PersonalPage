using System;
using Autofac;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Models.Servicies
{

    [TestFixture, Category("UnitTest"), Timeout(500)]
    public class TwitterClientTest
    {
        [Test]
        public void DoesGetUserTimelineJsonThrowsArgumentNullException()
        {
            var container = ContainerHelper.Container;

            var twitterClient = container.Resolve<ITwitterClient>();

            Assert.Throws<ArgumentNullException>(() => twitterClient.GetRequest(null));
        }

        

    }
}
