using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public sealed class ImportArticlesListException : Exception
    {
        private string _customErrorMessage;

        public string CustomErrorMessage
        {
            get { return this._customErrorMessage; }
        }

        public ImportArticlesListException()
        {
            this._customErrorMessage = "Error al intentar importar la lista de precios";
        }


    }
}
