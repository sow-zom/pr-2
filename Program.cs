using System;

namespace pr2
{
    class Program
    {
        static void Main()
        {
            Worker f = new Worker();
            //DateTime date1 = new DateTime();
            //Console.WriteLine(DateTime.Now.Year);
            //f.SetName();
            //Console.WriteLine(f.GetName());

        }
    }
    class Company
    {
        protected string Name, Position, Salary;
        public Company()
        {
            Name = "empty";
            Position = "empty";
            Salary = "empty";
        }
        public Company(string a, string b, string c)
        {
            Name = a;
            Position = b;
            Salary = c;
        }
        public void SetName()
        {
            Console.Write("SetName\n");
            Name = Console.ReadLine().ToString();
        }
        public void SetYear()
        {
            Console.Write("SetPosition\n");
            Position = Console.ReadLine().ToString();
        }
        public void SetMonth()
        {
            Console.Write("SetSalary\n");
            Salary = Console.ReadLine().ToString();
        }

    }

    class Worker
    {
        protected string Name;
        protected int Year, Month;
        Company WorkPlace = new Company();
        public Worker()
        {
            Name = "empty";
            Year = 0;
            Month = 0;
        }
        public Worker(string a, int b, int c, Company d)
        {
            Name = a;
            Year = b;
            Month = c;
            WorkPlace = d;
        }
        public void SetName()
        {
            Console.Write("SetName\n");
            Name = Console.ReadLine();
        }
        public void SetYear()
        {
            Console.Write("SetYear\n");
            Year = int.Parse(Console.ReadLine());
        }
        public void SetMonth()
        {
            Console.Write("SetMonth\n");
            Month = int.Parse(Console.ReadLine());
        }
        public int GetMonth()
        {
            return Month;
        }
        public int GetYear()
        {
            return Year;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetWorkPlace()
        {
            Console.Write("SetWorkPlace\n");
            WorkPlace.SetName();
            WorkPlace.SetYear();
            WorkPlace.SetMonth();
        }

    }


}
