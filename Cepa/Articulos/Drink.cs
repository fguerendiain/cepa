using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ItemsForSale
{
    [XmlInclude(typeof(Appetizer))]
    [XmlInclude(typeof(Soda))]
    [XmlInclude(typeof(Wine))]
    public abstract class Drink : Product
    {
        #region ---------------ATRIBBUTOS--------------
        protected string _flavor; //sabor
        protected int _liters; //litros
        #endregion

        #region ---------------PROPIEDADES-------------
        public abstract string Flavor { get; set; }
        public abstract int Liters { get; set; }

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
        #endregion

        #region --------------CONSTRUCTORES------------

        public Drink(){ }

        public Drink(int drinkIdNumber, string drinkCommentary, string drinkBrand, int drinkPrice, string drinkFlavor, int drinkLiters, int drinkPacking, int drinkStock)
            : base(drinkIdNumber, drinkCommentary, drinkBrand, drinkPrice,drinkPacking, drinkStock)
        {
            this._flavor = drinkFlavor;
            this._liters = drinkLiters;
        }
        #endregion

    }
}
