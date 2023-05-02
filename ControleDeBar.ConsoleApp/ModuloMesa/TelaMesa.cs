using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa ) 
        {
            nomeEntidade = "Mesa";
            this.repositorioBase = repositorioMesa;
        }

       
        protected override void MostrarTabela(ArrayList registros)
        {
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "ID", "PEDIDO", "N DA MESA");

                Console.WriteLine("-------------------------------------------------------------------------");

                foreach (Mesa mesas in registros)
                {
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -20} ",
                        mesas.id, mesas.pedido, mesas.numeroDaMesa);
                }

            }
        }

          protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero da mesa: ");
            string numDaMesa = Console.ReadLine();

            Console.Write("Digite seu pedido: ");
            string pedido = Console.ReadLine();


            return new Mesa(numDaMesa, pedido);
            
        }
    }
}
