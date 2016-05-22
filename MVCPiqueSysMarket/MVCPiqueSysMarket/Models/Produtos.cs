using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPiqueSysMarket.Models
{
    public class Produtos
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

      
        // Tratamentos de erros

        public bool SetDescricao(string descricao)
        {
            if (descricao.Equals(""))
            {
                throw new Exception("Descrição inválida! Por favor insira uma descrição.");
            }

            Descricao = descricao;

            return true;
        }

        public bool SetPreco(double preco)
        {
            if (preco < 0)
            {
                throw new Exception("Valor Inválido! Por favor insira um valor positivo.");
            }

            Preco = preco;
            
            return true;
        }

        public bool setCategoria(string categoria)
        {
            if (categoria.Equals (""))
            {
                throw new Exception("Categoria inválida! Por favor insira uma categoria.");
            }

            Categoria = categoria;

            return true;
        }
        public bool setNome(string nome)
        {
            if (nome.Equals(""))
            {
                throw new Exception("Nome inválido! Por favor insira um nome.");
            }

            Nome = nome;

            return true;
        }

    }
}