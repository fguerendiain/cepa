using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using CustomExceptions;

namespace ItemsForSale
{
    public sealed class PriceList
    {
        #region ---------------ATRIBBUTOS--------------
        private List<Product> _articlesList;
        XmlSerializer serXml;

        #endregion

        #region ---------------PROPIEDADES-------------
        public List<Product> ArticlesList
        {
            get { return this._articlesList; }
            set { this._articlesList = value; }
        }
        #endregion

        #region --------------CONSTRUCTORES------------
        public PriceList()
        {
            this._articlesList = new List<Product>();
        }
        #endregion

        #region -----------------METODOS---------------

        public void ImportArticleListFromFile()
        {
            serXml = new XmlSerializer(typeof(List<Product>));
            try
            {
                using (XmlTextReader redXml = new XmlTextReader("../../listaDePrecios.xml"))
                {
                    this._articlesList = (List<Product>)serXml.Deserialize(redXml);
                }
            }
            catch (Exception)
            { 
                throw new ImportArticlesListException();
            }
        }


        public void ExportArticleListToFile()
        {
            serXml = new XmlSerializer(typeof(List<Product>));
            try
            {
                using (XmlTextWriter wriXml = new XmlTextWriter("../../listaDePrecios.xml", Encoding.UTF8))
                {
                    serXml.Serialize(wriXml, this._articlesList);
                }
            }
            catch (Exception)
            {
                throw new ExportArticlesListException();
            }
        }

        #endregion

        #region ----------SOBRECARGA DE METODOS--------
        #endregion

        #region ---------SOBRECARGA DE OPERADORES------
        #endregion

        #region ----------------ENUMERADOS-------------
        #endregion

    }
}
