using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsForSale
{
    //Gaseosa
    public sealed class Soda : Drink
    {
        #region --------------CONSTRUCTORES------------
        public Soda(string sodaCommentary,string sodaBrand, int sodaPrice, string sodaFlavor, int sodaLiters, int sodaPacking)
            : base(sodaCommentary,sodaBrand,sodaPrice,sodaFlavor,sodaLiters,sodaPacking)
        {
        }
        #endregion
    }
}
