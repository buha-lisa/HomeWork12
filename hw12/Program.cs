
using System.Xml.Linq;

namespace hw12
{
    internal class Program
    {
        static void Main()
        {
            var firms = new List<Firm>()
            {
                new Firm()
                {
                    Name = "ABC Corp",
                    DateEstablished = new DateTime(2000, 5, 10),
                    BusinessProfile = "IT Services",
                    DirectorName = "John White",
                    NumberOfEmployees = 50,
                    Address = "123 Main St, New York",
                    Employees = { new Employee() {
                                       FullName = "Lionel Johnson",
                                       Position = "Developer",
                                       PhoneNumber = "234-567-8901",
                                       Email = "lionel78@.com",
                                       Salary = 50000 }
                    }
                },
                new Firm()
                {
                    Name = "White&Black Food",
                    DateEstablished = new DateTime(2012, 4, 14),
                    BusinessProfile = "Food Industry",
                    DirectorName = "Mett Black",
                    NumberOfEmployees = 90,
                    Address = "5 Avenue, London",
                    Employees = { new Employee() {
                                       FullName = "Bob Williams",
                                       Position = "Manager",
                                       PhoneNumber = "345-678-9012",
                                       Email = "bob@w13.com",
                                       Salary = 60000 }
                    }
                },
                new Firm()
                {
                    Name = "AVK CONFECTIONERY",
                    DateEstablished = new DateTime(1991, 1, 20),
                    BusinessProfile = "Marketing",
                    DirectorName = "Alice Brown",
                    NumberOfEmployees = 150,
                    Address = "23 Shevchenko st, Kuiv",
                    Employees = { new Employee() {
                                       FullName = "Charlie Brown",
                                       Position = "Marketing Specialist",
                                       PhoneNumber = "456-789-0123",
                                       Email = "charlie@56wn.com",
                                       Salary = 55000 }
                    }
                }
            };
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:                        
                        Console.WriteLine("List of all firms:");
                        ShowInfo(firms);

                        Console.WriteLine("\n\nList of firms with name that contains 'Food':");
                        var even1 = from firm in firms
                                    where firm.Name.Contains("Food")
                                    select firm;
                        ShowInfo(even1);

                        Console.WriteLine("\n\nList of firms with profile 'Marketind':");
                        var even2 = from firm in firms
                                    where firm.BusinessProfile == "Marketing"
                                    select firm;
                        ShowInfo(even2);

                        Console.WriteLine("\n\nList of firms with profile 'Marketind' or 'IT':");
                        var even3 = from firm in firms
                                    where firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT Services"
                                    select firm;
                        ShowInfo(even3);

                        Console.WriteLine("\n\nList of firms with 100 or more employees:");
                        var even4 = from firm in firms
                                    where firm.NumberOfEmployees >= 100
                                    select firm;
                        ShowInfo(even4);

                        Console.WriteLine("\n\nList of firms with employees between 100 and 300:");
                        var even5 = from firm in firms
                                    where firm.NumberOfEmployees >= 100 && firm.NumberOfEmployees <= 300
                                    select firm;
                        ShowInfo(even5);

                        Console.WriteLine("\n\nList of firms in London:");
                        var even6 = from firm in firms
                                    where firm.Address.Contains("London")
                                    select firm;
                        ShowInfo(even6);

                        Console.WriteLine("\n\nList of firms with director name 'White':");
                        var even7 = from firm in firms
                                    where firm.DirectorName.Contains("White")
                                    select firm;
                        ShowInfo(even7);

                        Console.WriteLine("\n\nList of firms founded more than two years ago:");
                        var even8 = from firm in firms
                                    where (DateTime.Now - firm.DateEstablished).TotalDays > 2 * 365
                                    select firm;
                        ShowInfo(even8);

                        Console.WriteLine("\n\nList of firms founded more than 123 days ago:");
                        var even9 = from firm in firms
                                    where (DateTime.Now - firm.DateEstablished).TotalDays > 123
                                    select firm;
                        ShowInfo(even9);

                        Console.WriteLine("\n\nList of firms with director name 'Black' and firm name that contains 'White':");
                        var even10 = from firm in firms
                                     where firm.DirectorName.Contains("Black") && firm.Name.Contains("White")
                                     select firm;
                        ShowInfo(even10);

                        break;
                    case 2:
                        Console.WriteLine("List of all firms:");
                        ShowInfo(firms);

                        Console.WriteLine("\n\nList of firms with name that contains 'Food':");
                        var even11 = firms.Where(n => n.Name.Contains("Food"));
                        ShowInfo(even11);

                        Console.WriteLine("\n\nList of firms with profile 'Marketind':");
                        var even12 = firms.Where(n => n.BusinessProfile == "Marketing");
                        ShowInfo(even12);

                        Console.WriteLine("\n\nList of firms with profile 'Marketind' or 'IT':");
                        var even13 = firms.Where(n => n.BusinessProfile == "Marketing" || n.BusinessProfile == "IT Services");
                        ShowInfo(even13);

                        Console.WriteLine("\n\nList of firms with 100 or more employees:");
                        var even14 = firms.Where(n => n.NumberOfEmployees >= 100);
                        ShowInfo(even14);

                        Console.WriteLine("\n\nList of firms with employees between 100 and 300:");
                        var even15 = firms.Where(n => n.NumberOfEmployees >= 100 && n.NumberOfEmployees <= 300);
                        ShowInfo(even15);

                        Console.WriteLine("\n\nList of firms in London:");
                        var even16 = firms.Where(n => n.Address.Contains("London"));
                        ShowInfo(even16);

                        Console.WriteLine("\n\nList of firms with director name 'White':");
                        var even17 = firms.Where(n => n.DirectorName.Contains("White"));
                        ShowInfo(even17);

                        Console.WriteLine("\n\nList of firms founded more than two years ago:");
                        var even18 = firms.Where(n => (DateTime.Now - n.DateEstablished).TotalDays > 2 * 365);
                        ShowInfo(even18);

                        Console.WriteLine("\n\nList of firms founded more than 123 days ago:");
                        var even19 = firms.Where(n => (DateTime.Now - n.DateEstablished).TotalDays > 123);
                        ShowInfo(even19);

                        Console.WriteLine("\n\nList of firms with director name 'Black' and firm name that contains 'White':");
                        var even20 = firms.Where(n => n.DirectorName.Contains("Black") && n.Name.Contains("White"));
                        ShowInfo(even20);
                        break;
                    case 3:
                        Console.WriteLine("List of all employees:");
                        ShowEmployees(firms);

                        Console.WriteLine("\n\nList of all employees of a certain firm in which the salary is greater than the specified one:");
                        var even21 = firms.Select(n => n.Employees.Where(e => e.Salary > 55000));
                        ShowEmployees(even21);

                        Console.WriteLine("\n\nList of employees of all companies in which there is a position 'Manager':");
                        var even22 = firms.Select(c => c.Employees.Where(e => e.Position == "Manager"));
                        ShowInfo(even22);

                        Console.WriteLine("\n\nList of employees whose phone number starts with '23':");
                        var even23 = firms.Select(c => c.Employees.Where(e => e.PhoneNumber.StartsWith("23")));
                        ShowInfo(even23);

                        Console.WriteLine("\n\nList of employees whose Email starts with 'di':");
                        var even24 = firms.Select(c => c.Employees.Where(e => e.Email.StartsWith("di")));
                        ShowInfo(even24);

                        Console.WriteLine("\n\nList of employees named Lionel");
                        var even25 = firms.Select(c => c.Employees.Where(e => e.FullName.Contains("Lionel")));
                        ShowInfo(even25);

                        break;
                }

                if (task == 0) break;
            }
        }

        private static void ShowInfo(IEnumerable<IEnumerable<Employee>> even22)
        {
            throw new NotImplementedException();
        }

        private static void ShowEmployees(IEnumerable<IEnumerable<Employee>> even21)
        {
            throw new NotImplementedException();
        }

        private static void ShowEmployees(List<Firm> firms)
        {
            throw new NotImplementedException();
        }

        private static void ShowInfo(IEnumerable<Firm> even1)
        {
            throw new NotImplementedException();
        }

        private static void ShowInfo(List<Firm> firms)
        {
            throw new NotImplementedException();
        }
    }
}
