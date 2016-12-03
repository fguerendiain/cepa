using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    //Gaseosa
    public sealed class Soda : Drink
    {
        #region ---------------PROPIEDADES-------------
        // SOBRECARGA DE PROPIEDADES ABSTRACTAS

        public override string Flavor
        {
            get { return this._flavor; }
            set { this._flavor = value; }
        }

        public override int Liters
        {
            get { return this._liters; }
            set { this._liters = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Soda() { }

        public Soda(int sodaIdNumber, string sodaCommentary, string sodaBrand, int sodaPrice, string sodaFlavor, int sodaLiters, int sodaPacking, int sodaStock)
            : base(sodaIdNumber,sodaCommentary, sodaBrand, sodaPrice, sodaFlavor, sodaLiters, sodaPacking, sodaStock)
        {
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder productData = new StringBuilder();

            productData.Append("ID: " + this._idNumber + " ");
            productData.Append("MARCA: " + this._brand + " ");
            productData.Append("SABOR: " + this._flavor + " ");
            productData.Append("PAQ: " + this._packing + "X" + this._liters + "cc ");
            productData.Append("PRECIO: $" + this._price + " ");
            productData.Append("STOCK: " + this._stock + " ");
            productData.Append("OBS: " + this._commentary + " ");

            return productData.ToString();
        }
        #endregion
    }
}
