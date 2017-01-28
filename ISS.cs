using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento._valor * 0.06;
        }
    }
}
