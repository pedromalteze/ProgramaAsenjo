using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = double.Parse(txtbase.Text);
            valor2 = double.Parse(txtaltura.Text);

            if (rdbQuadrado.Checked == true && rdbRetangulo.Checked == false && rdbTriangulo.Checked == false)
            {
                double Resultado = valor1 * valor1;
                txtResult.Text = Convert.ToString(Resultado);
            }
            else
                if (rdbQuadrado.Checked == false && rdbRetangulo.Checked == true && rdbTriangulo.Checked == false)
            {
                double Resultado = valor1 * valor2;
                txtResult.Text = Convert.ToString(Resultado);
            }
            else
                if (rdbQuadrado.Checked == false && rdbRetangulo.Checked == false && rdbTriangulo.Checked == true)
            {
                double Resultado = (valor1 * valor2) / 2;
                txtResult.Text = Convert.ToString(Resultado);
            }
            else
                if(txtResult.Text == "" || txtbase.Text == "" || txtaltura.Text == "")
            {
                lblAviso.Text = "Favor insira os valores para começar a operação";
            }
            else
                lblAviso.Text = "Favor selecionar uma caixa para efetuar a operação";
        }



        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Text = "";
            txtbase.Text = "";
            txtResult.Text = "";
            rdbQuadrado.Checked = false;
            rdbTriangulo.Checked = false;
            rdbRetangulo.Checked = false;
        }
    }
}