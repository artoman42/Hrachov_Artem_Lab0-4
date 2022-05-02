using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 12);
            Color[] colorsAr = new Color[13] { Color.Red, Color.Green, Color.Yellow, Color.White, Color.Gray, Color.Blue, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGray, Color.DarkBlue, Color.DarkRed, Color.YellowGreen };
            SecondButton.BackColor = colorsAr[value];
            double x = Convert.ToDouble(textBox1.Text),
             a = Convert.ToDouble(textBox2.Text),
             b = Convert.ToDouble(textBox3.Text);
            double res = Math.Sqrt(Math.Sign(a * x + b) - Math.Abs(x - b));
            if (FirstButton.BackColor == Color.White) 
                MessageBox.Show(
                    Convert.ToString(res),
                    "Результат",                    
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            else MessageBox.Show(
                    "Не той колір",
                    "Результат",                    
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 12);
            Color[] colorsAr = new Color[13] { Color.Red, Color.Green, Color.Yellow, Color.White, Color.Gray, Color.Blue, Color.Cyan,Color.DarkBlue, Color.DarkCyan, Color.DarkGray, Color.DarkBlue,Color.DarkRed, Color.YellowGreen };
            FirstButton.BackColor = colorsAr[value];
            double x = Convert.ToDouble(textBox1.Text),
             z = Convert.ToDouble(textBox4.Text);
            double res = x - z / (z - Math.Pow(x, 2) / 4) - Math.Pow(x, 2) / 120;
            if (SecondButton.BackColor == Color.Gray)
                MessageBox.Show(
                    Convert.ToString(res),
                    "Результат",                    
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            else MessageBox.Show(
                    "Не той колір",
                    "Результат",                   
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar!=',')
                e.Handled = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure?",
            "Повідомлення",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}
