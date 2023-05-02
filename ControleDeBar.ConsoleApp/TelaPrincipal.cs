using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp
{
    internal class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Bar 2023\n");

            Console.WriteLine("Digite 1 para Mesas");
            Console.WriteLine("Digite 2 para Garçom");
            Console.WriteLine("Digite 3 para Pedidos");
            Console.WriteLine("Digite 4 para contas");
            

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
