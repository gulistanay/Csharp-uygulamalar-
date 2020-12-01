using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void listBox1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = -525; i <= 525; i++)           //İlgili ListBox'a tıklanıldığında değerler ekrana geliyor.
            {
                if (i % 4 == 0 && i % 3 == 0)       //Aynı anda 3'e ve 4'e bölünüyorsa
                {

                    string bolunen;
                    bolunen = Convert.ToString(i);
                    listBox1.Items.Add(bolunen);       
                }

            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = -525; i <= 525; i++)
            {
                if (i % 3 == 0 && i % 4 != 0)       //3'e bölünüp 4'e bölünemiyorsa
                {
                    string bolunen;
                    bolunen = Convert.ToString(i);
                    listBox2.Items.Add(bolunen);
                }

            }
        }

        private void listBox3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = -525; i <= 525; i++)
            {
                if (i % 3 != 0 && i % 4 == 0)           //4'e bölünüp 3'e bölünemiyorsa
                {
                    string bolunen;
                    bolunen = Convert.ToString(i);
                    listBox3.Items.Add(bolunen);
                }

            }
        }

        private void listBox4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = -525; i <= 525; i++)
            {
                if (i % 3 != 0 && i % 4 != 0)           //Hem 3'e hem de 4'e bölünemiyorsa
                {
                    string bolunen;
                    bolunen = Convert.ToString(i);
                    listBox4.Items.Add(bolunen);
                }

            }
        }
    }
}
