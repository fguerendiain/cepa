using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ItemsForSale
{
    [XmlInclude(typeof(Drink))]
    [XmlInclude(typeof(Pasta))]
    [XmlInclude(typeof(Appetizer))]
    [XmlInclude(typeof(Soda))]
    [XmlInclude(typeof(Wine))]
    public abstract class Product
    {
        #region ---------------ATRIBBUTOS--------------
        protected int _idNumber;
        protected string _brand; //marca
        protected int _price; //precio
        protected string _commentary; //comentario
        protected int _packing; //empaque
        protected int _stock;
        #endregion

        #region ---------------PROPIEDADES-------------
        public virtual int PricePerPackage
        {
            get { return (this._price * this._packing); }
        }

        public abstract int IdNumber { get; set; }
        public abstract string Brand { get; set; }
        public abstract int Price { get; set; }
        public abstract string Commentary { get; set; }
        public abstract int Packing { get; set; }
        public abstract int Stock { get; set; }
        #endregion

        #region --------------CONSTRUCTORES------------

        public Product() { }

        public Product(int idNumber, string productCommentary, string productBrand, int productPrice, int productPacking, int stock)
        {
            this._idNumber = idNumber;
            this._commentary = productCommentary;
            this._brand = productBrand;
            this._price = productPrice;
            this._packing = productPacking;
            this._stock = stock;
        }
        #endregion
    }
}
