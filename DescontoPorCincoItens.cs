using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class DescontoPorCincoItens : Desconto
    {
        public Desconto _proximo { get; set; }

       public double Desconta(Orcamento orcamento)
       {
            return orcamento._itens.Count > 5 ? orcamento._valor * 0.1 : _proximo.Desconta(orcamento);
       }
    }
}
