using NewHrSalaryProcessor;
using System;
using System.Collections.Generic;

namespace SalaryManagementTool
{
    /// <summary>
    /// This is the Adapter, the class that contains the Adaptee and implements the interface the Client uses
    /// </summary>
    public class SalaryUploadManagerAdapter: ISalaryProcessor
    {
        //this is the Adaptee - the object that needs to be adapted to the current implementation
        private readonly SalaryUploadManager _salaryUploadManager;

        public SalaryUploadManagerAdapter()
        {
            _salaryUploadManager = new SalaryUploadManager();
        }

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            _salaryUploadManager.UploadSalaries(GetEmployees(employeesArray));
        }

        private List<Employee> GetEmployees(string[,] employeesArray)
        {
            var listEmployee = new List<Employee>();
            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                listEmployee.Add(new Employee(Convert.ToInt32(employeesArray[i,0]), employeesArray[i,1], employeesArray[i,2], Convert.ToDouble(employeesArray[i,3])));
            }

            return listEmployee;
        }
    }
}
