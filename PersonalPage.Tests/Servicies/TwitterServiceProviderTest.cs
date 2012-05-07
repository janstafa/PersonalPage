using System;
using System.IO;
using NMock2;
using NUnit.Framework;
using PersonalPage.Servicies;

namespace PersonalPage.Tests.Servicies
{
    [TestFixture]
    public class TwitterServiceProviderTest
    {
        Mockery mocks = new Mockery();

        [Test]
        public void GetUserTimeline()
        {
            string returnJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Servicies/Tweets.txt");


            ITwitterClient twitterClient = mocks.NewMock<ITwitterClient>();
            Expect.Once.On(twitterClient)
                       .Method("GetUserTimelineJson")
                       .Will(Return.Value(returnJson));

            TwitterService twitterServiceProvider = new TwitterService();
            Tweet[] tweets = twitterServiceProvider.GetUserTimeline(twitterClient);

            Assert.Greater(tweets.Length, 0, "Number of tweets should be more then 0!");
        }
    }
}
