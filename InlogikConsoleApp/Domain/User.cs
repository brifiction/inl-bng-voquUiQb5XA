using System.Collections.Generic;

namespace InlogikConsoleApp.Domain
{
    public class User
    {
        public string UserName { get; private set; }
        public List<string> Projects { get; private set; }

        public User(string userName)
        {
            UserName = userName;
            Projects = new List<string>();
        }

        public void FollowProject(string projectName)
        {
            if (!Projects.Contains(projectName))
            {
                Projects.Add(projectName);
            }
        }
    }
}