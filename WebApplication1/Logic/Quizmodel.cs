using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Logic
{
    public class QuizQuestionmodel
    {

        public int questionId { get; set; }
        public string questions { get; set; }
        public string questiontype { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }
}