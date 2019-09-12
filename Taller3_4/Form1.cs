using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1 = Convert.ToDouble(textBox1.Text);
            Double n2 = Convert.ToDouble(textBox2.Text);
            Double n3 = Convert.ToDouble(textBox3.Text);
            Double n4 = Convert.ToDouble(textBox4.Text);
            Double n5 = Convert.ToDouble(textBox5.Text);
            Double suma = n1 + n2 + n3 + n4 + n5;
            Double promedio = suma / 5;
            if (promedio > 3.5)
                lblmensaje.Text = "ha superado la materia";
            else
            {
                lblmensaje.Text = "no superó la competencia de la materia.";
            }
        }
    }
}
