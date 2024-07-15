using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Overriding
{
    internal class TypeA
    {
        #region Properties
        private int a;
        public int A
        {
            get { return a; }
            set { a = value; }
        }
        #endregion

        #region Constructor
        public TypeA(int _a)
        {
            a = _a;
        }
        #endregion

        #region Methods
        public void MyFunc01()
        {
            Console.WriteLine("I am Base");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
        #endregion
    }
}
