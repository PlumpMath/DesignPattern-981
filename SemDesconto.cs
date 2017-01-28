using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SemDesconto : Desconto
    {
        public Desconto _proximo { get; set;  }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
