using Xunit;
using InlogikConsoleApp.Domain;

// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
namespace InlogikConsoleApp.Tests
{
    public class UserTests
    {
        [Fact]
        public void UserWhenCreated_ShouldHaveCorrectUsernameAndEmptyProjects()
        {
            string username = "Brian";

            var user = new User(username);

            Assert.Equal(username, user.username);
            Assert.Empty(user.projects);
        }

        [Fact]
        public void FollowProject_WhenFollowingNewProject_ShouldAddToProjects()
        {
            var user = new User("Brian");
            string projectName = "Moonshot";

            user.FollowProject(projectName);

            Assert.Contains(projectName, user.projects);
            Assert.Single(user.projects);
        }

        [Fact]
        public void FollowProject_WhenFollowingSameProjectTwice_ShouldNotDuplicate()
        {
            var user = new User("Alice");
            string projectName = "Alpha";

            user.FollowProject(projectName);
            user.FollowProject(projectName); // there is no console prompt to say "already following" etc, check FollowProject method

            Assert.Contains(projectName, user.projects);
            Assert.Single(user.projects);
        }
    }
}
