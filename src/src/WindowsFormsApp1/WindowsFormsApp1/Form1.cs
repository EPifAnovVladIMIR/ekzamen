using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вебToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Пользователь/Desktop/examen/web/index.html");
            Size = new Size(1400, 800);
        }

        private void вебстраница2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Пользователь/Desktop/examen/web/index2.html");
            Size = new Size(1400, 800);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Епифанов Владимир. Вариант №8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text_box1 = textBox1.Text;
                string text_box2 = textBox2.Text;

                int x = int.Parse(text_box1);
                int y = int.Parse(text_box2);

                if ((y <= x + 2) && (x <= 0) && (x * x + y * y <= 25))
                {
                    textBox3.Text = "Принадлежит";
                    Form2 fm2 = new Form2();
                    fm2.Txt = this.textBox3.Text;
                    fm2.ShowDialog();
                }
                else
                {
                    textBox3.Text = "Не принадлежит";
                    Form2 fm2 = new Form2();
                    fm2.Txt = this.textBox3.Text;
                    fm2.ShowDialog();
                }

            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }
    }
}
