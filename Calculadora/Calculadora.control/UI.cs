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
using System.Text.RegularExpressions;

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
            if(txtValue.Text.Length == 0)
            {
                MessageBox.Show("Valor Inválido, por favor digite um número válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                txtResult.Text = calc.Soma(Convert.ToDouble(txtValue.Text)).ToString("F2");
                txtValue.Clear();
                txtValue.Select();
            }
          
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
            {
                txtValue.Text += (sender as Button).Text;          
            }
            else if (txtValue.Text[0] == '-' && txtValue.Text.Length < 1)
            {
                MessageBox.Show("Valor Inválido, por favor digite um número válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtResult.Text = calc.Subtrair(Convert.ToDouble(txtValue.Text)).ToString("F2");
                txtValue.Clear();
                txtValue.Select();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("Valor Inválido, por favor digite um número válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValue.Text[0] == '0')
            {
                MessageBox.Show("Não é possível dividir por 0, por favor digite um número diferente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else

            {
                txtResult.Text = calc.Dividir(Convert.ToDouble(txtValue.Text)).ToString("F2");
                txtValue.Clear();
                txtValue.Select();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length == 0)
            {
                MessageBox.Show("Valor Inválido, por favor digite um número válido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtResult.Text = calc.Multiplicar(Convert.ToDouble(txtValue.Text)).ToString("F2");
                txtValue.Clear();
                txtValue.Select();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            txtValue.Select();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            calc.Zerar();
            txtValue.Clear();
            txtResult.Clear();
            txtValue.Select();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar == ',') &&  ((sender as TextBox).SelectionStart == 0 || (sender as TextBox).Text.Contains(",") || ((sender as TextBox).Text.IndexOf('-') > -1)))
                {         
                    e.Handled = true;
                }
                else if(e.KeyChar == '-' && ((sender as TextBox).SelectionStart != 0 || (sender as TextBox).Text.Contains("-")))
                {      
                    e.Handled = true;             
                }
        }

        private void ClickEnviaValor(object sender, EventArgs e)
        {
            txtValue.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(txtValue.Text.Length > 0) 
            { 
            txtValue.Text = txtValue.Text.Remove(txtValue.Text.Length - 1);
            }
            else
            {
            txtValue.Clear();
            }
        }
    }
}

