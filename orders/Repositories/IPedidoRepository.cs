using orders.Models;
using System;
using System.Collections.Generic;

namespace orders.Repositories
{
    public interface IPedidoRepository
    {
        void SavePedidos(List<listaOrders> Pedidos);
        IList<Orders> GetPedidos();
        IList<string> GetCanal();

        IList<Orders> GetPedidos(Int32 pedido, string canal);
    }
}