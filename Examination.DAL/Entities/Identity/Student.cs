
namespace Examination.DAL.Entities.Identity
{
    public class Student : Identity, ICloneable
    {
        public int level { get; set; }
        public string DepartmentName { get; set; }
        public Course Course { get; set; }

        public object Clone()=> new Student() {Id = Id,Created=Created,Email=Email,Password=Password,DepartmentName=DepartmentName,PersonType=PersonType,Name=Name,level=level,IsDeleted=IsDeleted, Course = Course };

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
