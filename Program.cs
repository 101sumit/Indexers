namespace Indexers
{
    public class Emp
    {
        int Emp_Id;
        string Emp_Name;
        double Emp_Salary;

        //Default access specifiers of a member of a cls is private....

        public Emp(int Emp_Id, string Emp_Name, double Emp_Salary)
        {
            this.Emp_Id = Emp_Id;
            this.Emp_Name = Emp_Name;
            this.Emp_Salary = Emp_Salary;
        }
        public object this[int index]
        {   
            get
            {
                if (index == 1)
                    return Emp_Id;
                else if (index == 2)
                    return Emp_Name;
                else if (index == 3)
                    return Emp_Salary;
                return null;
            }
            set
            {
                if (index == 1)
                    Emp_Id = (int)value;
                else if (index == 2)
                    Emp_Name = (string)value;
                else if (index == 3)
                    Emp_Salary = (double)value;
            }

        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Emp emp = new Emp(100, "Sumit", 70000.00);

                // Access private data members of another cls......
                Console.WriteLine("Emp_Id : " + emp[1]);
                Console.WriteLine("Emp_Name : " + emp[2]);
                Console.WriteLine("Emp_Salary : " + emp[3]);

                // Modify private data members of another cls......
                emp[1] = 101;
                emp[2] = "Sumit Patil";
                Console.WriteLine();

                Console.WriteLine("Modify the private data members");

                Console.WriteLine();
                Console.WriteLine("Emp_Id : " + emp[1]);
                Console.WriteLine("Emp_Name : " + emp[2]);
                Console.WriteLine("Emp_Salary : " + emp[3]);
            }
        }
    }
}
