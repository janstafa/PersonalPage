using System;
using System.Linq;
using Autofac;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models;

namespace PersonalPage.Tests.Models
{
    [TestFixture]
    class ServiceRecordModelTest
    {
        [Test, Category("IntegrationTest")] //todo pomoci DI a mocku z toho udelat unit test
        public void CanGetAllServiceRecords()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }
         
        [Test, Category("IntegrationTest")] 
        public void CanGetTwitterServiceRecordsIntegrationTest()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

        [Test, Category("UnitTest")] //todo pomoci DI a mocku z toho pridat unit test
        public void CanGetTwitterServiceRecordsUnitTest()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

        [Test, Category("UnitTest")]
        public void CannotGetUnknonwServiceRecords()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            Assert.Throws<ArgumentOutOfRangeException>(() => serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Unknown));
        }
    }
}
