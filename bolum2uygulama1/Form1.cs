using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            int yas = 14;

            if (yas >= 18) { 
               MessageBox.Show("ehliyet alabilirsiniz");
            }

            if (yas < 18) 

                    MessageBox.Show("üzgünüm biraz daha büyümelisin");
           
            {

            }
            {


            }
        }
    }
}
