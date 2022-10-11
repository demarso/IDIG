using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public static class Logar
    {
        static string nome;
        static int nivel;

        public static void autenticar(string Nome, int Nivel)
        {
            nome = Nome;
            nivel = Nivel;
        }

        public static void sair()
        {
            nome = null;
            nivel = 0;
        }

        public static int getDados()
        {
            return nivel;
        }

        public static string getTodos()
        {
           return "Nome: " + nome + "\nNivel: " + nivel;
        }
    }


}
