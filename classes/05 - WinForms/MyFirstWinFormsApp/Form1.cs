using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double liczbaA = double.Parse(liczbaATextBox.Text);
                double liczbaB = double.Parse(liczbaBTextBox.Text);
                double wynik = Math.Sin(liczbaA) + Math.Cos(liczbaB);
                wynikLabel.Text = $"sin({liczbaA})+cos({liczbaB}) = {wynik.ToString(".####")}";

            }
            catch (Exception ex)
            {
                wynikLabel.Text = "Error";
            }

            

        }
    }
}
