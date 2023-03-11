using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Projeto teste1", "Descrição", 1, 1, 10000),
                new Project("Projeto teste2", "Descrição", 1, 1, 10000),
                new Project("Projeto teste3", "Descrição", 1, 1, 10000),
            };
            Users = new List<User>
            {
                new User("Vinicius", "email@gmail.com", new DateTime(2000, 09, 25)),
                new User("Vinicius", "email@gmail.com", new DateTime(2000, 09, 25)),
                new User("Vinicius", "email@gmail.com", new DateTime(2000, 09, 25)),
            };
            Skills = new List<Skill>
            {
                new Skill("C#"),
                new Skill("Js"),
                new Skill("Ts"),
            };
            ProjectComments = new List<ProjectComment>
            {
                new ProjectComment("C#", 1, 1),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
