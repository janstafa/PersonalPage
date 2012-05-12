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
        [Test, Category("UnitTest")]
        public void CanGetAllServiceRecords()
        {
            var serviceRecordModel = new ServiceRecordModel();
            var allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }


        [Test, Category("UnitTest")]
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
