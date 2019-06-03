using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class clsArreglo
    {
        const int T = 11;
        clsAuto[] arr = new clsAuto[T];
        int i = -1;

        public bool agregar(clsAuto oAuto)
        {
            i++;
            arr[i] = oAuto;
            if (i == T - 1) return false;
            else return true;
        }
    }
}
