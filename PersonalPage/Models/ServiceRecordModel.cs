using System;
using System.Collections.Generic;
using Autofac;
using PersonalPage.Models.Entities;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Models
{
    public class ServiceRecordModel
    {
        private readonly IComponentContext _componentContext;

        public ServiceRecordModel(IComponentContext componentContext)
        {
            _componentContext = componentContext;
        }

        public IEnumerable<ServiceRecord> GetAllServiceRecords()
        {
            var twitterService = _componentContext.Resolve<TwitterService>();
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
                    var twitterService = _componentContext.Resolve<TwitterService>();
                    result = twitterService.GetCompleteUserTimeline();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("serviceType");
            }

            return result;
        }
    }
}