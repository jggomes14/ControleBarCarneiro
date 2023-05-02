using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    internal class Pedido : EntidadeBase
    {

        public Produto produto;
        public int quantidade;

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            return;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
