using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public sealed class Client
    {
        #region ---------------ATRIBBUTOS--------------
        private int _id;
        private string _businessName;
        private string _fantasyName;
        private List<string> _phoneNumbers; //celular, fijo, radio, otros
        private string _email;
        private string _streetAddres;
        private string _locationAddres;
        private string _cuit;
        #endregion

        #region ---------------PROPIEDADES-------------
        #endregion

        #region --------------CONSTRUCTORES------------
        private Client()
        {
            this._phoneNumbers = new List<string>();
        }

        public Client(int clientId, string clientBusinessName, string clientFantasyName, List<string> clientPhoneNumbers,
            string clientEmail, string clientStreetAddres, string clientLocationAddres, string clientCuit)
            :this()
        {
            this._id = clientId;
            this._businessName = clientBusinessName;
            this._fantasyName = clientFantasyName;
            this._phoneNumbers = clientPhoneNumbers;
            this._email = clientEmail;
            this._streetAddres = clientStreetAddres;
            this._locationAddres = clientLocationAddres;
            this._cuit = clientCuit;
        }
        
        #endregion

        #region -----------------METODOS---------------
        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        #endregion

        #region ----------------ENUMERADOS-------------
        #endregion
    }
}
