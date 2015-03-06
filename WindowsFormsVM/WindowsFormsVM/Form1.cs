using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsVM
{
    public partial class Form1 : Form
    {
        public Int64 n;
        double resultado;
        public List<Int64> numbers = new List<Int64>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Interativo_bt(object sender, EventArgs e)
        {
            resultado = iterativo_fact(Double.Parse(caixa.Text));
            
            label.Text = Convert.ToString(resultado);
        }
        
        private void recursivo_bt(object sender, EventArgs e)
        {
            resultado = recursivo_fact(Double.Parse(caixa.Text));
            label.Text = Convert.ToString(resultado);
        }

       
        private double iterativo_fact(double value)
        {
            double num = value;
            for (double i = num - 1; i > 1; i--)
            {
                num *= i;
            }
            Debug.Print(Convert.ToString(num));
            return num;
        
        }
       
        private double recursivo_fact(double value)
        {
            double num = value;
            if (num <= 1) return num = 1;
            return num = num * recursivo_fact(num - 1);
        }



       

    }
}
