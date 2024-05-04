
namespace hw12
{
    internal class Firm
    {
        public string Name { get; set; }
        public DateTime DateEstablished { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorName { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Address { get; set; }

        public List<Employee> Employees { get; set; }


        public static void ShowInfo(IEnumerable<Firm> firms)
        {
            foreach (var firm in firms)
            {
                Console.WriteLine($"Company Name: {firm.Name}");
                Console.WriteLine($"Date Established: {firm.DateEstablished}");
                Console.WriteLine($"Business Profile: {firm.BusinessProfile}");
                Console.WriteLine($"Director's Name: {firm.DirectorName}");
                Console.WriteLine($"Number of Employees: {firm.NumberOfEmployees}");
                Console.WriteLine($"Address: {firm.Address}");
            }
        }

        public static void ShowEmployees(IEnumerable<Firm> firms)
        {
            foreach (var firm in firms)
            {
                Console.WriteLine($"Employees of {firm.Name}:");
                foreach (var employee in firm.Employees)
                {
                    Console.WriteLine($"- Full Name: {employee.FullName}");
                    Console.WriteLine($"  Position: {employee.Position}");
                    Console.WriteLine($"  Phone Number: {employee.PhoneNumber}");
                    Console.WriteLine($"  Email: {employee.Email}");
                    Console.WriteLine($"  Salary: {employee.Salary}");
                }

                Console.WriteLine();
            }
        }
    }
}
