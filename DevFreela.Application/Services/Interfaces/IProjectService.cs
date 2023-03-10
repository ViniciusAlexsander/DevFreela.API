using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        public List<ProjectViewModel> GetAll(string query);
        public ProjectDetailsViewModel GetById(int id);

        public int Create(NewProjectInputModel newProjectInputModel);

        public void Update(UpdateProjectInputModel inputModel);
        public void Delete(int id);
        public void Started(int id);
        public void Finish(int id);
    }
}
