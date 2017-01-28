using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Item
    {
        public String _nome { get; private set; }
        public double _valor { get; private set; }

        public Item(String nome, double valor)
        {
            _nome = nome;
            _valor = valor;

        }
    }
}
