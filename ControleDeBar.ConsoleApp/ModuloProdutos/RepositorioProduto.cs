using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class RepositorioProduto : RepositorioBase

    {
        public RepositorioProduto(ArrayList lista)
        {
            listaRegistros = lista;
        }
        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }


    }
}
