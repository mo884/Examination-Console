namespace Examination.PL.Controller.Courses
{
    public class CourseController
    {
        IGetCourseRep getAllCourse;
        IAddCourse addCourseRep;
        IGetCourseByIdRep getCourseByID;
        public CourseController()
        {
            getAllCourse = new GetCourseRep();
            addCourseRep = new AddCourse();
            getCourseByID = new GetCourseByIdRep();
        }
        public void Add()
        {
            addCourseRep.Add(AddCourseData.addCourse());
        }
        public void GetAll()
        {
            var item = getAllCourse.getAll();
            for (int i = 0; i< item?.Count; i++)
                Console.WriteLine(item[i]);
        }
        public void GetById()
        {
            Course item = getCourseByID.getById(Validate.getIntNumber(@"Plz Enter Course Id :"));
            Console.WriteLine(item);
            Console.WriteLine("======================================================");
            foreach (var student in item.students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
