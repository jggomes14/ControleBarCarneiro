using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            nomeEntidade = "Produto";
            this.repositorioBase = repositorioProduto;
        }


        protected override void MostrarTabela(ArrayList registros)
        {
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "ID", "PRODUTO", "PREÇO");

                Console.WriteLine("-------------------------------------------------------------------------");

                foreach (Produto produtos in registros)
                {
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -20} ",
                        produtos.id, produtos.nomeProduto, produtos.preco);
                }

            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero Nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.Write("Digite o preço: ");
            string preco = Console.ReadLine();


            return new Produto(nomeProduto, preco);

        }
    }
}
