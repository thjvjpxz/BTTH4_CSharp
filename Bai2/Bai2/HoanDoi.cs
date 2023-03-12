using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class HoanDoi
    {
        public static void HoanVi(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
