using System;
using System.Linq;
using NUnit.Framework;
using PersonalPage.Models;

namespace PersonalPage.Tests.Models
{
    [TestFixture]
    class ServiceRecordModelTest
    {
        [Test, Category("IntegrationTest")] //todo pomoci DI a mocku z toho udelat unit test
        public void CanGetAllServiceRecords()
        {
            var serviceRecordModel = new ServiceRecordModel();
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }
         

        [Test, Category("IntegrationTest")] //todo pomoci DI a mocku z toho udelat unit test
        public void CanGetTwitterServiceRecords()
        {
            var serviceRecordModel = new ServiceRecordModel();
            var allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }


        [Test, Category("UnitTest")]
        public void CannotGetUnknonwServiceRecords()
        {
            var serviceRecordModel = new ServiceRecordModel();
            Assert.Throws<ArgumentOutOfRangeException>(() => serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Unknown));
        }
    }
}
