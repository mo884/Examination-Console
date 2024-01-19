﻿namespace Examination.DAL.Entities.ExamVM
{
    public class Exam
    {
        public int ID { get; set; }
        public string ExamTime { get; set; }
        public List<Question>? Questions { get; set; } = new List<Question>();
        public Course? Courses { get; set; }
        public Dictionary<Student, List<StudentAnswer>>? StudentExams { get; set;} = new Dictionary<Student, List<StudentAnswer>>();
        

    }
}
