using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaCorp
{
    public partial class PlantillaCorp : Form
    {

        ArrayList Vector1;
        public PlantillaCorp()
        {
            InitializeComponent();
            Vector1 = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plantilla.Clear();
            

            if (!string.IsNullOrEmpty(Convert.ToString(lista.Text)))
            {
                string IdOrder = Convert.ToString(lista.Text.Trim());

                //replacing "enter" i.e. "\n" by "," 
                string temp = IdOrder.Replace("\r\n", ",");

                string[] ArrIdOrders = Regex.Split(temp, ",");

                for (int z = 0; z < ArrIdOrders.Length; z++)
                {
                    Vector1.Add(lista.Text.ToString());
                    string div = "<div class='uk-width-small-1-1 uk-width-medium-1-3 uk-width-large-1-4'>";
                    string div1 = "<div class='catalogo-grid'>";
                    string img = "<img src = '/images/jpg/catalogo/rm/" + Convert.ToString(ArrIdOrders[z]) + ".jpg' alt='"+ Convert.ToString(ArrIdOrders[z]) + "' href='/images/jpg/catalogo/rm/uno/"+ Convert.ToString(ArrIdOrders[z]) + ".jpg' data-uk-lightbox='{group:''}' title='"+ Convert.ToString(ArrIdOrders[z]) + "'><a href = '/'>";
                    string enter = Environment.NewLine;
                    plantilla.Text += div +enter+ div1 +enter+ img + Convert.ToString(ArrIdOrders[z]) + enter + "</a><hr></div></div>" + enter;
                }
            }

            //int i;
            //for (i=0; i < Vector1.Count; i++) {
            //    string div  = "<div class='uk-width-small-1-1 uk-width-medium-1-3 uk-width-large-1-4'>";
            //    string div1 = "< div class='catalogo-grid'>";
            //    string cadena = "<img src = '/images/jpg/catalogo/rm/uno/RM-203.jpeg' alt='18-R73' href='/images/jpg/catalogo/rm/uno/RM-203.jpeg' data-uk-lightbox='{group:''}' title='RM-203'><a href = '/' >";
            //    plantilla.Text = div + div1 + cadena + Convert.ToString(Vector1[i])  + "\n </a><hr></div> </div>";

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plantilla.Clear();
            lista.Clear();
        }
    }
}
