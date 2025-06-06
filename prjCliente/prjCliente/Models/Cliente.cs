using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prjCliente.Models
{
    internal class Cliente
    {
        private int cli_id;
        private string cli_name;
        private string cli_celular;
        private string cli_email;

        public int Cli_id { get => cli_id; set => cli_id = value; }
        public string Cli_name { get => cli_name; set => cli_name = value; }
        public string Cli_celular { get => cli_celular; set => cli_celular = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }

        public void Cadastrar()
        {

        }

        public void Editar()
        {

        }

        public void Excluir()
        {

        }

        public void Pesquisar()
        {

        }

        public bool emailValido(string email)
        {
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

            return emailRegex.IsMatch(email);
        }
    }
}
