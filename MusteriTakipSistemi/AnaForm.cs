using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriTakipSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        private void btnMusteriEkleme_Click(object sender, EventArgs e)
        {
            Form form = new MusteriEklemeForm();
            form.ShowDialog();
        }



        private void btnMusteriGoruntule_Click(object sender, EventArgs e)
        {
            Form form = new MusteriGoruntuleForm();
            form.ShowDialog();
        }

        private void btnFiyatlar_Click(object sender, EventArgs e)
        {
            Form form = new FiyatlarForm();
            form.ShowDialog();
        }
    }
}
