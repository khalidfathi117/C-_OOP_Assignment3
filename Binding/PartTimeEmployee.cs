using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Binding
{
    internal class PartTimeEmployee : Employee
    {
        #region Properties
        public decimal HourSalary { get; set; }
        #endregion

        #region Methods
        public new void MyFunc01()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"ID : {ID}, Name :{Name}, Age : {Age}, HourSalary : {HourSalary}");
        }
        #endregion
    }
}
