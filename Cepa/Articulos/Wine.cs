using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    public sealed class Wine : Drink
    {
        #region ---------------ATRIBBUTOS--------------
        private string _cellar; //bodega
        #endregion

        #region ---------------PROPIEDADES-------------
        public string Cellar
        {
            get { return this._cellar; }
            set { this._cellar = value; }
        }

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
        public Wine() { }

        public Wine(int wineIdNumber, string wineCommentary, string wineBrand, int winePrice, string wineCellar, string wineFlavor, int wineLiters, int winePacking, int wineStock)
            : base(wineIdNumber, wineCommentary, wineBrand, winePrice, wineFlavor, wineLiters, winePacking, wineStock)
        {
            this._cellar = wineCellar;
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder productData = new StringBuilder();

            productData.Append("ID: " + this._idNumber + " ");
            productData.Append("BODEGA: " + this._cellar + " ");
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
