using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_8.Binding
{
    internal class FullTimeEmployee : Employee
    {
        #region Properties
        public int Salary { get; set; }
        #endregion

        #region Methods
        public new void MyFunc01()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"ID : {ID}, Name :{Name}, Age : {Age}, Salary : {Salary}");
        }
        #endregion
    }
}
