using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    //aperitivo
    public sealed class Appetizer : Drink
    {
        #region ---------------ATRIBBUTOS--------------
        private string _liqueur; //licor
        #endregion

        #region ---------------PROPIEDADES-------------
        public string Liqueur
        {
            get { return this._liqueur; }
            set { this._liqueur = value; }
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
        public Appetizer() { }

        public Appetizer(int appetizerIdNumber, string appetizerCommentary, string appetizerBrand, int appetizerPrice, string appetizerLiqueur, string appetizerFlavor, int appetizerLiters, int appetizerPacking, int appetizerStock,int appetizerOrder)
            : base(appetizerIdNumber, appetizerCommentary, appetizerBrand, appetizerPrice, appetizerFlavor, appetizerLiters, appetizerPacking, appetizerStock,appetizerOrder)
        {
            this._liqueur = appetizerLiqueur;
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder productData = new StringBuilder();
            
            productData.Append("ID: " + this._idNumber + " ");
            productData.Append("LICOR: " + this._liqueur+ " ");
            productData.Append("MARCA: " + this._brand + " ");
            productData.Append("SABOR: " + this._flavor+ " ");
            productData.Append("PAQ: " + this._packing + "X" + this._liters + "cc ");
            productData.Append("PRECIO: $" + this._price + " ");
            productData.Append("STOCK: " + this._stock + " ");
            productData.Append("OBS: " + this._commentary + " ");

            return productData.ToString();
        }
        #endregion
    }
}
