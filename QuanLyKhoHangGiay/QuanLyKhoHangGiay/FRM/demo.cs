using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace QuanLyKhoHangGiay.FRM
{
    public partial class demo : Form
    {
        public int MaPN = 0;
        PhieuNhapDTO pn = new PhieuNhapDTO();
        public demo()
        {
            InitializeComponent();
        }

        private void txtMaPN_TextChanged(object sender, EventArgs e)
        {

        }

        private void demo_Load(object sender, EventArgs e)
        {
            txtMaPN.Text = MaPN.ToString();
        }
    }
}
