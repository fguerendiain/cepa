using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    public sealed class Pasta : Product
    {
        #region ---------------ATRIBBUTOS--------------
        private string _type; //tipo de pasta
        private int _weightInGrams; //peso en gramos
        #endregion

        #region ---------------PROPIEDADES-------------
        public string Type
        {
            get { return this._type;}
            set { this._type = value;}
        }

        public int WeightInGrams
        {
            get { return this._weightInGrams; }
            set { this._weightInGrams = value; }
        }

        // SOBRECARGA DE PROPIEDADES ABSTRACTAS
        public override int IdNumber
        {
            get { return this._idNumber; }
            set { this._idNumber = value; }
        }

        public override string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public override int Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public override string Commentary
        {
            get { return this._commentary; }
            set { this._commentary = value; }
        }

        public override int Packing
        {
            get { return this._packing; }
            set { this._packing = value; }
        }

        public override int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }

        public override int Order
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Pasta() { }

        public Pasta(int pastaIdNumber, string pastaCommentary, string pastaBrand, string pastaType, int pastaPrice, int pastaWeightInGrams, int pastaPacking, int pastaStock, int pastaOrder)
            : base(pastaIdNumber, pastaCommentary, pastaBrand, pastaPrice, pastaPacking, pastaStock, pastaOrder)
        {
            this._type = pastaType;
            this._weightInGrams = pastaWeightInGrams;
        }
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        public override string ToString()
        {
            StringBuilder productData = new StringBuilder();

            productData.Append("ID: " + this._idNumber + " ");
            productData.Append("MARCA: " + this._brand + " ");
            productData.Append("TIPO: " + this._type + " ");
            productData.Append("PAQ: " + this._packing + "X" + this._weightInGrams + "gm ");
            productData.Append("PRECIO: $" + this._price + " ");
            productData.Append("STOCK: " + this._stock + " ");
            productData.Append("OBS: " + this._commentary + " ");

            return productData.ToString();
        }
        #endregion
    }
}
