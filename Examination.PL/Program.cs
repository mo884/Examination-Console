using Examination.DAL.Data;
using Examination.DAL.Entities.Courses;
using Examination.DAL.Entities.ExamVM;
using Examination.PL.Controller.AdminDashBord;
using Examination.PL.Controller.Chooses;
using Examination.PL.Controller.Courses;
using Examination.PL.Controller.Exams;
using Examination.PL.Controller.Identities;
using Examination.PL.Controller.Questions;

namespace Examination.PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase.Courses.Add(new Course { Id=1, name="CSS", students= [new Student() {Id=1,Name="admin",Email="admin@gmail.com",Password="123",PersonType=PersonType.admin }, new Student() { Id=2, PersonType = PersonType.student, Password="123", Email="user@gmail.com", level=2 }], Exams= [

                new Exam()
                {
                    ID=1,
                    ExamTime = "2 Hours",
                    Questions =
                    [
                    new Question()
                    {
                        ID =1,
                        header="True or False",
                        mark= 12,
                        body =
                        [
                        new ListQuestion()
                        {
                            ID = 1,
                            Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab True?",
                            CorrectChoise = 1,
                            Chooses =
                            [
                                new Choose() { ID =1, Descripe ="True", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="False", Choises='2' }

                            ]
                        },
                            new ListQuestion()
                            {
                                ID = 2,
                                Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab True?",
                                CorrectChoise = 1,
                                Chooses =
                            [
                                new Choose() { ID =1, Descripe ="True", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="False", Choises='2' }

                            ]
                            },
                            new ListQuestion()
                            {
                                ID = 3,
                                Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab False?",
                                CorrectChoise = 2,
                                Chooses =
                            [
                                new Choose() { ID =1, Descripe ="True", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="False", Choises='2' }

                            ]
                            }

                        ]
                    },
                        new Question()
                        {
                            ID =2,
                            header="Choise",
                            mark= 12,
                            body =
                        [
                        new ListQuestion()
                        {
                            ID = 1,
                            Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab 1?",
                            CorrectChoise = 1,
                            Chooses =
                            [
                                new Choose() { ID =1, Descripe ="A", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="B", Choises='2' }
                                ,
                                new Choose() { ID =3, Descripe ="C", Choises='3' },
                                new Choose() { ID =4, Descripe ="D", Choises='4' }
                            ]
                        },
                            new ListQuestion()
                            {
                                ID = 2,
                                Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab 2?",
                                CorrectChoise = 2,
                                Chooses =
                            [
                                new Choose() { ID =1, Descripe ="A", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="B", Choises='2' }
                                ,
                                new Choose() { ID =3, Descripe ="C", Choises='3' },
                                new Choose() { ID =4, Descripe ="D", Choises='4' }
                            ]
                            },
                            new ListQuestion()
                            {
                                ID = 3,
                                Body="Lab Lab Lab Lab Lab Lab Lab Lab Lab 3?",
                                CorrectChoise = 3,
                                Chooses =
                            [
                                new Choose() { ID =1, Descripe ="A", Choises='1' }
                              ,
                                new Choose() { ID =2, Descripe ="B", Choises='2' }
                                ,
                                new Choose() { ID =3, Descripe ="C", Choises='3' },
                                new Choose() { ID =4, Descripe ="D", Choises='4' }
                            ]
                            }

                        ]
                        }

                    ]
                }



            ] });
            


            IdentetyController identetyController = new IdentetyController();
            identetyController.Roles();
        }
    }
}
