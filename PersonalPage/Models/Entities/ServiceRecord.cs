using System;

namespace PersonalPage.Models.Entities
{
    abstract public class ServiceRecord
    {
        public abstract string Text { get; set; }
        public abstract DateTime CreatedAt { get; set; }
    }
}