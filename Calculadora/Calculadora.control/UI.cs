using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace Calculadora.control
{
    public partial class UI: UserControl
    {
        public UI()
        {
            InitializeComponent();
        }

        Calculadora.Calculos calc = new Calculadora.Calculos();
        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResult.Text = calc.Soma(Convert.ToDouble(txtValue.Text)).ToString("F2");
            txtValue.Clear();
            txtValue.Select();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txtResult.Text = calc.Subtrair(Convert.ToDouble(txtValue.Text)).ToString("F2");
            txtValue.Clear();
            txtValue.Select();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResult.Text = calc.Dividir(Convert.ToDouble(txtValue.Text)).ToString("F2");
            txtValue.Clear();
            txtValue.Select();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResult.Text = calc.Multiplicar(Convert.ToDouble(txtValue.Text)).ToString("F2");
            txtValue.Clear();
            txtValue.Select();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            txtResult.Clear();
        }
    }
}

