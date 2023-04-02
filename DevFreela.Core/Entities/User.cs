namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            Skills = new List<UserSkill>();
            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
            CreatedAt = DateTime.Now;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }
        public List<UserSkill> Skills { get; set; }
        public List<Project> OwnedProjects { get; set; }
        public List<Project> FreelanceProjects { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
