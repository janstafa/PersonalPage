using System;

namespace PersonalPage.Servicies
{
    public interface ITwitterClient
    {
        string GetUserTimelineJson(Uri requestUri);
    }
}