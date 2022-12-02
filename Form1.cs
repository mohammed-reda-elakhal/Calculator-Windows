using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Windows
{
    public partial class Form1 : Form
    {
        Double resultat = 0;
        String opPerfomed = "";
        bool isopPerfomed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void n_click(object sender, EventArgs e)
        {
            if((txtDisplay1.Text == "0") || (isopPerfomed) )
                txtDisplay1.Clear();
            isopPerfomed=false;  
            Button n = (Button) sender;
            if( n.Text == ".")
            {
                if (!txtDisplay1.Text.Contains("."))
                    txtDisplay1.Text = txtDisplay1.Text + n.Text;
            }else
                txtDisplay1.Text = txtDisplay1.Text + n.Text;
        }

        private void txtDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void op_click(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            if( resultat != 0)
            {
                Btnequal.PerformClick();
                opPerfomed = n.Text;
                txtDisplay2.Text = resultat + " " + opPerfomed;
                isopPerfomed = true;
            }else
            {
                opPerfomed = n.Text;
                resultat = Double.Parse(txtDisplay1.Text);
                txtDisplay2.Text = resultat + " " + opPerfomed;
                isopPerfomed = true;
            }
            


        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0"; 
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            txtDisplay2.Text = " ";
            resultat = 0;
        }

        private void Btnequal_Click(object sender, EventArgs e)
        {
            switch (opPerfomed)
            {
                case "+":
                    txtDisplay1.Text = (resultat + Double.Parse(txtDisplay1.Text)).ToString();
                    break;
                case "-":
                    txtDisplay1.Text = (resultat - Double.Parse(txtDisplay1.Text)).ToString();
                    break;
                case "x":
                    txtDisplay1.Text = (resultat * Double.Parse(txtDisplay1.Text)).ToString();
                    break;
                case "/":
                    txtDisplay1.Text = (resultat / Double.Parse(txtDisplay1.Text)).ToString();
                    break;
                

            }
            resultat = Double.Parse(txtDisplay1.Text);
            txtDisplay2.Text = " ";
        }
    }
}
