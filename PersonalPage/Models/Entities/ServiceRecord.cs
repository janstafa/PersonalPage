using System;

namespace PersonalPage.Models.Entities
{
    public abstract class ServiceRecord
    {
        public abstract string Text { get; set; }
        public abstract DateTime CreatedAt { get; set; }
    }
}