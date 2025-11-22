namespace Company.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public double Salary { get; set; }

    }
}
