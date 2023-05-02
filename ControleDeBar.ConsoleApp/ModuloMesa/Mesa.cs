using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {

        public string pedido;
        
        public string numeroDaMesa;
        public Mesa(string pedid,string numM)
        {
            pedido = pedid;
            
            numeroDaMesa = numM;

        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            pedido = mesaAtualizada.pedido;
            
            numeroDaMesa = mesaAtualizada.numeroDaMesa;

        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();
            if (string.IsNullOrEmpty(numeroDaMesa.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(pedido.Trim()))
                erros.Add("O campo \"login\" é obrigatório");
            return erros;
        }
    }
}
