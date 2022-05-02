using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        int in_count = 0, count = 0;
        List<StringAr> list = new List<StringAr>();
        List<String> tmp = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringAr ob = new StringAr(in_count, tmp);
            comboBox1.Items.Add(in_count);
            in_count++;
            tmp.Clear();
            list.Add(ob);
            listBox2.Items.Clear();
            textBox1.Text = "";
            count = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int id = (int)comboBox1.SelectedIndex;
            for(int i=0;i<list[id].ar.Count();i++) listBox1.Items.Add(list[id].ar[i]);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(
              list[System.Convert.ToInt32(textBox2.Text)].getElement(System.Convert.ToInt32(textBox3.Text)),
              "Отримання елемента",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            }
            catch
            {
                MessageBox.Show(
                "Не існує такого елемента",
                 "Помилка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int first_i = System.Convert.ToInt32(textBox5.Text), second_i = System.Convert.ToInt32(textBox4.Text);
                list.Add(StringAr.Consolid(list[first_i], list[second_i], in_count));
                comboBox1.Items.Add(in_count);
                in_count++;
            }
            catch
            {

                MessageBox.Show(
                "Перевірте введені дані",
                 "Помилка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = System.Convert.ToInt32(textBox7.Text);
            try
            {
                list[id].serialize();
            }
            catch
            {
                MessageBox.Show(
               "Перевірте введені дані",
                "Помилка",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.DefaultDesktopOnly);
            }
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Add(StringAr.DeSerialize(in_count));
            comboBox1.Items.Add(in_count);
            in_count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

           if(count++ < StringAr.Length)
            {
                tmp.Add(textBox1.Text);
                listBox2.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                 MessageBox.Show(
                 "Ви превисили кількість стрічок в одному об'єкті",
                 "Повідомлення",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
