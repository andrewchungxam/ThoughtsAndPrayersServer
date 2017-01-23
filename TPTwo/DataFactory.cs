using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TPTwo.DataObjects;

namespace TPTwo
{
    static class DataFactory
    {
        public static List<SurveyQuestion> Questions
        {
            get
            {
                return new List<SurveyQuestion>
           {
               new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                   Text = "Where should we have lunch?",
                   Answers = "McDonalds|Sushi King|Olive Garden|Outback Steakhouse|KFC",
                   FirstName = "Tim",
                   LastName = "Cho",
                   FullName = "TimCho",
                   SharedText = "This is really important."
                },
               new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                   Text = "PARTY! Which date do you prefer?",
                   Answers = "Monday|Wednesday|Friday",
                   FirstName = "John",
                   LastName = "Kim",
                   FullName = "JohnKim",
                   SharedText = "I really want to know more about this situation"

               },
               new SurveyQuestion { Id = Guid.NewGuid().ToString(),
                   Text = "Which mobile platform do you like best?",
                   Answers = "Android|iOS|UWP|WPF|HTML|Blackberry",
                   FirstName = "Tommy",
                   LastName = "Lee",
                   FullName = "TommyLee",
                   SharedText = "I want to keep this up!  Please keep me in your thoughts and prayers!"
               }
           };
            }
        }
    }
}