namespace NewHrSalaryProcessor.cs
{
    public class Employee
    {
        public int ID { get;}
        public string Name { get; }
        public string AccountNo { get; }
        public double Salary { get; }

        public Employee(int id, string name, string accountNo, double salary)
        {
            ID = id;
            Name = name;
            AccountNo = accountNo;
            Salary = salary;
        }
    }
}
