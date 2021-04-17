using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Logic;

namespace WebApplication1.Logic
{
   public interface IQuizLogic
    {
        List<Quizcs> GetQuize(int id);

        List<QuizQuestionmodel> Getquestions(int id);

        List<ChoicesModel> GetChoices(int id);
         int createQuiz(string Quiztype, int TimeLimit);
    }
}
