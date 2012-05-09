using System;

namespace PersonalPage.Models.Servicies.Twitter
{
    public interface ITwitterClient
    {
        string GetRequest(Uri requestUri);
    }
}