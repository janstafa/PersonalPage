using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NMock2;
using NUnit.Framework;
using PersonalPage.Models.Entities.Twitter;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Models.Servicies
{
    [TestFixture]
    public class TwitterServiceProviderTest
    {
        readonly private Mockery _mocks = new Mockery();

        [Test]
        public void GetUserTimeline()
        {
            string returnJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Models/Servicies/Tweets.txt");


            ITwitterClient twitterClient = _mocks.NewMock<ITwitterClient>();
            Expect.Once.On(twitterClient)
                       .Method("GetRequest")
                       .Will(Return.Value(returnJson));

            TwitterService twitterServiceProvider = new TwitterService();
            IEnumerable<Tweet> tweets = twitterServiceProvider.GetCompleteUserTimeline(twitterClient);

            Assert.Greater(tweets.Count(), 0, "Number of tweets should be more then 0!");
        }
    }
}
