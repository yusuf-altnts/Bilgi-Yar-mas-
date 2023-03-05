using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4__Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorus = 0, dogrusayısı = 0 , yanlışsayısı = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnsonra.Enabled = true;

            btnB.Enabled= false;
            btnA.Enabled= false;    
            btnC.Enabled= false;    
            btnD.Enabled= false;

            b.Text = btnB.Text;

            if (a.Text ==b.Text)
            {
                dogrusayısı++;
                dogrus.Text = dogrusayısı.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                yanlışsayısı++;
                yanlıss.Text = yanlışsayısı.ToString();
                pictureBox2.Visible=true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnsonra.Enabled = true;

            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnB.Enabled = false;

            b.Text = btnC.Text;
            if (a.Text == b.Text)
            {
                dogrusayısı++;
                dogrus.Text = dogrusayısı.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlışsayısı++;
                yanlıss.Text = yanlışsayısı.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnsonra.Enabled = true;

            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnB.Enabled = false;

            b.Text = btnD.Text;

            if (a.Text == b.Text)
            {
                dogrusayısı++;
                dogrus.Text = dogrusayısı.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlışsayısı++;
                yanlıss.Text = yanlışsayısı.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnsonra.Enabled = true;

            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnB.Enabled = false;   

            b.Text = btnA.Text;

            if (a.Text == b.Text)
            {
                dogrusayısı++;
                dogrus.Text = dogrusayısı.ToString();
                pictureBox1.Visible = true; 
            }
            else
            {
                yanlışsayısı++;
                yanlıss.Text = yanlışsayısı.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnsonra_Click(object sender, EventArgs e)

        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnB.Enabled = true;
            btnsonra.Enabled = false;
            sorus++;
            soruno.Text = Convert.ToString(sorus);

            if (sorus == 1 )
            {
                richTextBox1.Text = "cumhuriyet kaç yılında ilan edildi ?";
                btnA.Text = "1920"; btnB.Text = "1922"; btnC.Text = "1900"; btnD.Text = "1923";

                a.Text = "1923";
            }
            else if (sorus == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege Bölgemizde Bulunmaz?";
                btnA.Text = "Ankara"; btnB.Text = "İzmir"; btnC.Text = "Balıkesir"; btnD.Text = "Manisa";
                a.Text = "Ankara";

            }
            else if(sorus == 3)
            {
                richTextBox1.Text = "Son Kuşlar Hangi Yazara Aittir?";
                btnA.Text = "Sait Faik"; btnB.Text = "Cemal Süreyya"; btnC.Text = "Atilla İlhan"; btnD.Text = "Reşat Nuri";

                a.Text = "Sait Faik";
                btnsonra.Text = "Sonuçlar";
                
            }
            else if (sorus == 4)
            {
                btnA.Enabled= false;
                btnB.Enabled= false;
                btnC.Enabled= false;
                btnD.Enabled= false;
                btnsonra.Enabled= false;
                MessageBox.Show("Doğru Sayısı: " + dogrusayısı + "\n" + "Yanlış Sayısı:" + yanlışsayısı ) ;
                richTextBox1.Text = " ";
            }


                
        }
    }
}
