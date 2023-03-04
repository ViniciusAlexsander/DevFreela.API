using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll(string query);
        ProjectDetailsViewModel GetAll(int id);

        int Create(NewProjectInputModel newProjectInputModel);

        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void Started(int id);
        void Finish(int id);
    }
}
