using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace MVCPiqueSysMarket.Models
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cliente(int codigo, string nome, string email, string senha = null)
        {
            Codigo = codigo;
            Nome = nome;
            SetEmail(email);
            Senha = senha;
        }

        private bool SetEmail(string email)
        {
            if (!emailvalido(email))
            {
                throw new Exception("E-mail inválido!");
            }

            Email = email;
            return true;
        }

        private bool emailvalido(string email)
        {
            try
            {
                var endereco = new MailAddress(email);
                return endereco.Address == email;
            }
            catch
            {
                return false;
            }
        }



    }
}