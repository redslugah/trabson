using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPiqueSysMarket.Models
{
    public class Venda
    {
        private decimal  valor { get; set; }
        public int cliente { get; set; }
        public List<Produtos> listaVenda { get; set; }
    }
}