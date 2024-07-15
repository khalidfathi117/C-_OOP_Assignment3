using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Overriding
{
    internal class TypeC : TypeB
    {
        #region Properties
        public int C { get; set; }
        #endregion

        #region Constructor
        public TypeC(int _a, int _b, int _c) : base(_a, _b)
        {
            C = _c;
        }
        #endregion

        #region Methods
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeC : C = {C}");
        }
        #endregion
    }
}
