using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class CfrmMiain : Form
    {
        public CfrmMiain()
        {
            InitializeComponent();
        }
        Temperature Temp = new Temperature();

        private void CfrmMiain_Load(object sender, EventArgs e)
        {
            //Temperature Temp = new Temperature();
            //Temp.Fahrenheit = double.Parse(txtFahren.Text);
            //Temp.Celsius = double.Parse(txtCelsius.Text);

            txtFahren.Text ="1";
            txtCelsius.Text = Temp.ToCelsius(1.0).ToString("0.00");
            //Temp.Fahrenheit = double.Parse(txtFahren.Text);
            //Temp.Celsius = double.Parse(txtCelsius.Text);
        }
        //Problem when text field is empty code breaks so lets add contingency
        //when text field of one is empty
        //text firld of the other will be zero
        //Look into the is null string method
        //String.Isnullorempty instead
        //Do it in the form loading handler first
        private void txtFahren_TextChanged(object sender, EventArgs e)
        {
            //double Fahren = double.Parse(txtFahren.Text);

            if(String.IsNullOrEmpty(txtFahren.Text))
            {
                txtCelsius.Text = "0.00";
            }
            else
            {
                txtCelsius.Text = Temp.ToCelsius(double.Parse(txtFahren.Text)).ToString("0.00");
            }
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            //double Celsius = double.Parse(txtCelsius.Text);
            //txtFahren.Text = Temp.ToFahrenheit(Celsius).ToString("0.00");

            if (String.IsNullOrEmpty(txtCelsius.Text))
            {
                txtFahren.Text = "0.00";
            }
            else
            {
                txtFahren.Text = Temp.ToFahrenheit(double.Parse(txtCelsius.Text)).ToString("0.00");
            }
        }
    }
}
