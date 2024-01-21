

namespace Examination.DAL.Entities.ExamVM
{
    public class ListQuestion : List<Question>
    {
       
        public ListQuestion()
        {
            //filePath = @"D:\ITI\C#\Day7\QuestionsListFile" + counter + @".txt";
            //sw = new StreamWriter(filePath, false);
            //counter++;
           
        }
        public int ID { get; set; }
        public string Body { get; set; }
        public int CorrectChoise { get; set; }
        //public string filePath { get; set; }
        //public StreamWriter sw { get; set; }
        //public static int counter { get; set; } //for files names
        public List<Choose> Chooses { get; set; }=new List<Choose>();
        public Question Question { get; set; }

        public override string ToString()
        {
            //sw.Write(Body.ToString());
            return $@" 
                                    {ID}  -  {Body}    
 
                                    ________________";
        }
    }
}
