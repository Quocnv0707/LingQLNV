using QuanLyBanHangLinq.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangLinq.BUS
{
    class BUS_NhanVien
    {
        //Tạo mới 1 đối tượng DAONhanVien
        DAO_NhanVien daoNhanVien;

        public BUS_NhanVien()
        {
            daoNhanVien = new DAO_NhanVien();
        }

        public void  GetEmployeesList(DataGridView dg)
        {
            dg.DataSource = daoNhanVien.GetEmployeesList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int result = -1;
            try
            {
                if (daoNhanVien.FindEmployee(employee.EmployeeID) == null)
                {
                    result = 0;//nv không tồn tại
                }
                else //nv tồn tại
                {
                    daoNhanVien.UpdateEmployee(employee);
                    result = 1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        
        public bool AddEmployee(Employee employee)
        {
            bool result = false;
            try
            {
                daoNhanVien.AddEmployee(employee);
                //kiểm tra nhân viên thêm thành công chưa?-> proc
                result = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public int DeleteEmployee(int employeeID)
        {
            int result = -1;
            try
            {
                if (daoNhanVien.FindEmployee(employeeID) == null)
                {
                    result = 0;//nv không tồn tại
                }
                else //nv tồn tại
                {
                    daoNhanVien.DeleteEmployee(employeeID);
                    result = 1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        //Store Proc
        public Employee  GetEmployee(int employeeID)
        {
            Employee employee = new Employee();
            try
            {
                employee = daoNhanVien.GetEmployee(employeeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return employee;
        }

        public int DeleteEmployeeSP(int employeeID)
        {
            int kq = 0;
            try
            {
                daoNhanVien.DeleteEmployeeSP(employeeID);
                kq = 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            return kq;
        }

        public bool AddEmployeeSP(Employee employee)
        {
            bool kq = false;
            try
            {
                daoNhanVien.AddEmployeeSP(employee);
                kq = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }

        public bool UpdateEmployeeSP(Employee employee)
        {
            bool kq = false;
            try
            {
                daoNhanVien.UpdateEmployeeSP(employee);
                kq = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nhân viên không tồn tại");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            return kq;
        }
        //câu 4
        public void TimKiemNhanVien(DataGridView dg, int employeeID)
        {
            dg.DataSource = daoNhanVien.TimKiemNhanVien(employeeID);
        }
        public void TimKiemNhanVienTheoTen(DataGridView dg, String ten)
        {
            dg.DataSource = daoNhanVien.TimKiemNhanVienTheoTen(ten);
        }
        public void TimKiemNhanVienTheoHo(DataGridView dg, String ho)
        {
            dg.DataSource = daoNhanVien.TimKiemNhanVienTheoHo(ho);
        }
    }
    
}
