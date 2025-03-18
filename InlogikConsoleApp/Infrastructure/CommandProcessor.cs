using InlogikConsoleApp.Commands;
using InlogikConsoleApp.Domain;
using InlogikConsoleApp.Infrastructure.Interfaces;
using InlogikConsoleApp.Infrastructure.Repositories;

namespace InlogikConsoleApp.Infrastructure
{
    public class CommandProcessor
    {
        private readonly IRepository<string, User> userRepository;
        private readonly IRepository<string, Project> projectRepository;
        private readonly PostMessageCommandHandler postMessageHandler;
        private readonly FollowProjectCommandHandler followProjectHandler;

        public CommandProcessor()
        {
            userRepository = new UserRepository();
            projectRepository = new ProjectRepository();
            postMessageHandler = new PostMessageCommandHandler();
            followProjectHandler = new FollowProjectCommandHandler();
        }

        public void ProcessPostMessage(string username, string projectName, string content)
        {
            var command = new PostMessageCommand(username, projectName, content);
            postMessageHandler.Handle(command, projectRepository.GetAll());
        }

        public void ProcessFollowProject(string username, string projectName)
        {
            var command = new FollowProjectCommand(username, projectName);
            followProjectHandler.Handle(command, userRepository.GetAll(), projectRepository.GetAll());
        }

        public Dictionary<string, Project> GetProjects()
        {
            return projectRepository.GetAll();
        }

        public Dictionary<string, User> GetUsers()
        {
            return userRepository.GetAll();
        }
    }
} 