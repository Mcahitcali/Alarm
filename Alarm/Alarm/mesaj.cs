using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class mesaj : Form
    {
        public mesaj()
        {
            InitializeComponent();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            //this.Close();
            aAlarm alrm =new aAlarm();

            alrm.kapat();
        }
    }
}
