using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public sealed class ExportArticlesListException : Exception
    {
        private string _customErrorMessage;

        public string CustomErrorMessage
        {
            get { return this._customErrorMessage; }
        }

        public ExportArticlesListException()
        {
            this._customErrorMessage = "Error al intentar exportar la lista de precios";
        }
    }
}
