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
    public class UsuarioNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public Usuario Logar(string nome, string senha)
        {
            
            try
            {
                //UsuarioColecao usuarioColecao = new UsuarioColecao();
                Usuario usuario = new Usuario();
                
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeLogin", nome);
                acessoDadosSqlServer.AdicionarParametros("@Senha", senha);
                 
                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspLogar");
                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                                        
                    usuario.IDPessoa = Convert.ToInt32(linha["IDPessoa"]);
                    usuario.IDUsuario = Convert.ToInt32(linha["IDUsuario"]);
                    usuario.NomeLogin = Convert.ToString(linha["NomeLogin"]);
                    usuario.Senha = Convert.ToString(linha["Senha"]);
                    usuario.Nivel = Convert.ToInt32(linha["Nivel"]);
                    //usuarioColecao.Add(usuario);

                }
                
                    return usuario;
               
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível Logar. Detalhes: " + ex.Message);
            }
        }

       
    }
}
