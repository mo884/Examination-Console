namespace Examination.DAL.Entities.ExamVM
{
    public class Choose
    {
        public int ID { get; set; }
        public char Choises { get; set; }
        public string Descripe { get; set; }
        public ListQuestion Answer { get; set; }


        public override string ToString()
        {
            return $@"  
                           {ID}  -  {Descripe}   ";
        }
    }
}
