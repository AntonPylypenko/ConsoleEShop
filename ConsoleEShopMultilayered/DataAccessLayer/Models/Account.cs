using DataAccessLayer.Interface;

namespace DataAccessLayer.Models
{
    public abstract class Account : IHaveID
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public string Email { get; set; }
        public RoleTypes Role { get; private set; }
        protected Account() { }

        protected Account(int id, string name, string surname, int age, string password, string email, RoleTypes roleType)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Age = age;
            Password = password;
            Email = email;
            Role = roleType;
        }

        public override string ToString()
        {
            return $"ID: {ID}" +
                $"First name: {Name}" +
                $"Last name: {Surname}" +
                $"Age: {Age}" +
                $"E-mail: {Email}" +
                $"Role: {Role}";
        }

        public abstract void ShowMenu();
    }

    public enum RoleTypes : byte
    {
        Administrator,
        RegisteredUser
    }
}
