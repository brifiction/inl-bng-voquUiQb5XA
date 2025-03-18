using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace InlogikConsoleApp.Infrastructure.Repositories
{
    public class ProjectRepository : IRepository<string, Project>
    {
        private readonly Dictionary<string, Project> projects;

        public ProjectRepository()
        {
            projects = new Dictionary<string, Project>();
        }

        public Project? Get(string projectName)
        {
            return projects.TryGetValue(projectName, out var project) ? project : null;
        }

        public void Add(string projectName, Project project)
        {
            projects[projectName] = project;
        }

        public bool ContainsKey(string projectName)
        {
            return projects.ContainsKey(projectName);
        }

        public Dictionary<string, Project> GetAll()
        {
            return projects;
        }
    }
} 