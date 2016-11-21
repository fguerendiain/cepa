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

        #region --------------CONSTRUCTORES------------
        public Appetizer(string appetizerCommentary, string appetizerBrand, int appetizerPrice, string appetizerLiqueur, string appetizerFlavor, int appetizerLiters, int appetizerPacking)
            : base(appetizerCommentary,appetizerBrand,appetizerPrice, appetizerFlavor,appetizerLiters,appetizerPacking)
        {
            this._liqueur = appetizerLiqueur;
        }
        #endregion
    }
}
