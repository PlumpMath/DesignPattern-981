using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DescontoPorMaisdeQuinhentosReais : Desconto
    {
        public Desconto _proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento._valor > 500 ? orcamento._valor * 0.07 : _proximo.Desconta(orcamento);
        }

    }
}
