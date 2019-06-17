using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Conversor
    {
        //Atributos.
        private double temperaturaC;
        private double temperaturaF;
        private double temperaturaK;

        //Encapsulamento dos atributos.
        public double TemperaturaC { get => temperaturaC; set => temperaturaC = value; }
        public double TemperaturaF { get => temperaturaF; set => temperaturaF = value; }
        public double TemperaturaK { get => temperaturaK; set => temperaturaK = value; }

        //Métodos.

        //Método de calcular Grau Celsius para Fahrenheit.    
        public double CalcularCelsiusToFahr()
        {
            return (TemperaturaF - 32) * 5 / 9;
        }

        //Método de calcular grau Fahrenheit para Celsius.
        public double CalcularFahrenheitToCel()
        {
            return (TemperaturaC * 9 / 5) + 32;
        }

        //Método de calcular grau Celsius para Kelvin.
        public double CalcularCelsiusToKelv()
        { 
            return (temperaturaK - 273.15);
        }

        //Método de calcular grau Kelvin para Celsius.
        public double CalcularKelvinToCel()
        {
            return (temperaturaC + 273.15);
        }

        //Método de calcular grau Fahrenheit para Kelvin.
        public double CalcularFahrenheitToKelv()
        {
            return (temperaturaK - 273.15) * 9 / 5 + 32;
        }

        //Método de calcular grau Kelvin para Fahrenheit.
        public double CalcularKelvinToFahr()
        {
            return (TemperaturaF - 32) * 5 / 9 + 273.15;
        }
    }
}
