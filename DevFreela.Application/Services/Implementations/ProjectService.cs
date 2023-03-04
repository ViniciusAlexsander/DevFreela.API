using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        int IProjectService.Create(NewProjectInputModel newProjectInputModel)
        {
            throw new NotImplementedException();
        }

        void IProjectService.Delete(int id)
        {
            throw new NotImplementedException();
        }

        void IProjectService.Finish(int id)
        {
            throw new NotImplementedException();
        }

        List<ProjectViewModel> IProjectService.GetAll(string query)
        {
            throw new NotImplementedException();
        }

        ProjectDetailsViewModel IProjectService.GetAll(int id)
        {
            throw new NotImplementedException();
        }

        void IProjectService.Started(int id)
        {
            throw new NotImplementedException();
        }

        void IProjectService.Update(UpdateProjectInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}
