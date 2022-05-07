using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        double p = 0.6;
        double a;
        double[] prob = { 0.1, 0.15, 0.1, 0.15, 0.2, 0.05, 0.2, 0.05};
        string[] pred = { "Сомневаюсь", "Однозначно да", "Будущее туманно", "Не стоит", "Забудь", "Никогда", "Вполне возможно", "Самое время!"};
        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            a = r.NextDouble();
            
            if (a <= p) textBox2.Text = "Yeah"; 
            else textBox2.Text = "Nooo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double summ = 0;
            
            for (int i = 0; i < 8; i++)
            {
                textBox2.Clear();
                summ += prob[i];
                a = r.NextDouble();
                
                if (a < summ) 
                { 
                    textBox2.Text = pred[i]; 
                    break; 
                }
            }
        }
    }  
}
