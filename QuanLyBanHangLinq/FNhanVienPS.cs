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
    public partial class FNhanVienPS : Form
    {
        public int maNV;
        BUS_NhanVien busNhanVien;
        public FNhanVienPS()
        {
            InitializeComponent();
            busNhanVien = new BUS_NhanVien();
        }

        private void FNhanVienPS_Load(object sender, EventArgs e)
        {
            //Lấy thông tin nhân viên
            //Hiển thị ra các textbox
            Employee employee = new Employee();
            employee = busNhanVien.GetEmployee(maNV);
            txtMa.Text = employee.EmployeeID.ToString() ;
            txtHo.Text = employee.LastName;
            txtTen.Text = employee.FirstName;
            txtDiaChi.Text = employee.Address;
            txtDienThoai.Text = employee.HomePhone;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int kq = 0;
            kq = busNhanVien.DeleteEmployeeSP(maNV);
            if (kq == 1)
            {
                MessageBox.Show("Xóa thành công");
                txtDiaChi.Text = txtDienThoai.Text = txtHo.Text = txtMa.Text = txtTen.Text = "";
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.HomePhone = txtDienThoai.Text;
            employee.LastName = txtHo.Text;
            employee.FirstName = txtTen.Text;
            employee.Address = txtDiaChi.Text;
            employee.EmployeeID = int.Parse(txtMa.Text);
            bool kq = busNhanVien.UpdateEmployeeSP(employee);
            if (kq)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.HomePhone = txtDienThoai.Text;
            employee.LastName = txtHo.Text;
            employee.FirstName = txtTen.Text;
            employee.Address = txtDiaChi.Text;
            bool kq = busNhanVien.AddEmployeeSP(employee);
            if (kq)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        
    }
}
