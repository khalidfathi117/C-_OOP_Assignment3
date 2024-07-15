using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Interface
{
    internal interface IMyType
    {
        #region Properties
        public int Age { get; set; }
        #endregion

        #region Methods
        public void myFunc();

        public void Print()
        {
            Console.WriteLine("Default Implementation Method");
        }
        #endregion
    }
}
