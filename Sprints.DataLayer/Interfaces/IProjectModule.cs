using Sprints.DataLayer.Models;
using System.Collections.Generic;

namespace Sprints.DataLayer.Interfaces
{
    public interface IProjectModule
    {
        List<ProjectModule> GetAllProject();
        ProjectModule GetProjectById(int id);
        ProjectModule AddProject(ProjectModule project);
        ProjectModule UpdateProject(int id, ProjectModule project);
        void DeleteProject(int id);
    }
}
