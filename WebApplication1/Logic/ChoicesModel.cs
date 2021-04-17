using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Logic
{
    public class ChoicesModel
    {
        public int choiceid { get; set; }
        public Nullable<int> questionId { get; set; }
        public string choices { get; set; }
        public Nullable<bool> isanswer { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
    }

}