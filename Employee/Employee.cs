using delegates.Statistics;
using System.Diagnostics.Tracing;

namespace delegates.Employee
{
    public interface IEmployeeDTO
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public class EmployeeDTO : IEmployeeDTO
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }



    public class EmployeeFile
    {
        public EmployeeFile(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }

    }
    
    public abstract class Employee : EmployeeFile, IEmployee
    {
        
        public Employee(string fielName) : base(fielName) { }

        public IEmployeeDTO AddedEmployee { get; set; }
        public int TotalEmployees { get; set; }        

        // This is the delegate.
        public abstract event EmployeeAdded EmployeeAdded;

        public abstract void AddEmployee(IEmployeeDTO employee);

        public abstract IAnalytics Analytics();               

    }    
}
