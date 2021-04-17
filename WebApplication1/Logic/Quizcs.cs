using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Logic
{
    public class Quizcs
    {

        public int quizId { get; set; }
        public string quizType { get; set; }
        public Nullable<int> Timelimit { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }
}