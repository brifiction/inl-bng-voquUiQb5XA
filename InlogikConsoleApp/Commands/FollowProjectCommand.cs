using InlogikConsoleApp.Domain;
using System.Collections.Generic;

namespace InlogikConsoleApp.Commands
{
    public class FollowProjectCommand
    {
        public string username { get; private set; }
        public string projectName { get; private set; }

        public FollowProjectCommand(string username, string projectName)
        {
            this.username = username;
            this.projectName = projectName;
        }
    }

    public class FollowProjectCommandHandler
    {
        public void Handle(FollowProjectCommand command, Dictionary<string, User> users, Dictionary<string, Project> projects)
        {
            if (!users.ContainsKey(command.username))
            {
                users[command.username] = new User(command.username);
            }

            if (!projects.ContainsKey(command.projectName))
            {
                projects[command.projectName] = new Project(command.projectName);
            }

            users[command.username].FollowProject(command.projectName);
        }
    }
}