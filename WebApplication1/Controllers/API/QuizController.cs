using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Logic;

namespace WebApplication1.Controllers.API
{

    [RoutePrefix("api/quiz")]
    public class QuizController : ApiController
    {

        private IQuizLogic IBLogic;

        public QuizController(IQuizLogic IBLogic) {

            this.IBLogic = IBLogic;
        }


        //[Route("/getquiz/{id}")]
        //public IHttpActionResult getQuiz(int? id)
        //{

        //    var result = this.IBLogic.GetQuize((int)id);

        //    //if (!result) { 

        //    //}

        //}



        [Route("/createQuiz")]
        [HttpPost]
        public IHttpActionResult createQuiz(FromBodyAttribute fromBody) { 


        
        }


    }
}
