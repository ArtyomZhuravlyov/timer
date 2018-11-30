using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "65536 - ";
            label9.Text = "FFFF - ";
            double a;
            double b;
            

           
            if (textBox4.Text.ToString().IndexOf(".") > -1) //не считает при точке // поиск точки в текст боксе 4
            {
               textBox4.Text = textBox4.Text.ToString().Replace(".", ","); //замена точки на запятую
            }

            try
            {
                int a1 = Convert.ToInt32(textBox1.Text);
                int a2 = Convert.ToInt32(textBox2.Text);
                int a3 = Convert.ToInt32(textBox3.Text);

                a = Convert.ToDouble((double)a1 * 1000000 / (double)a2 / (double)a3); //частота на делители
                //a = (double)(a1 * 1000000 / a2 / a3); //частота на делители
                //a = Convert.ToDouble(Convert.ToDouble(textBox1.Text) * 1000000 / Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox3.Text)); //частота на делитель

                b = Convert.ToDouble(textBox4.Text) * a; // время на количество тактов в секунду

                //textBox5.Text = b.ToString("#.##"); //задаём формат
                textBox5.Text = b.ToString("#.##"); //задаём формат
                b = Convert.ToDouble(textBox5.Text); //записываем dec

                

                
                textBox7.Text = b.ToString("#");
                label7.Text += textBox7.Text;

                int g = Convert.ToInt32(textBox7.Text);
                textBox6.Text = Convert.ToString(g, 16); // преобразуем в 16 ричное

                int g1 = 65536 - Convert.ToInt32(textBox7.Text);
                textBox7.Text = g1.ToString();

                 

                label9.Text += textBox6.Text;
                textBox8.Text = Convert.ToString(g1,16); // преобразуем в 16 ричное 
                //textBox7.Text = a.ToString();
                                                textBox1.TextAlign = HorizontalAlignment.Center; // просто пример для отцентровки
                
                // textBox5.Text = b.ToString();
                //label7.Text += b.ToString();
                //MessageBox.Show(
                //"b=" + b.ToString());
            }
            catch
            {
                MessageBox.Show(
        "Проверьте введённые данные" , "Ошибка");
            }

           
            
       
        //MessageBoxButtons.YesNo,
        //MessageBoxIcon.Information,
        //MessageBoxDefaultButton.Button1,
        //MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
