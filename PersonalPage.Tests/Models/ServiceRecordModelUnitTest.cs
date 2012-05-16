using System;
using System.Linq;
using Autofac;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models;
using PersonalPage.Tests.Helpers;

namespace PersonalPage.Tests.Models
{
    [TestFixture, Category("UnitTest"), Timeout(5000)]
    public class ServiceRecordModelUnitTest
    {

        [Test] 
        public void CanGetAllServiceRecords()
        {
            var builder = ContainerHelperTest.GetBuilder();
            var twitterClient = MockingHelper.GetITwitterClientMockReturnsUserTweetsJsonString();
            builder.RegisterInstance(twitterClient).AsImplementedInterfaces();
            var container = builder.Build();


            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

       [Test]
        public void CanGetTwitterServiceRecords()
        {
            var builder = ContainerHelperTest.GetBuilder();
            var twitterClient = MockingHelper.GetITwitterClientMockReturnsUserTweetsJsonString();
            builder.RegisterInstance(twitterClient).AsImplementedInterfaces();
            var container = builder.Build();

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

        [Test]
        public void CannotGetUnknonwServiceRecords()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            Assert.Throws<ArgumentOutOfRangeException>(() => serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Unknown));
        }
    }
}
