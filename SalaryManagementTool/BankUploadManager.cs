using System;

namespace SalaryManagementTool
{
    public class BankUploadManager: ISalaryProcessor
    {
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                Console.WriteLine(
                    $"Employee {employeesArray[i, 1]} has {employeesArray[i, 3]} wired in his {employeesArray[i, 2]} acount");
            }

        }
    }
}
