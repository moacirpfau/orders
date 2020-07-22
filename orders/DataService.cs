using Newtonsoft.Json;
using orders.Models;
using orders.Repositories;
using System;
using System.Collections.Generic;
using System.IO;

namespace orders
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IPedidoRepository pedidoRepository;

        public DataService(ApplicationContext contexto, IPedidoRepository pedidoRepository)
        {
            this.contexto = contexto;
            this.pedidoRepository = pedidoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated();

            List<listaOrders> Pedidos = getPedidos();

            if (pedidoRepository.GetPedidos().Count == 0)
                pedidoRepository.SavePedidos(Pedidos);
        }



        private static List<listaOrders> getPedidos()
        {
            var json = File.ReadAllText("data.json");
            var Pedidos = JsonConvert.DeserializeObject<List<listaOrders>>(json);
            return Pedidos;
        }
    }


}
