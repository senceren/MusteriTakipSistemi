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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Form form = new AnaForm();
            form.ShowDialog();

        }
    }

}
