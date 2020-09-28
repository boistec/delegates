using delegates.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace delegates.Statistics
{
    public interface IAnalytics
    {
        public void AddEntry(IEmployeeDTO employee);
        public double Sum { get; set; }
        public int Count { get; set; }
        public double Highest { get; set; }
        public double Lowest { get; set; }
        public double Avegare { get; }
        public List<IEmployeeDTO> TopTenBySalary { get; set; }
    }

    public class Analytics : IAnalytics
    {
        public double Sum { get; set; }
        public int Count { get; set; }
        public double Highest { get; set; }
        public double Lowest { get; set; }

        public double Avegare { get; }

        public List<IEmployeeDTO> TopTenBySalary { get; set; }

        public void AddEntry(IEmployeeDTO employee)
        {
            TopTenBySalary.Add(employee);
        }
    }
}
