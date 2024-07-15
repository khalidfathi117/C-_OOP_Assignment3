using Assignment_8.Binding;
using Assignment_8.Interface;
using Assignment_8.Overriding;

namespace Assignment_8
{
    internal class Program
    {
        #region Overloading Functions
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int Sum(int x, int y, int z, int d)
        {
            return x + y + z + d;
        }
        #endregion
        public static void ProcessEmp(Employee emp)
        {
            if (emp is not null)
            {
                emp.MyFunc01();
                emp.MyFunc02();
            }
        }
        static void Main(string[] args)
        {

            #region Overloading
            //int res1 = Sum(1, 1);
            //int res2 = Sum(2, 2, 2);
            //int res3 = Sum(3, 3, 3, 3);
            //Console.WriteLine($"{res1}, {res2}, {res3}");
            #endregion

            #region Overriding
            //TypeA typeA = new TypeA(10);
            //typeA.MyFunc01();
            //typeA.MyFunc02();
            //Console.WriteLine("---------------------");
            //TypeB typeB = new TypeB(10, 20);
            //typeB.MyFunc01();
            //typeB.MyFunc02();
            #endregion

            #region Binding
            //TypeA bind = new TypeB(1, 2);
            //bind.MyFunc01(); // Static Binding 
            //bind.MyFunc02(); // Dynamic Binding
            #endregion

            #region  Not binding [Unsafe Casting]
            //TypeA typeA = new TypeA(10);
            //TypeB typeB = (TypeB)typeA; // unsafe casting
            #endregion

            #region Example on Binding 
            //FullTimeEmployee fullEmp = new FullTimeEmployee()
            //{
            //    ID = 10,
            //    Name = "Khalid",
            //    Age = 20,
            //    Salary = 8000
            //};
            //PartTimeEmployee partEmp = new PartTimeEmployee()
            //{
            //    ID = 7,
            //    Name = "Mohammed",
            //    Age = 54,
            //    HourSalary = 100,
            //};
            //ProcessEmp(partEmp);
            #endregion

            #region Multiple Inhertance
            //TypeA typeA = new TypeE(10, 20, 30, 40, 50);
            //TypeB typeB = new TypeE(10, 20, 30, 40, 50);
            //TypeC typeC = new TypeE(10, 20, 30, 40, 50);
            //typeA.MyFunc02(); // prints C
            //typeB.MyFunc02(); // prints C
            //typeC.MyFunc02();// prints C
            //TypeD typeD = new TypeE(10, 20, 30, 40, 50);
            //typeD.MyFunc02(); // prints E
            #endregion

            #region Interface 
            //IMyType myType = new MyType();
            //myType.myFunc();
            //myType.Age = 20;
            //myType.Print();
            #endregion

        }
    }
}
