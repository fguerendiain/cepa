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
        protected string _type; //tipo de pasta
        protected int _weightInGrams; //peso en gramos
        #endregion

        #region --------------CONSTRUCTORES------------
        public Pasta(string pastaCommentary, string pastaBrand, string pastaType, int pastaPrice, int pastaWeightInGrams, int pastaPacking)
            : base(pastaCommentary, pastaBrand, pastaPrice, pastaPacking)
        {
            this._type = pastaType;
            this._weightInGrams = pastaWeightInGrams;
        }
        #endregion
    }
}
