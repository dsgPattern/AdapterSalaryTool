using System;
using System.Collections.Generic;

namespace NewHrSalaryProcessor
{
    public class SalaryUploadManager
    {
        public void UploadSalaries(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.ID},{employee.Name},{employee.Salary},{employee.AccountNo}");
            }

            Console.WriteLine("Salary file was processed and uploaded in the system");
        }
    }
}
