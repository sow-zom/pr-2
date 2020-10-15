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

            f.SetMonth();
            f.SetYear();
            f.SetWorkPlace();
            Console.WriteLine(f.GetTotalMoney());

        }
    }
    class Company
    {
        protected string Name, Position;
        protected int Salary;
        public Company()
        {
            Name = "empty";
            Position = "empty";
            Salary = 0;
        }
        public Company(string a, string b, int c)
        {
            Name = a;
            Position = b;
            Salary = c;
        }
        public void SetName()
        {
            Console.Write("\nSetName\n");
            Name = Console.ReadLine().ToString();
        }
        public void SetPosition()
        {
            Console.Write("\nSetPosition\n");
            Position = Console.ReadLine().ToString();
        }
        public void SetSalary()
        {
            Console.Write("\nSetSalary\n");
            Salary = int.Parse(Console.ReadLine());
        }
        public string GetName()
        {
            Console.Write("\nGetName\n");
            return Name;
        }
        public string GetPosotion()
        {
            Console.Write("\nGetPosition\n");
            return Position;
        }
        public int GetSalary()
        {
            Console.Write("\nGetSalary\n");
            return Salary;
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
            Console.Write("\nSetName\n");
            Name = Console.ReadLine();
        }
        public void SetYear()
        {
            Console.Write("\nSetYear\n");
            Year = int.Parse(Console.ReadLine());
        }
        public void SetMonth()
        {
            Console.Write("\nSetMonth\n");
            Month = int.Parse(Console.ReadLine());
        }
        public int GetMonth()
        {
            Console.Write("\nGetMonth\n");
            return Month;
        }
        public int GetYear()
        {
            Console.Write("\nGetYear\n");
            return Year;
        }
        public string GetName()
        {
            Console.Write("\nGetName\n");
            return Name;
        }
        public void SetWorkPlace()
        {
            Console.Write("\nSetWorkPlace\n");
            WorkPlace.SetName();
            WorkPlace.SetPosition();
            WorkPlace.SetSalary();
        }
        public void GetWorkPlace()
        {
            Console.Write("\nGetWorkPlace\n");
            WorkPlace.GetName();
            WorkPlace.SetPosition();
            WorkPlace.GetSalary();
        }

        public int GetWorkExperience()
        {
            return ((DateTime.Now.Year - Year-1)*12 - Month + 1 + DateTime.Now.Month);//включно з місяцем прийнятя на роботу і теперішнім
        }
        public int GetTotalMoney()
        {
            return GetWorkExperience()* WorkPlace.GetSalary();
        }

    }


}
