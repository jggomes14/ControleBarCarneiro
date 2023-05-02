using ControleDeBar.ConsoleApp.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    internal class TelaConta
    {
        TelaProduto telaP;
        RepositorioConta repositorioConta;

        public void FazerPedido()
        {
            Produto produto = (Produto)telaP.EncontrarRegistro("Digite o id: ");

            Console.WriteLine("Digite a quantidade de produtos: ");
            int qtd = Convert.ToInt32(Console.ReadLine();

            Pedido p = new Pedido();
            p.produto = produto;
            p.quantidade = qtd;

            repositorioConta.adicionarPedido(p);
        }
    }
}
