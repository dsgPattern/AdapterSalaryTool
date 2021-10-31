using System;
using System.Collections.Generic;
using NewHrSalaryProcessor.cs;

namespace SalaryManagementTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] employeesArray = {
                {"101","Dorin Atodiresei","BTRL0001293...","10000"},
                {"102","Andrei Luca","BTRL0001309...","20000"},
                {"103","Nati Maier","ING000394...","30000"},
                {"104","Luiza Apostol","BCR0923....","40000"},
            };

            ISalaryProcessor bankUploader = SalaryToolFactory.GiveMeSalaryProcessor();
            bankUploader.ProcessCompanySalary(employeesArray);

            var newUploadTool = new SalaryUploadManager();
            // the app only works with comma separated string values and knows how to use ISalaryProcessor.
            // How can it use the new SalaryUploadManager???
            newUploadTool.UploadSalaries(new List<Employee>());


            Console.ReadLine();
        }
    }
}
