using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace EvaluadorDeExpresiones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            double x;
            double fx;
            string expresion;

            Calculo AFunciones = new Calculo();
            expresion = txtF.Text;
            x = Convert.ToDouble(txtX.Text);

            if (AFunciones.Sintaxis(expresion, 'x'))
            {
                fx = AFunciones.EvaluaFx(x);
                lResultado.Text = fx + "";
            }
            else {
                lResultado.Text = "Error de sintaxis";
            }


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtF.Text = "";
            lResultado.Text = "";

        }
    }
}
