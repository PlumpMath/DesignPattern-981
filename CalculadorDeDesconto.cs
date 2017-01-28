using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class CalculadorDeDesconto
    {
        public double RealizaDesconto(Orcamento orcamento)
        {
            //Chain of responsabilty
            //Que é uma cadeia de responsabilidades, onde cada caso tem uma 
            //condição que pode ou não ser atendida 
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisdeQuinhentosReais();
            Desconto d3 = new SemDesconto();

            d1._proximo = d2;
            d2._proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
