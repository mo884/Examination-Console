namespace Examination.DAL.Entities.ExamVM
{
    public class Question
    {
        public int ID { get; set; }
        public string header { get; set; }
        public int mark { get; set; }
        public List<ListQuestion> body { get; set; } = new List<ListQuestion>();
        public Exam Exam { get; set; }

        public override string ToString()
        {
            return $@"   {header}   Mark{mark}
==================================================
";
        }
    }
}
