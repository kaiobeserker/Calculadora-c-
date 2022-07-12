using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variável global:
        bool clicouNoOperador = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
           var btnClicado = sender as Button;
            txtTela.Text += btnClicado.Text;

            clicouNoOperador = false;
        }
        private void Operacao_Click(object sender, EventArgs e)
        {
            var btnClicado = sender as Button;
            // Só atribuir na tela se não tiver clicado no operador:
            if (clicouNoOperador == false)
            {
                txtTela.Text += btnClicado.Text;
                clicouNoOperador = true;
            }
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
           
                float result = float.Parse(new DataTable().Compute(txtTela.Text, null).ToString());
                txtTela.Text = result.ToString();
            
            
                    }
        
    }

}
