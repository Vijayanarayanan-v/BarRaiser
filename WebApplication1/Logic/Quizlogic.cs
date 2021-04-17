using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccesLayer;
using WebApplication1.Logic;

namespace WebApplication1.Logic
{
    public class Quizlogic : IQuizLogic
    {
        public int createQuiz(string Quiztype, int? TimeLimit, List<QuizQuestionmodel> questions, List<ChoicesModel> choices)
        {
            try
            {

                using (var db = new masterEntities())
                {

                    db.Quizs.Add(new Quiz
                    {
                        quizType = Quiztype,
                        Timelimit = TimeLimit

                    });

                    var quizid = db.SaveChanges();


                    foreach (var data in questions)
                    {

                        db.quizquestions.Add(new quizquestion
                        {
                            questions = data.questions,
                            questiontype = data.questiontype,
                            createdAt = DateTime.Now,
                            updatedAt = DateTime.Now
                        });

                        

                        var questionid = db.SaveChanges();
                        db.Dispose();


                        db.QuizQuestionmappings.Add(new QuizQuestionmapping
                        {

                            quizId = quizid,
                            questionId = questionid
                        });

                        db.SaveChanges();

                        
                    }


                    return quizid;



                }



            }
            catch (Exception)
            {

            }
        }

        List<ChoicesModel> IQuizLogic.GetChoices(int id)
        {
            throw new NotImplementedException();
        }

        List<QuizQuestionmodel> IQuizLogic.Getquestions(int id)
        {
            throw new NotImplementedException();
        }

        List<Quizcs> IQuizLogic.GetQuize(int id)
        {
            throw new NotImplementedException();
        }
    }
}