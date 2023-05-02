using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class Produto : EntidadeBase
    {
        public string nomeProduto;

        public string preco;
        public Produto(string nomeProdut, string prec)
        {
            nomeProduto = nomeProdut;

            preco = prec;

        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto mesaAtualizada = (Produto)registroAtualizado;

            nomeProduto = mesaAtualizada.nomeProduto;

            preco  = mesaAtualizada.preco;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(nomeProduto.Trim()))
                erros.Add("O campo \"Nome do produto\" é obrigatório");

            if (string.IsNullOrEmpty(preco.Trim()))
                erros.Add("O campo \"Preço\" é obrigatório");
            return erros;
        }
    }
}
