namespace Examination.DAL.Entities.Identity
{
    public class Identity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public PersonType PersonType { get; set; }
        public bool IsDeleted { get; set; }
        public Identity()
        {
            Created = DateTime.Now;
        }
    }
}
