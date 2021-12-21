using Sprints.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Sprints.Models
{
    public class ProjectModuleEf : IProjectModule

    {

        private readonly AppDbContext _context;



        public ProjectModuleEf(AppDbContext context)
        {
            _context = context;
        }
        public ProjectModule AddProject(ProjectModule project)
        {
            _context.ProjectModule.Add(project);
            _context.SaveChanges();
            return project;
        }

        public void DeleteProject(int id)
        {
            ProjectModule project = GetProjectById(id);
            _context.ProjectModule.Remove(project);
            _context.SaveChanges();
        }

        public List<ProjectModule> GetAllProject()
        {
            return _context.ProjectModule.ToList();
        }

        public ProjectModule GetProjectById(int id)
        {
            return _context.ProjectModule.FirstOrDefault(usr => usr.Id == id);
        }

        public ProjectModule UpdateProject(int id, ProjectModule project)
        {
            var DatatobeUpdated = _context.ProjectModule.FirstOrDefault(usr => usr.Id == id);
            if (DatatobeUpdated != null)
            {
                DatatobeUpdated.Name = project.Name;
                DatatobeUpdated.Detail = project.Detail;
                DatatobeUpdated.CreatedOn = project.CreatedOn;

                _context.SaveChanges();
            }
            return project;
        }
    }

}


