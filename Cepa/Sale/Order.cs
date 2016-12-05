using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customers;
using ItemsForSale;

namespace Sale
{
    public class Order
    {
        #region ---------------ATRIBBUTOS--------------
        private int _idOrder;
        private Client _client;
        private List<Product> _productList;
        #endregion

        #region ---------------PROPIEDADES-------------
        #endregion

        #region --------------CONSTRUCTORES------------
        #endregion

        #region -----------------METODOS---------------
        //metodo que calcule el precio total de la compra
        //metodo que "dibuje" los datos de la orden, borre automaticamente articulos con cantidad 0
        //metodo que elimine un articulo de la orden
        //metodo que agregue un articulo de la orden, si se da igualdad que se sume la cantidad al existente
        //metodo que exporte a un archivo xml el pedido (definir el nombre del archivo para hacer historico)
        //metodo que importe de un archivo xml los pedidos
        //metodo que exporte el pedido a pdf
        //metodo para definir el numero incremental del pedido revisando cual fue el ultimo guardado.

        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        #endregion

        #region ----------------ENUMERADOS-------------
        #endregion

    }
}
