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

        #region --------------CONSTRUCTORES------------
        public Wine(string wineCommentary, string wineBrand, int winePrice, string wineCellar, string wineFlavor, int wineLiters, int winePacking)
            :base(wineCommentary,wineBrand,winePrice,wineFlavor,wineLiters,winePacking)
        {
            this._cellar = wineCellar;
        }
        #endregion
    }
}
