using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Interface
{
    internal class MyType : IMyType
    {
        #region Properties
        int Salary;
        int IMyType.Age
        {
            get => Salary;
            set { Salary = value; }
        }
        #endregion

        #region Methods
        public void myFunc()
        {
            Console.WriteLine("Hello Route!");
        }
        public void MyTypeFunc()
        {
            Console.WriteLine("Hello Interface");
        }
        #endregion
    }
}
