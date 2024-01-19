
namespace Examination.DAL.Entities.Identity
{
    public class Student :Identity
    {
        public int level { get; set; }
        public string DepartmentName { get; set; }
        public Course Course { get; set; }
       

        public override string ToString()
        {
            return @$"    ID : {Id} 
                                Name : {Name}
                                Created :{Created}
                                PersonType : {PersonType}
                                IsDeleted : {IsDeleted}
                                level : {level}
                                DepartmentName : {DepartmentName}";
        }
    }
}
