using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemsForSale;
using Customers;
using CustomExceptions;

namespace GUI
{
    public partial class Form1 : Form
    {
        PriceList articleList;

        public Form1()
        {
            InitializeComponent();
            this.articleList = new PriceList();

            try
            {
               articleList.ImportArticleListFromFile();
                //Wine vinoPrueba = new Wine(000001,"rico", "Monchennot", 120, "Lopez", "Tinto", 750, 6, 20);
                //Soda gaseosaPrueba = new Soda(000002, "fresca", "Cunnington", 13, "Cola", 1250, 8, 500);
                //Appetizer licorPrueba = new Appetizer(000003, "duro", "Jhonny Walker", 1500, "Whisky", "Black", 1000, 1, 10);
                //Pasta fideosPrueba = new Pasta(000004, "almacen", "Molto", "Tallarines", 8, 500, 10, 5);
                
                //this.articleList.ArticlesList.Add(vinoPrueba);
                //this.articleList.ArticlesList.Add(gaseosaPrueba);
                //this.articleList.ArticlesList.Add(licorPrueba);
                //this.articleList.ArticlesList.Add(fideosPrueba);

                //articleList.ExportArticleListToFile();

                foreach (Product t in articleList.ArticlesList)
                {
                    cmbProductDropDown.Items.Add(t.ToString());
                }
            }
            catch (ImportArticlesListException e)
            {
                MessageBox.Show(e.CustomErrorMessage);
            }
            catch (ExportArticlesListException e)
            {
                MessageBox.Show(e.CustomErrorMessage);
            }

        }
    }
}
