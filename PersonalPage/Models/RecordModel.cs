using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalPage.Models.Entities;
using PersonalPage.Models.Entities.Twitter;
using PersonalPage.Models.Servicies.Twitter;

namespace PersonalPage.Models
{
    public class ServiceRecordModel
    {
        public ServiceRecord[] GetAllServiceRecords()
        {

            TwitterService twitterService = new TwitterService();
            Tweet[] completeUserTimeline = twitterService.GetCompleteUserTimeline(new TwitterClient());

            return completeUserTimeline;
        }
    }
}