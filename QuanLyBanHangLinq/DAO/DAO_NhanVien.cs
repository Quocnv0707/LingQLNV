using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangLinq.DAO
{
    class DAO_NhanVien
    {
        LinqToSqlDataContext db;

        public DAO_NhanVien()
        {
            db = new LinqToSqlDataContext();//Tạo chuỗi kết nối đến db

        }

        //Lấy danh sách nhân viên
        public dynamic GetEmployeesList()
        {
            var list = db.Employees.Select(s => new { 
                s.EmployeeID,
                s.FirstName,             
                s.LastName,
                s.BirthDate,
                s.HomePhone,
                s.Address
            }).ToList();
            return list;
        }
        //Tìm kiếm nhân viên
        public Employee FindEmployee(int employeeID)
        {
            Employee employee = db.Employees.FirstOrDefault(s => s.EmployeeID == employeeID);
            return employee;
        }
        //Sửa thông tin nhân viên
        public void UpdateEmployee(Employee employee)
        {
            //lấy thông tin nhân viên cần sửa
            Employee employee1 = db.Employees.FirstOrDefault(s => s.EmployeeID == employee.EmployeeID);
            //Cập nhật thông tin nhân viên
            employee1.LastName = employee.LastName;
            employee1.FirstName = employee.FirstName;
            employee1.BirthDate = employee.BirthDate;
            employee1.HomePhone = employee.HomePhone;
            employee1.Address = employee.Address;
            //Cập nhật xuống database
            db.SubmitChanges();
        }
        //Thêm nhân viên
        public void AddEmployee(Employee employee)
        {
            //Đã kiểm tra nv
            Employee employeeNew = new Employee();//Tạo 1 nv mới
            //Cập nhật giá trị nv
            //Mã nv tự tăng
            employeeNew.LastName = employee.LastName;
            employeeNew.FirstName = employee.FirstName;
            employeeNew.BirthDate = employee.BirthDate;
            employeeNew.HomePhone = employee.HomePhone;
            employeeNew.Address = employee.Address;
            //Gọi lệnh thêm nv vào datacontext
            db.Employees.InsertOnSubmit(employeeNew);
            //cập nhật xuống database
            db.SubmitChanges();
        }
        //Xóa nhân viên
        public void DeleteEmployee(int employeeID)
        {
            //Tìm nhân viên
            Employee employee = db.Employees.FirstOrDefault(s => s.EmployeeID == employeeID);
            //Xóa nv
            db.Employees.DeleteOnSubmit(employee);
            //Cập nhật thay đổi xuống database
            db.SubmitChanges();
        }
        //Xủ lý bên Store Proc
        public void AddEmployeeSP(Employee employee)
        {
            db.uspInsertEmployee(employee.LastName, employee.FirstName, employee.Address, employee.HomePhone);
            db.SubmitChanges();
        }

        public Employee GetEmployee(int employeeID)
        {
            Employee employee = db.Employees.Where(s => s.EmployeeID == employeeID).Select(s =>s).First();
            return employee;
        }

        public void DeleteEmployeeSP(int employeeID)
        {
            db.uspDeleteEmployee(employeeID);
            db.SubmitChanges();
        }

        public void UpdateEmployeeSP(Employee employee)
        {
            db.uspUpdateEmployee(employee.LastName, employee.FirstName, employee.Address, employee.HomePhone, employee.EmployeeID);
            db.SubmitChanges();
        }
        //Câu 4

        public dynamic TimKiemNhanVien(int employeeID)
        {
            var list = db.Employees.Where(s=>s.EmployeeID==employeeID).Select(s => new {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.Address
            }).ToList();
            return list;
        }
        public dynamic TimKiemNhanVienTheoTen(String ten)
        {
            var list = db.Employees.Where(s => s.FirstName == ten).Select(s => new {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.Address
            }).ToList();
            return list;
        }
        public dynamic TimKiemNhanVienTheoHo(String Ho)
        {
            var list = db.Employees.Where(s => s.LastName == Ho).Select(s => new {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.Address
            }).ToList();
            return list;
        }
    }
}
