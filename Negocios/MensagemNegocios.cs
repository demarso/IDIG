using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class MensagemNegocios
    {

        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Inserir
        public string Inserir(Mensagem mensagem)
        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@DataMensagem", mensagem.DataMensagem);
                acessoDadosSqlServer.AdicionarParametros("@TituloMensagem", mensagem.TituloMensagem);
                acessoDadosSqlServer.AdicionarParametros("@ResumoMensagem", mensagem.ResumoMensagem);
                string idMensagem = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMensagemInserir").ToString();

                return idMensagem;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
