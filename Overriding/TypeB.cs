using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Overriding
{
    internal class TypeB : TypeA
    {
        #region Properties
        public int B { get; set; }
        #endregion

        #region Constructor
        public TypeB(int _a, int _b) : base(_a)
        {
            B = _b;
        }
        #endregion

        #region Methods
        public new void MyFunc01()
        {
            Console.WriteLine("I am Child");
        }
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeB : B = {B}");
        }
        #endregion
    }
}
