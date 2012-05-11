using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PersonalPage.Models;
using PersonalPage.Models.Entities;

namespace PersonalPage.Tests.Models
{
    [TestFixture]
    class ServiceRecordModelTest
    {
        [Test]
        public void CanGetAllServiceRecords()
        {
            ServiceRecordModel serviceRecordModel = new ServiceRecordModel();
            IEnumerable<ServiceRecord> allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }


        [Test]
        public void CanGetTwitterServiceRecords()
        {
            ServiceRecordModel serviceRecordModel = new ServiceRecordModel();
            IEnumerable<ServiceRecord> allServiceRecords = serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Twitter);

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }



        [Test]
        public void CannotGetUnknonwServiceRecords()
        {
            ServiceRecordModel serviceRecordModel = new ServiceRecordModel();
            Assert.Throws<ArgumentOutOfRangeException>(() => serviceRecordModel.GetSpecificServiceRecords(ServiceRecordModel.ServiceType.Unknown));
        }
    }
}
