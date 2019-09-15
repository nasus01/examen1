using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinco_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nota1, nota2, nota3, nota4, nota5, total;
            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);
            nota4 = double.Parse(txtnota4.Text);
            nota5 = double.Parse(txtnota5.Text);
            total = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);
            lbltotal.Text = total.ToString();
            
            if (total >= 5)
            {
                MessageBox.Show("te graduas con honores"); 
            }
            else
            if (total >= 4)
            {
                MessageBox.Show("buen rendimiento");
            }
            else
            if (total >= 4.9)
            {
                MessageBox.Show("excelente");
            }
            else
            if (total >= 3)
            {
                MessageBox.Show("aprueba con plan de mejora");
            }
            else
            if (total>=2.9)
            {

                MessageBox.Show("repruevas y puedes hacer abilitacion");

            }
            else
            if (total>=1.0)
            {
                MessageBox.Show("repruevas sin poder abilitar");
            }
        }
    }
}
