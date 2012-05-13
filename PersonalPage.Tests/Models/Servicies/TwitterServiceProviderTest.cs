﻿using System;
using System.IO;
using System.Linq;
using NMock2;
using NUnit.Framework;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Tests.Models.Servicies
{
    [TestFixture]
    public class TwitterServiceProviderTest
    {
        readonly private Mockery _mocks = new Mockery();

        [Test, Category("UnitTest")]
        public void GetUserTimeline()
        {
            var returnJson = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Models/Servicies/Tweets.txt");

             
            var twitterClient = _mocks.NewMock<ITwitterClient>();
            Expect.Once.On(twitterClient)
                       .Method("GetRequest")
                       .Will(Return.Value(returnJson));

            var twitterServiceProvider = new TwitterService();
            var tweets = twitterServiceProvider.GetCompleteUserTimeline(twitterClient);

            Assert.Greater(tweets.Count(), 0, "Number of tweets should be more then 0!");
        }
    }
}
