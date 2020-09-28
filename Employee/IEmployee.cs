using delegates.Statistics;
using System;

namespace delegates.Employee
{
    // Don't use delegate prefix or sufix , that is a best practice.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions
    public delegate void EmployeeAdded(object sender, EventArgs args);

    public interface IEmployee
    {
        void AddEmployee(IEmployeeDTO employee);
        public IAnalytics Analytics();

        // This is the delegate.
        event EmployeeAdded EmployeeAdded;

        public IEmployeeDTO AddedEmployee { get; set; }

        public int TotalEmployees { get; set; }
    }
}
