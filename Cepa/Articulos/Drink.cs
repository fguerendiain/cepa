using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    public abstract class Drink : Product
    {
        #region ---------------ATRIBBUTOS--------------
        protected string _flavor; //sabor
        protected int _liters; //litros
        #endregion

        #region --------------CONSTRUCTORES------------
        public Drink(string drinkCommentary, string drinkBrand, int drinkPrice, string drinkFlavor, int drinkLiters, int drinkPacking)
            : base(drinkCommentary, drinkBrand, drinkPrice,drinkPacking)
        {
            this._flavor = drinkFlavor;
            this._liters = drinkLiters;
        }
        #endregion
    }
}
