using System;

namespace ObjetoTransferencia
{
    public class Pessoa
    {
        /* Modelo padrão de encapsulamento  
            private int id;
            public int getId()
            {
              return id;
            }
            public void setId(int idEnviado)
            {
              id = idEnviado;
            }   */

        // Modelo de encapsulamento do .NET
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public int StatID { get; set; }
        public string Stat { get; set; }
        public int num { get; set; }

        
    }
}