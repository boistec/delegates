using delegates.Statistics;
using System;
using System.Collections.Generic;

namespace delegates.Employee
{
    public class EmployeeInMemory : Employee
    {        
        public override event EmployeeAdded EmployeeAdded;
        
        private IList<EmployeeDTO> employeeList;

        public EmployeeInMemory(string fileName) : base(fileName)
        {
            FileName = fileName;
            employeeList = new List<EmployeeDTO>();
        }        

        public override void AddEmployee(IEmployeeDTO employee)
        {
            AddedEmployee = employee;
            ++TotalEmployees;

            if (employee.Salary <= 1000 && employee.Salary >= 0)
            {
                employeeList.Add(new EmployeeDTO { Name = employee.Name, Salary = employee.Salary });

                // if the delegate is not null, then we can pass the object and the args
                EmployeeAdded?.Invoke(this, new EventArgs());                
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(employee)}");
            }
        }

        public override IAnalytics Analytics()
        {
            throw new NotImplementedException();
        }
    }
}
