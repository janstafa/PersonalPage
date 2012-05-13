using System;
using System.Net;

namespace PersonalPage.Models.Servicies.Twitter
{
    public class TwitterClient : ITwitterClient
    {

        public string GetRequest(Uri requestUri)
        {
            #region Defenzive Zone

            if (requestUri == null)
            {
                throw new ArgumentNullException("requestUri");
            }

            #endregion

            var client = new WebClient();
            return client.DownloadString(requestUri);
        }
    }
}