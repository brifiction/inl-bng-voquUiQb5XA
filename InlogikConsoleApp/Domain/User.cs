using System.Collections.Generic;

namespace InlogikConsoleApp.Domain
{
    public class User
    {
        public string username { get; private set; }
        public List<string> projects { get; private set; }

        public User(string username)
        {
            this.username = username;
            this.projects = new List<string>();
        }

        public void FollowProject(string projectName)
        {
            if (!projects.Contains(projectName))
            {
                projects.Add(projectName);
            }
        }
    }
}