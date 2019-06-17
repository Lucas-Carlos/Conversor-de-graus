using System;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            //Instanciação.
            Conversor conversor = new Conversor();


            //Convesor de CELSIUS para Fahrenheit e Kelvin.
            try
            { 
                if (rdbCelsiusToFahrKelv.Checked == true)
                {
                    conversor.TemperaturaC = Double.Parse(txtCelsius.Text);
                    txtFahrenheit.Text = Convert.ToString(conversor.CalcularFahrenheitToCel());
                    txtKelvin.Text = Convert.ToString(conversor.CalcularKelvinToCel());                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vazio ou número não válido!");
            }


            //Convesor de FAHRENHEIT para Celsius e Kelvin.
            try
            { 
                if (rdbFahrenheitToCelKelv.Checked == true)
                {
                    conversor.TemperaturaF = Double.Parse(txtFahrenheit.Text);
                    txtCelsius.Text = Convert.ToString(conversor.CalcularCelsiusToFahr());
                    txtKelvin.Text = Convert.ToString(conversor.CalcularKelvinToFahr());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vazio ou número não válido!");
            }


            //Convesor de KELVIN para Celsius e Fahrenheit.
            try
            {
                if (rdbKelvinToCelFahr.Checked == true)
                {
                    conversor.TemperaturaK = Double.Parse(txtKelvin.Text);
                    txtCelsius.Text = Convert.ToString(conversor.CalcularCelsiusToKelv());
                    txtFahrenheit.Text = Convert.ToString(conversor.CalcularFahrenheitToKelv());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campo vazio ou caractere não numeral!");
            }
        }

        //Ações do radio button Celsius para Fahrenheit/Kelvin.
        private void rdbCelsiusparaf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCelsiusToFahrKelv.Checked == true)
            {
                txtCelsius.Enabled = true;
                txtFahrenheit.Enabled = false;
                txtKelvin.Enabled = false;               
            }
        }

        //Ações do radio button Fahrenheit para Celsius/Kelvin.
        private void rdbFahrenheitparack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFahrenheitToCelKelv.Checked == true)
            {
                txtCelsius.Enabled = false;
                txtFahrenheit.Enabled = true;
                txtKelvin.Enabled = false;
            }
        }

        //Ações do radio button Kelvin para Celsius/Fahrenheit.
        private void rdbKelvinparacf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKelvinToCelFahr.Checked == true)
            {
                txtCelsius.Enabled = false;
                txtFahrenheit.Enabled = false;
                txtKelvin.Enabled = true;
            }
        }
    }
}