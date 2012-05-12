using System;
using NUnit.Framework;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Models.Servicies
{
    [TestFixture]
    public class TwitterClientTest
    {
        [Test, Category("UnitTest")]
        public void DoesGetUserTimelineJsonThrowsArgumentNullException()
        {
            var twitterClient = new TwitterClient();
            Assert.Throws<ArgumentNullException>(() => twitterClient.GetRequest(null));
        }
    }
}
