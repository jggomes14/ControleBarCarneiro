using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarçom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            nomeEntidade = "Garçom";
            this.repositorioBase = repositorioGarcom;
        }


        protected override void MostrarTabela(ArrayList registros)
        {
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "ID", "NOME", "IDADE");

                Console.WriteLine("-------------------------------------------------------------------------");

                foreach (Garcom garcom in registros)
                {
                    Console.WriteLine("{0, -10} | {1, -20} | {2, -20} ",
                        garcom.id, garcom.nome, garcom.idade);
                }

            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do garçom: ");
            string nomeGarcom = Console.ReadLine();

            Console.Write("Digite a idade do garçom: ");
            string idadeGarcom = Console.ReadLine();


            return new Garcom(nomeGarcom, idadeGarcom);

        }

    }
}
