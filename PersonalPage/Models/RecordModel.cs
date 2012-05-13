using System;
using System.Collections.Generic;
using PersonalPage.Models.Entities;
using PersonalPage.Models.Entities.Twitter;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Models
{
    public class ServiceRecordModel
    {
        public IEnumerable<ServiceRecord> GetAllServiceRecords()
        {
            var twitterService = new TwitterService(new TwitterClient());
            var completeUserTimeline = twitterService.GetCompleteUserTimeline();

            return completeUserTimeline;
        }


        public enum ServiceType
        {
            Twitter,
            Unknown
        }

        public IEnumerable<ServiceRecord> GetSpecificServiceRecords(ServiceType serviceType)
        {
            IEnumerable<ServiceRecord> result;

            switch (serviceType)
            {
                case ServiceType.Twitter:
                    TwitterService twitterService = new TwitterService(new TwitterClient());
                    result = twitterService.GetCompleteUserTimeline();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("serviceType");
            }

            return result;
        }
    }
}