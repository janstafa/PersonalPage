using System;
using System.Net;

namespace PersonalPage.Servicies
{
    public class TwitterClient : ITwitterClient
    {

        public string GetUserTimelineJson(Uri requestUri)
        {
            #region Defenzive Zone

            if (requestUri == null)
            {
                throw new ArgumentNullException("requestUri");
            }

            #endregion

            WebClient client = new WebClient();
            return client.DownloadString(requestUri);
        }
    }
}