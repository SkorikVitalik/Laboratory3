namespace Cinema
{
    public class User
    {
        public string Login;
        public string Password;
        public string Name;
        public string Surname;

        public User(string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
        }
    }
}