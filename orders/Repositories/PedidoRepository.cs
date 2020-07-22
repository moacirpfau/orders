using Microsoft.EntityFrameworkCore;
using orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace orders.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext contexto;

        public PedidoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<string> GetCanal()
        {
            var listacanal = contexto.Orders
                    .Select(m => m.CANAL).Distinct()
                    .ToList();
            return listacanal;
        }

        public IList<Orders> GetPedidos(Int32 pedido, string canal)
        {
            Expression<Func<Orders, bool>> isTeenAgerExpr;
            isTeenAgerExpr = m => m.ID == pedido && m.CANAL == canal;

            if (pedido == 0 && canal == "Todos")
                isTeenAgerExpr = m => m.ID == m.ID && m.CANAL == m.CANAL;

            if (pedido != 0 && canal == "Todos")
                isTeenAgerExpr = m => m.ID == pedido ;                          

            if (pedido == 0 && canal != "Todos")
                isTeenAgerExpr = m => m.CANAL == canal;

            var listaOrders = contexto.Orders
                    .Where(isTeenAgerExpr)
                    .ToList();
            return listaOrders;

        }

        public IList<Orders> GetPedidos()
        {
            return contexto.Set<Orders>().ToList();
        }

        public void SavePedidos(List<listaOrders> Pedidos)
        {

            foreach (var pedido in Pedidos)
            {
                contexto.Set<Orders>().Add(new Orders(pedido.ID, pedido.ITEM, pedido.QTD, pedido.VALORUNITARIO, pedido.TOTAL, pedido.CLIENTE, pedido.CANAL));
            }
            contexto.SaveChanges();
        }
    }
    public class listaOrders
    {
        public Int32 ID { get; set; }

        public string ITEM { get; set; }

        public Int32 QTD { get; set; }

        public Decimal VALORUNITARIO { get; set; }

        public Decimal TOTAL { get; set; }

        public string CLIENTE { get; set; }

        public string CANAL { get; set; }


    }
}
