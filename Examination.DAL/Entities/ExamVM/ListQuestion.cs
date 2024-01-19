namespace Examination.DAL.Entities.ExamVM
{
    public class ListQuestion
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public int CorrectChoise { get; set; }
      
        public List<Choose> Chooses { get; set; }=new List<Choose>();
        public Question Question { get; set; }

        public override string ToString()
        {
            return $@" 
                                    {ID}  -  {Body}    
 
                                    ________________";
        }
    }
}
