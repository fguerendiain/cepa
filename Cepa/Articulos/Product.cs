using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    public abstract class Product
    {
        #region ---------------ATRIBBUTOS--------------
        protected string _brand; //marca
        protected int _price; //precio
        protected string _commentary; //comentario
        protected int _packing; //empaque
        #endregion

        #region ---------------PROPIEDADES-------------
        public virtual int PricePerPackage
        {
            get { return (this._price * this._packing); }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public Product(string productCommentary, string productBrand, int productPrice, int productPacking)
        {
            this._commentary = productCommentary;
            this._brand = productBrand;
            this._price = productPrice;
            this._packing = productPacking;
        }
        #endregion
     }
}
