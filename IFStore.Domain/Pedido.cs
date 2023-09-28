using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStore.Domain
{
    internal class Pedido
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
    }
}
