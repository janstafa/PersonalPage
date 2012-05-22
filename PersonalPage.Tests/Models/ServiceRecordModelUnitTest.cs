using System;
using System.Linq;
using Autofac;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models;
using PersonalPage.Tests.Helpers;

namespace PersonalPage.Tests.Models
{
    [TestFixture, Category("UnitTest"), Timeout(500)]
    public class ServiceRecordModelUnitTest
    {

        [Test] 
        public void CanGetAllServiceRecords()
        {
            // Arrange
            var builder = ContainerHelperTest.GetBuilder();
            var twitterClient = MockingHelper.GetITwitterClientMockReturnsUserTweetsJsonString();
            builder.RegisterInstance(twitterClient).AsImplementedInterfaces();
            var container = builder.Build();
            var serviceRecordModel = container.Resolve<ServiceRecordModel>();

            // Act
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            // Assert
            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

       [Test]
        public void CanGetTwitterServiceRecords()
        {
            // Arrange
            var builder = ContainerHelperTest.GetBuilder();
            var twitterClient = MockingHelper.GetITwitterClientMockReturnsUserTweetsJsonString();
            builder.RegisterInstance(twitterClient).AsImplementedInterfaces();
            var container = builder.Build();
            var serviceRecordModel = container.Resolve<ServiceRecordModel>();

            // Act
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);
            
            // Assert
            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

        [Test]
        public void CannotGetUnknonwServiceRecords()
        {
            // Arrange
            var container = ContainerHelper.Container;
            var serviceRecordModel = container.Resolve<ServiceRecordModel>();

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Unknown));
        }
    }
}
