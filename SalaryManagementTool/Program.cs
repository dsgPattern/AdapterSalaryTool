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

            var bankUploader = new BankUploadManager();
            bankUploader.ProcessCompanySalary(employeesArray);




            Console.ReadLine();
        }
    }
}
