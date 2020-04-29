﻿using System;
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

        private void BtnCalc_Click(object sender, EventArgs e)
        {


            double valor1, valor2;

            valor1 = double.Parse(txtbase.Text);
            valor2 = double.Parse(txtaltura.Text);

            //-----------------------------------------------------------
            
            if (txtbase.Text == "" || txtaltura.Text == "")
            {

                valor1 = 0;
                valor2 = 0;
                lblAviso.Text = "Favor insira os valores para começar a operação";
                lblAviso.Visible = true;

            }
            else
            //-----------------------------------------------------------

            if (rdbQuadrado.Checked == true && valor1 == valor2)

            {
                lblAviso.Visible = false;
                double Resultado = valor1 * valor1;
                txtResult.Text = Convert.ToString(Resultado);
            }
            else
            if (rdbQuadrado.Checked == true && valor1 != valor2)

            {
                lblAviso.Visible = true;
                lblAviso.Text = "Um quadrado deve ter todos os lados iguais";

            }

            else
            if (rdbRetangulo.Checked == true)
            {
                lblAviso.Visible = false;
                double Resultado = valor1 * valor2;
                txtResult.Text = Convert.ToString(Resultado);
            }

            else
           if (rdbQuadrado.Checked == false && rdbRetangulo.Checked == false && rdbTriangulo.Checked == false && rdbCirculo.Checked == false)
            {
                lblAviso.Text = "Favor selecionar uma caixa para efetuar a operação";
                lblAviso.Visible = true;

            }


        }




        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblAviso.Text = " ";
            txtaltura.Text = "";
            txtbase.Text = "";
            txtResult.Text = "";
            txtaltura.Text = "0";
            txtbase.Text = "0";

            rdbQuadrado.Checked = false;
            rdbTriangulo.Checked = false;
            rdbRetangulo.Checked = false;
        }
    }
}
