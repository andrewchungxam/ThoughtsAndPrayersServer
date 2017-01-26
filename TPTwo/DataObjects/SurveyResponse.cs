using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Azure.Mobile.Server;

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPTwo.DataObjects
{
    [Table("responses")]
    public class SurveyResponse : EntityData
    {
        [JsonProperty("questionId")]
        public string QuestionId { get; set; }
        public string Name { get; set; }
        [JsonProperty("answer")]
        public int AnswerIndex { get; set; }



    }
}