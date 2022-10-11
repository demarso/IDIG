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
    public class PessoaNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Inserir

        public string Inserir(Pessoa pessoa)
        {
            try
            {                

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", pessoa.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@CEP", pessoa.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", pessoa.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", pessoa.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Estado", pessoa.Estado);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", pessoa.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Celular", pessoa.Celular);
                acessoDadosSqlServer.AdicionarParametros("@Email", pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Nascimento", pessoa.Nascimento);
                acessoDadosSqlServer.AdicionarParametros("@StatID", pessoa.StatID);
                string idPessoal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaInserir").ToString();

                return idPessoal;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //Reinscrever

        public string Reintegrar(Pessoa pessoal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPessoa", pessoal.IDPessoa);
               string idPessoal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaReintegrar").ToString();

                return idPessoal;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //Alterar

        public string Alterar(Pessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPessoa", pessoa.IDPessoa);
                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Endereco", pessoa.Endereco);
                acessoDadosSqlServer.AdicionarParametros("@CEP", pessoa.CEP);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", pessoa.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", pessoa.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Estado", pessoa.Estado);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", pessoa.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Celular", pessoa.Celular);
                acessoDadosSqlServer.AdicionarParametros("@Email", pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Nascimento", pessoa.Nascimento);
                acessoDadosSqlServer.AdicionarParametros("@StatID", pessoa.StatID);
                string ID = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaAlterar").ToString();


                return ID;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //Excluir

        public string Excluir(Pessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IDPessoa", pessoa.IDPessoa);
                // acessoDadosSqlServer.AdicionarParametros("@Ano", pessoal.id);
                string idPessoal = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPessoaExcluir").ToString();

                return idPessoal;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Consultar por nome

        public PessoaColecao ConsultarPorNome(string nome)
        {
            try
            {
                PessoaColecao pessoaColecao = new PessoaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                DataTable dataTablePessoa = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoalConsultarPorNome");
                int nu = 0;
                foreach (DataRow linha in dataTablePessoa.Rows)
                {
                    //Criar uma pessoa vazia
                    //Colocar os dados dalinha nela
                    //Adicionar lea na coleção
                    Pessoa pessoa = new Pessoa();
                                        
                    pessoa.IDPessoa = Convert.ToInt32(linha["IDPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Endereco = Convert.ToString(linha["Endereco"]);
                    pessoa.CEP = Convert.ToString(linha["CEP"]);
                    pessoa.Bairro = Convert.ToString(linha["Bairro"]);
                    pessoa.Cidade = Convert.ToString(linha["Cidade"]);
                    pessoa.Estado = Convert.ToString(linha["Estado"]);
                    pessoa.Telefone = Convert.ToString(linha["Telefone"]);
                    pessoa.Celular = Convert.ToString(linha["Celular"]);
                    pessoa.Email = Convert.ToString(linha["Email"]);
                    pessoa.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    pessoa.StatID = Convert.ToInt32(linha["StatID"]);
                    pessoa.Stat = Convert.ToString(linha["Stat"]);
                    
                   

                    pessoaColecao.Add(pessoa);

                }

                return pessoaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Pessoa por nome. Detalhes: " + ex.Message);
            }
        }

        //Consultar Excluído

        public PessoaColecao ConsultarPessoaInativo(string Nome)
        {
            try
            {
                PessoaColecao pessoaColecao = new PessoaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", Nome);

                DataTable dataTablePessoal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoaConsultarInativo");
                int nu = 0;
                foreach (DataRow linha in dataTablePessoal.Rows)
                {
                    nu = nu + 1;
                    //Criar uma pessoa vazia
                    //Colocar os dados dalinha nela
                    //Adicionar ela na coleção
                    Pessoa pessoa = new Pessoa();

                    pessoa.IDPessoa = Convert.ToInt32(linha["IDPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Endereco = Convert.ToString(linha["Endereco"]);
                    pessoa.CEP = Convert.ToString(linha["CEP"]);
                    pessoa.Bairro = Convert.ToString(linha["Bairro"]);
                    pessoa.Cidade = Convert.ToString(linha["Cidade"]);
                    pessoa.Estado = Convert.ToString(linha["Estado"]);
                    pessoa.Telefone = Convert.ToString(linha["Telefone"]);
                    pessoa.Celular = Convert.ToString(linha["Celular"]);
                    pessoa.Email = Convert.ToString(linha["Email"]);
                    pessoa.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    pessoa.StatID = Convert.ToInt32(linha["StatID"]);
                    pessoa.Stat = Convert.ToString(linha["Stat"]);
                    pessoa.num = nu;

                    pessoaColecao.Add(pessoa);

                }

                return pessoaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Pessoa excluída. Detalhes: " + ex.Message);
            }
        }

        //Consultar por Id

        public PessoaColecao ConsultarPorId(int id)
        {
            try
            {
                PessoaColecao pessoalColection = new PessoaColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dataTablePessoal = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPessoalConsultarPorId");

                foreach (DataRow linha in dataTablePessoal.Rows)
                {
                    Pessoa pessoa = new Pessoa();

                    pessoa.IDPessoa = Convert.ToInt32(linha["IDPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Endereco = Convert.ToString(linha["Endereco"]);
                    pessoa.CEP = Convert.ToString(linha["CEP"]);
                    pessoa.Bairro = Convert.ToString(linha["Bairro"]);
                    pessoa.Cidade = Convert.ToString(linha["Cidade"]);
                    pessoa.Estado = Convert.ToString(linha["Estado"]);
                    pessoa.Telefone = Convert.ToString(linha["Telefone"]);
                    pessoa.Celular = Convert.ToString(linha["Celular"]);
                    pessoa.Email = Convert.ToString(linha["Email"]);
                    pessoa.Nascimento = Convert.ToDateTime(linha["Nascimento"]);
                    pessoa.StatID = Convert.ToInt32(linha["StatID"]);

                    pessoalColection.Add(pessoa);

                }

                return pessoalColection;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar a Pessoa por Código. Detalhes: " + ex.Message);
            }
        }

        
    }
}