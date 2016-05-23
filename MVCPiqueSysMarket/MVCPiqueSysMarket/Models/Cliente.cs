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

        public bool SetCodigo(int codigo)
        {
            if (codigo < 0)
            {
                throw new Exception("Descrição inválida! Por favor insira uma descrição.");
            }

            Codigo = codigo;

            return true;
        }
        
        public bool SetNome(string nome)
        {
            if (nome.Equals(""))
            {
                throw new Exception("Valor Inválido! Por favor insira um valor positivo.");
            }

            Nome = nome;

            return true;
        }
        public bool SetSenha(string pass)
        {
            if (pass.Equals(""))
            {
                throw new Exception("Valor Inválido! Por favor insira um valor positivo.");
            }
            Senha = pass;
            return true;
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