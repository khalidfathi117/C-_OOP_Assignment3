using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Overriding
{
    internal class TypeD : TypeC
    {
        #region Properties
        public int D { get; set; }
        #endregion

        #region Constructor
        public TypeD(int _a, int _b, int _c, int _d) : base(_a, _b, _c)
        {
            D = _d;
        }
        #endregion

        #region Methods
        public new virtual void MyFunc02()
        {
            Console.WriteLine($"TypeD: D = {D}");
        }
        #endregion
    }
}
