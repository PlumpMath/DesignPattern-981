using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            
            CalculadorDeImpostos imposto = new CalculadorDeImpostos();

            imposto.RealizaCalculo(new Orcamento(1000), iss);
            imposto.RealizaCalculo(new Orcamento(1000), icms);

            Desconto mais500 = new DescontoPorMaisdeQuinhentosReais();
            Desconto itens5 = new DescontoPorCincoItens();


            CalculadorDeDesconto desconto = new CalculadorDeDesconto();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Xablau", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Xablau", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Xablau", 250));
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Xablau", 250));

            double valorDesconto = desconto.RealizaDesconto(orcamento);

            Console.WriteLine(valorDesconto);

            Console.ReadLine();
        }
    }
}
