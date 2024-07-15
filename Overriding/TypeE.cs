using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8.Overriding
{
    internal class TypeE : TypeD
    {
        #region Properties
        public int E { get; set; }
        #endregion

        #region Constructor
        public TypeE(int _a, int _b, int _c, int _d, int _e) : base(_a, _b, _c, _d)
        {
            E = _e;
        }
        #endregion

        #region Methods
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeE : E = {E}");
        }
        #endregion
    }
}
