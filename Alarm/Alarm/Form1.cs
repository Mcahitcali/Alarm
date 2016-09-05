using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class aAlarm : Form
    {
        public aAlarm()
        {
            InitializeComponent();
        }
       
        #region genel
        private void Form1_Load(object sender, EventArgs e)
        {
            sAyar.Focus();

        }
        
        private void ssaat_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = System.DateTime.Now.ToLongTimeString();
            lbltarih.Text = System.DateTime.Now.ToShortDateString();
            
            
        }
        #endregion
        #region Tema


        public void tema(string renk)
        {
            if (renk==kırmızıTemaToolStripMenuItem.Text)
            {
                this.BackColor = Color.DarkRed;
                
               
            }
             else if (renk == maviTemaToolStripMenuItem.Text)
            {
                this.BackColor = Color.DarkBlue;
                

            }
            else if (renk == yeşilTemaToolStripMenuItem.Text)
            {
                this.BackColor = Color.DarkGreen;
                

            }
            else if (renk == beyazToolStripMenuItem.Text)
            {
                this.BackColor = Color.White;
               
                //foreach (Control kontrol in this)
                {
                   // kontrol.ForeColor = Color.Black;
                }

            }
            else if (renk == siyahToolStripMenuItem.Text)
            {
                this.BackColor = Color.Black;
               
                lblsaat.ForeColor = Color.Cyan;
                lbltarih.ForeColor = Color.Cyan;
                lblayrac.ForeColor = Color.Red;
                lblaciklama.ForeColor = Color.Red;
            }
        }

        private void kırmızıTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(kırmızıTemaToolStripMenuItem.Text);
        }

        private void yeşilTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(yeşilTemaToolStripMenuItem.Text);
        }

        private void maviTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(maviTemaToolStripMenuItem.Text);
        }

        private void siyahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(siyahToolStripMenuItem.Text);
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tema(beyazToolStripMenuItem.Text);
        }
        #endregion
        #region Alarm
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            alrmBsl.BackColor = Color.Green;
            alarm.Enabled = true;
            saat = sAyar.Text;
           // MessageBox.Show("Test");
            if (alrmkucult.Checked==true)
            {
                this.Form1_Resize(sender,e);
            }
            lblaciklama.Text ="Ayarlandı: " + saat;
        }
        string saat = null;
        private void alarm_Tick(object sender, EventArgs e)
        {
            if (saat.ToString()==lblsaat.Text)
            {
                mesaj msg = new mesaj();
                msg.Show();
                alarm.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sAyar.ResetText();
        }
        #endregion

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Hide();
            nIcon.Visible = true;
        }

        private void nIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            }
        }

        private void alarmSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alrmSfr.PerformClick();
        }
        public void kapat()
        {
            alrmBsl.BackColor = Color.Transparent;
            saat = "";
            alarm.Enabled = false;
            MessageBox.Show("Test");
            this.Close();
        }
        private void alarmKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapat();
            
        }
    }
}
