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
    public partial class FQLNV : Form
    {
        BUS_NhanVien busNhanVien;
        public FQLNV()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
            
        }

        private void FQLNV_Load(object sender, EventArgs e)
        {
            busNhanVien.GetEmployeesList(gVNV);
        }

        private void gVNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gVNV.Rows.Count)
            {
                txtHoten.Text = gVNV.Rows[e.RowIndex].Cells["LastName"].Value.ToString() + " " +
                                    gVNV.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtDiaChi.Text = gVNV.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtDienThoai.Text = gVNV.Rows[e.RowIndex].Cells["HomePhone"].Value.ToString();
                
                if (gVNV.Rows[e.RowIndex].Cells["BirthDate"].Value == null)
                    dtpNgaySinh.Text = DateTime.Now.ToString();
                else
                    dtpNgaySinh.Text = gVNV.Rows[e.RowIndex].Cells["BirthDate"].Value.ToString();
            }
        }
        private String[] TachTu(String str)
        {
            char[] token = { ' ', ',' };
            return str.Split(token);
        }
        private String GetLatName(String str)
        {          
            String[] s = str.Split(' ');
            String lastName = s[0];
            return lastName;
        }
        private String GetFirstName(String str)
        {
            int index = GetLatName(str).Length;
            return str.Substring(index).Trim();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmployeeID = int.Parse(gVNV.CurrentRow.Cells[0].Value.ToString());
                employee.Address = txtDiaChi.Text;
                employee.HomePhone = txtDienThoai.Text;
                employee.BirthDate = dtpNgaySinh.Value;
                employee.LastName = GetLatName(txtHoten.Text);
                employee.FirstName = GetFirstName(txtHoten.Text);
                int result = -1;
                result = busNhanVien.UpdateEmployee(employee);
                if (result == 0)
                    MessageBox.Show("nhân viên không tồn tại");
                else if (result == 1)
                {
                    MessageBox.Show("Sửa thành công");
                    busNhanVien.GetEmployeesList(gVNV);
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }          

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            //employee.EmployeeID = int.Parse(gVNV.CurrentRow.Cells[0].Value.ToString());
            employee.Address = txtDiaChi.Text;
            employee.HomePhone = txtDienThoai.Text;
            employee.BirthDate = dtpNgaySinh.Value;
            employee.LastName = GetLatName(txtHoten.Text);
            employee.FirstName = GetFirstName(txtHoten.Text);
            if (busNhanVien.AddEmployee(employee))
            {
                MessageBox.Show("Thêm thành công");
                busNhanVien.GetEmployeesList(gVNV);
            }
            else MessageBox.Show("Thêm thất bại");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int result = -1;
            result = busNhanVien.DeleteEmployee(int.Parse(gVNV.CurrentRow.Cells[0].Value.ToString()));
            if (result == 0)
                MessageBox.Show("nhân viên không tồn tại");
            else if (result == 1)
            {
                MessageBox.Show("Xóa thành công");
                busNhanVien.GetEmployeesList(gVNV);
            }
            else
                MessageBox.Show("Xóa thất bại");

        }

        private void gVNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FNhanVienPS f = new FNhanVienPS();
            f.maNV = int.Parse(gVNV.CurrentRow.Cells[0].Value.ToString());
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNhanVienPS f = new FNhanVienPS();
            f.maNV = int.Parse(gVNV.CurrentRow.Cells[0].Value.ToString());
            f.Show();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            FindNV f = new FindNV();
            f.Show();
        }
    }
}
