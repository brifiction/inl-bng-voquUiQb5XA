namespace InlogikConsoleApp
{
    public class Project
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public Project(string name, List<User> users)
        {
            Name = name;
            Users = users;
        }
        
    }
} 