using NewHrSalaryProcessor;
using System;

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

            ISalaryProcessor bankUploader = SalaryToolFactory.GiveMeSalaryProcessor(false);
            bankUploader.ProcessCompanySalary(employeesArray);

            bankUploader = SalaryToolFactory.GiveMeSalaryProcessor(true);
            bankUploader.ProcessCompanySalary(employeesArray);



            // A better tool for salary management is available, the the system only knows how to work with ISalaryProcessor
            //var newUploadTool = new SalaryUploadManager();
            // the app only works with comma separated string values and knows how to use ISalaryProcessor.
            // How can it use the new SalaryUploadManager???
            //newUploadTool.UploadSalaries(new List<Employee>());


            Console.ReadLine();
        }
    }
}
