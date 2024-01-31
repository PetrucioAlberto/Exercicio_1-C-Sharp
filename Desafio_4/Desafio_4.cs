using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4
{
    internal class Desafio_4
    {
        public bool AnoBissexto(int ano)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}