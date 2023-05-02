using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarçom
{
    public class Garcom : EntidadeBase
    {
        public string nome;

        public string idade;
        public Garcom(string nomeAtt, string idadeAtt)
        {
            nome = nomeAtt;

           idade = idadeAtt;

        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom mesaAtualizada = (Garcom)registroAtualizado;

            nome = mesaAtualizada.nome;

            idade = mesaAtualizada.idade;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(idade.Trim()))
                erros.Add("O campo \"idade\" é obrigatório");
            return erros;
        }
    }
}
