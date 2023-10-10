using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_lisboks___örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi =Convert.ToInt32(txtSayi.Text);

            if(sayi%2 == 0)
            {
                lbCift.Items.Add(txtSayi.Text);
            }
            else
            {
                lbTek.Items.Add(txtSayi.Text);
            }

        }
    }
}
