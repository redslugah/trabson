using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPiqueSysMarket.Models
{
    public class Carrinho
    {
        private decimal  valor { get; set; }
        public int cliente { get; set; }
        public List<Produtos> listaCarrinho { get; set; }
        public int MyPropertyDeixaEuCuza1 { get; set; }
    }
}