using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Azure.Mobile.Server;

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPTwo.DataObjects
{
    public class ThinkingOfYou : EntityData
    {
        public string theId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string SharedText { get; set; }
        public string NewText { get; set; }
        public string FBProfileUrl { get; set; }
        public string CreateDateString { get; set; }
        public string CreateDateTimeString { get; set; }
        
        public string theFBID { get; set; }
        public string thePrayerRequestId { get; set; }

    }
}
