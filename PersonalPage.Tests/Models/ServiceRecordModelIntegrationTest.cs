using System.Linq;
using Autofac;
using NUnit.Framework;
using PersonalPage.Library.Helpers;
using PersonalPage.Models;

namespace PersonalPage.Tests.Models
{
    [TestFixture, Category("IntegrationTest")]
    public class ServiceRecordModelIntegrationTest
    {
        [Test]
        public void CanGetAllServiceRecords()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }

        [Test]
        public void CanGetTwitterServiceRecords()
        {
            var container = ContainerHelper.Container;

            var serviceRecordModel = container.Resolve<ServiceRecordModel>();
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }
    }
}