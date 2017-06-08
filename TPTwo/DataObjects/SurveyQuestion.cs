using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Azure.Mobile.Server;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPTwo.DataObjects
{
    [Table("questions")]
    public class SurveyQuestion : EntityData
    {
        public string Text { get; set; }
        public string Answers { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string SharedText { get; set; }


        public string NewText { get; set; }
        public string FBProfileUrl { get; set; }

        public string CreateDateString { get; set; }

        public string theFBID { get; set; }

    }
}