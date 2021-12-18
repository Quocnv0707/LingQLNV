using QuanLyBanHangLinq.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangLinq
{
    public partial class FindNV : Form
    {
        BUS_NhanVien busNhanVien;
        public FindNV()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            
            if (rdMa.Checked)
            {
                try
                {
                    int ma = int.Parse(txtInFor.Text.ToString());
                    busNhanVien.TimKiemNhanVien(gVTK, ma);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Mã phải là số!");
                }
            }
            else if (rdHo.Checked)
            {
                String ho = txtInFor.Text;
                busNhanVien.TimKiemNhanVienTheoHo(gVTK, ho);
            }
            else
            {
                String ten = txtInFor.Text;
                busNhanVien.TimKiemNhanVienTheoTen(gVTK, ten);
            }
        }
        public void TimKiem()
        {

        }
    }
}
