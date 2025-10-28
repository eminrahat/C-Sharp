using System;
using System.Drawing;
using System.Windows.Forms;

namespace bilgi_yarışması_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "BAŞLAT butonuna basıp başlatın";
            btnsonraki.Text = "BAŞLAT";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        int soruno = 0, dogru = 0, yanlış = 0;


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label4.Text == label5.Text )
            {

                dogru++;
                lbldoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {

                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnsonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;


            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnsonraki.Text = "SONRAKİ";
            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "2025";
                btnC.Text = "1923";
                btnD.Text = "1771";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "ATATÜRK kaç yılında doğmuştur?";
                btnA.Text = "2025";
                btnB.Text = "1745";
                btnC.Text = "1923";
                btnD.Text = "1881";
                label4.Text = "1881";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "ATATÜRK kaç yılında TÜRKİYE CUMHURİYETİNE veda etmiştir?";
                btnA.Text = "1938";
                btnB.Text = "1841";
                btnC.Text = "1925";
                btnD.Text = "1963";
                label4.Text = "1938";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "agalarla en çok yenen yemek?";
                btnA.Text = "Tavuk Dünyası";
                btnB.Text = "ARBYS";
                btnC.Text = "EkonomiKingsMenu";
                btnD.Text = "Ben tokum";
                label4.Text = "EkonomiKingsMenu";

            }
            if(soruno == 5) 
                {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                lblsoruno.Visible = false;
                label1.Text = "BİTTİ!!!!";
            }
            if (soruno > 4)
            {
                richTextBox1.Text = "tebrikler sınavı bitirdiniz sonuç ne olursa olsun harikaydınız.";
            }
            if (dogru >= 3 && soruno > 4)
            {
                MessageBox.Show("tebrikler HELALİNDEN kazandınız");
            }
            if (yanlış >= 2 && soruno > 4)
            {
                MessageBox.Show("maalesef kaybedettiniz ama dünyanın sonu değil bir dahakine!!!!!!");
            }
        }
    }
}