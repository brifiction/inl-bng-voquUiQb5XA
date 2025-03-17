namespace InlogikConsoleApp
{
    public class User
    {
        public string UserName { get; set; }
        public List<Project> Projects { get; set; }

        public User(string userName, List<Project> projects)
        {
            UserName = userName;
            Projects = projects;
        }

        public string postingMessage(string message)
        {
            return $"{message}";
        }

        public string readingMessage(string message)
        {
            return $"{message}";
        }
        
    }
} 