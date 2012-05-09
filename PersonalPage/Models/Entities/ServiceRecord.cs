using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalPage.Models.Servicies
{
    abstract public class ServiceRecord
    {
        public abstract string Text { get; set; }
        public abstract DateTime CreatedAt { get; set; }
    }
}