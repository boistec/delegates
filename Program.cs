using delegates.Employee;
using System;
using System.Text.Json.Serialization;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {


            IEmployee inDiskEmployee = new EmployeeInDisk("InDiskEmployees");
            inDiskEmployee.EmployeeAdded += OnEmployeeAdded; // Suscribe to the event of adding employee
            EnterEmployee(inDiskEmployee);
            Console.WriteLine($"{ inDiskEmployee.GetType().Name }: { inDiskEmployee.TotalEmployees } ");

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");            


            IEmployee inMemoryEmployee = new EmployeeInMemory("InMemoryEmployees");
            inMemoryEmployee.EmployeeAdded += OnEmployeeAdded; // Suscribe to the event of adding employee.
            EnterEmployee(inMemoryEmployee);
            Console.WriteLine($"{ inMemoryEmployee.GetType().Name }: { inMemoryEmployee.TotalEmployees } ");

            Console.WriteLine("");
            Console.WriteLine("**************************************");
            Console.WriteLine("");


            Console.WriteLine("Stroke any key to exit");
            Console.ReadLine();
            Environment.Exit(0);

        }

        private static void EnterEmployee(IEmployee employee)
        {
            var employeeType = employee.GetType().Name;
            while (true)
            {
                Console.WriteLine($"ENTER A {employeeType}  ('Name', 'Salary') or 'q' to quit");

                var input = Console.ReadLine();

                if (input == "q")
                {                    
                    break;
                }

                try
                {
                    var employeeValues = input.Split(',' , StringSplitOptions.RemoveEmptyEntries);
                    if (employeeValues.Length < 0 || employeeValues.Length > 2)
                        Console.WriteLine("Enter a employee ('Name', 'Salary')");

                    employee.AddEmployee(new EmployeeDTO { Name = employeeValues[0], Salary = double.Parse(employeeValues[1]) } );

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally 
                {
                    Console.WriteLine("");                    
                }
            }            
        }

        private static void OnEmployeeAdded(object sender, EventArgs e)
        {
            var senderEmployee = sender as IEmployee;
            Console.WriteLine("\n ----------------");            
            Console.WriteLine($"Name: { senderEmployee.AddedEmployee.Name}, Salary: { senderEmployee.AddedEmployee.Salary }");
            Console.WriteLine($"Trieggered by {senderEmployee.GetType().Name}, employee added!");
            Console.WriteLine("----------------");
        }
    }    
}
