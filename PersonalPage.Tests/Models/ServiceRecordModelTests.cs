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
            ServiceRecord[] allServiceRecords = serviceRecordModel.GetAllServiceRecords();

            Assert.Greater(allServiceRecords.Count(), 0, "Not enough service records!");
        }
    }
}
