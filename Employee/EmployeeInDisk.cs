using delegates.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace delegates.Employee
{
    public class EmployeeInDisk : Employee
    {
       
        public override event EmployeeAdded EmployeeAdded;        

        public EmployeeInDisk(string fileName): base(fileName)
        {
            FileName = fileName;
        }        

        public override void AddEmployee(IEmployeeDTO employee)
        {
            AddedEmployee = employee;
            ++TotalEmployees;

            using (var writer = File.AppendText($"{ FileName }.txt"))
            {
                writer.WriteLine($"Name: { employee.Name } , Salary: { employee.Salary } ");

                // if the delegate is not null, then we can pass the object and the args
                EmployeeAdded?.Invoke(this, new EventArgs());
            }
        }

        public override IAnalytics Analytics()
        {
            throw new NotImplementedException();
        }
    }
}
