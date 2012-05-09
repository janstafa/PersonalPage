using System;
using System.Globalization;
using NMock2;
using NUnit.Framework;
using PersonalPage.Servicies;

namespace PersonalPage.Tests.Servicies
{
    [TestFixture]
    public class TwitterClientTest
    {
        [Test]
        public void DoesGetUserTimelineJsonThrowsArgumentNullException()
        {
            TwitterClient twitterClient = new TwitterClient();
            Assert.Throws<ArgumentNullException>(() => twitterClient.GetUserTimelineJson(null));
        }
    }
}
