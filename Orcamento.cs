using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Orcamento
    {
        public double _valor { get; private set; }
        public IList<Item> _itens { get; private set; }

        public Orcamento(double valor)
        {
            _valor = valor;
            _itens = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            _itens.Add(item);
        }
    }
}
