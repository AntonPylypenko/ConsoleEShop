namespace BusinessLogicLayer.DTOmodels
{
    public class AccountDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public string Email { get; set; }
        public RoleTypes Role { get; private set; }
    }
}
