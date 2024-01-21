namespace Examination.DAL.Data
{
    public static class DataBase
    {
        public static List<Course> Courses = new List<Course>();

        public static void GetData()
        {
           
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\CourseDB.txt", true))
                {
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                    try 
                    {
                        string[] row = ln.Split("-");
                        Course course = new Course();
                        course.Id = int.Parse(row[0]);
                        course.name = row[1];
                        course.FinalDegree=int.Parse(row[2]);
                        Courses.Add(course);
                        counter++;
                    }
                    catch { }
                        
                    }
                    file.Close();

            }

            using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\UserDB.txt", true))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    try
                    {
                        string[] row = ln.Split(",");
                    Student student = new Student();
                    student.Id =int.Parse(row[0]);
                    
                    student.Email = row[2];
                    student.Password = row[3];
                    if (row[1]=="admin")
                    {
                        student.PersonType = PersonType.admin;
                    }
                    else
                    {
                        student.PersonType = PersonType.student;
                       
                    }
                    int CourseID = int.Parse(row[4]);
                    Courses.Where(a => a.Id==CourseID).FirstOrDefault().students.Add(student);
                    counter++;
                    }
                    catch { }
                }
                file.Close();

            }
            using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\Exam.txt", true))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    try
                    {
                        string[] row = ln.Split(",");
                        Exam exam = new Exam();
                        exam.ID =int.Parse(row[0]);

                        exam.ExamTime = row[1];
                        int CourseID = int.Parse(row[2]);
                        Courses.Where(a => a.Id==CourseID).FirstOrDefault().Exams.Add(exam);
                        counter++;
                    }
                    catch { }
                }
                file.Close();

            }
            using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\QuestionsDD.txt", true))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    try
                    {
                        string[] row = ln.Split(",");
                        Question question = new Question();
                        question.ID =int.Parse(row[0]);

                        question.header = row[1];
                        question.mark = int.Parse(row[2]);
                        int CourseID = int.Parse(row[3]);
                        int ExamID = int.Parse(row[4]);
                        Courses.Where(a => a.Id==CourseID).FirstOrDefault().Exams.Where(exam=>exam.ID==ExamID).FirstOrDefault().Questions.Add(question);
                        counter++;
                    }
                    catch { }
                }
                file.Close();

            }
            
            using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\ListQuestionsDB.txt", true))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    try
                    {
                        string[] row = ln.Split(",");
                        ListQuestion Listquestion = new ListQuestion();
                        Listquestion.ID =int.Parse(row[0]);
                        Listquestion.Body = row[1];
                        Listquestion.CorrectChoise = int.Parse(row[2]);  
                        int CourseID = int.Parse(row[3]);
                        int ExamID = int.Parse(row[4]);
                        int QuestionID = int.Parse(row[5]);
                        Courses.Where(a => a.Id==CourseID).FirstOrDefault().Exams.Where(exam => exam.ID==ExamID).FirstOrDefault().Questions.Where(q => q.ID == QuestionID).FirstOrDefault().body.Add(Listquestion);
                        counter++;
                    }
                    catch { }
                }
                file.Close();

            }


            using (StreamReader file = new StreamReader(@"D:\\ITI\\C#\\Day7\\MakeFolder\\ChooseDB.txt", true))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    try
                    {
                        string[] row = ln.Split(",");
                        Choose choose = new Choose();
                        int CourseID = int.Parse(row[4]);
                        int ExamID = int.Parse(row[5]);
                        int QuestionID = int.Parse(row[6]);
                        for (int i = 0; i < Courses.Where(a => a.Id==CourseID).FirstOrDefault().Exams.Where(exam => exam.ID==ExamID).FirstOrDefault().Questions.Where(q => q.ID == QuestionID).FirstOrDefault().body.Count; i++)
                        {
                            Choose choose1  = new Choose();
                            choose1.ID =int.Parse(row[0]);
                            choose1.Descripe = row[1];
                            choose1.Choises = char.Parse(row[2]);
                            Courses.Where(a => a.Id==CourseID).FirstOrDefault().Exams.Where(exam => exam.ID==ExamID).FirstOrDefault().Questions.Where(q => q.ID == QuestionID).FirstOrDefault().body.Where(a => a.ID==i+1).FirstOrDefault().Chooses.Add(choose1);
                        }  
                        
                     
                        
                        
                        counter++;
                    }
                    catch { }
                }
                file.Close();

            }
        }
    }
}
