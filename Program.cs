using System;

namespace pr2
{
    class Program
    {
        static void Main()
        {
            Worker f = new Worker();
            Company g = new Company();
            //DateTime date1 = new DateTime();
            //Console.WriteLine(DateTime.Now.Year);
            //f.SetName();

            //f.SetMonth();
            //f.SetYear();
            //g.SetSalary();
            //f.SetWorkPlace(g);
            //Console.WriteLine(f.GetTotalMoney());

            PrintWorker(ReadWorkersArray());

        }
        static Worker[] ReadWorkersArray()
        {
            Console.Write("\n(ReadWorkersArray):\nset Worker number>> ");
            int razm = Convert.ToInt32(Console.ReadLine());
            Worker[] array = new Worker[razm];
            

            for (int i = 0; i < razm; i++)
            {
                array[i] = new Worker();
                Company array2 = new Company();
                Console.Write("\n(ReadWorkersArray):\n" + i+1);
                array[i] = new Worker();
                array[i].SetName();

                array[i].SetYear();

                array[i].SetMonth();
                array2.SetName();
                array2.SetPosition();
                array2.SetSalary();
                //array[i].SetWorkPlace(array2);
                Console.Write(array2.GetName());
               array[i].GetWorkPlace(array2);


            }

            return array;
        }
        static void PrintWorker(Worker o)
        {
            Console.Write(o.GetName());
            Console.Write(o.GetYear());
            Console.Write(o.GetMonth());
            //o.GetWorkPlace();
            
            
        }

        static void PrintWorker(Worker[] o)
        {
            for (int i = 0; i < o.Length; i++)
            {
                Console.Write("Worker " + (i + 1) + ":\n");
                PrintWorker(o[i]);
            }
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
            Console.Write("\nSetCompanyName\n");
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
            Console.Write("\nGetCompanyName\n");
            return Name;
        }
        public string GetPosition()
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
        protected Company WorkPlace;
        public Worker()
        {
            Name = "empty";
            Year = 0;
            Month = 0;
            WorkPlace = new Company();
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
        public void SetWorkPlace(Company WP) 
        {
            WorkPlace = WP;
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
        //public Company[] SetWorkPlace()
        //{
        //Company[] array = new Company[3];
        //Console.Write("\nSetWorkPlace\n");
        //array[0].SetName();
        //array[1].SetPosition();
        //array[2].SetSalary();
        //return array;
        //}
        public void GetWorkPlace(Company WP)
        {
            Console.Write("\nGetWorkPlace\n");
            Console.Write( WP.GetName());
            Console.Write (WP.GetPosition());
            Console.Write(WP.GetSalary());
        }
        //public void GetWorkPlace()
        //{

        //Console.Write(o[0].GetName());
        //Console.Write(o[1].GetPosition());
        //Console.Write(o[2].GetSalary());
        ////  o.;
        //}

        ////static void PrintWorker(Worker[] o)
        ////{
        ////for (int i = 0; i < o.Length; i++)
        ////{
        ////Console.Write("Worker " + (i + 1) + ":\n");
        ////PrintWorker(o[i]);
        ////}
        ////}

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
