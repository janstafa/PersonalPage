using System;
using NUnit.Framework;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Models.Servicies
{
    [TestFixture]
    public class TwitterClientTest
    {
        [Test]
        public void DoesGetUserTimelineJsonThrowsArgumentNullException()
        {
            TwitterClient twitterClient = new TwitterClient();
            Assert.Throws<ArgumentNullException>(() => twitterClient.GetRequest(null));
        }
    }
}
