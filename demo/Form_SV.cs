using demo.DAL;
using demo.DLL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frm_SV : Form
    {
        private StudentService studentService;
        private FacultyService facultyService;
        public frm_SV()
        {
            InitializeComponent();
            studentService = new StudentService();
            facultyService = new FacultyService();
        }


        private void frm_SV_Load(object sender, EventArgs e)
        {
            Read_Faculty_DB();
            Create_Header_dgv();
            Read_data_DB();
        }
        private void Read_Faculty_DB()
        {
            List<Faculty> facultyList = facultyService.GetAllFaculties();
            cbo_cn.DataSource = facultyList;
            cbo_cn.DisplayMember = "FacultyName";
            cbo_cn.ValueMember = "FacultyID";
        }
        
        private void Create_Header_dgv()
        {
            dgv_qlsv.Columns.Add("StudentID", "MSSV");
            dgv_qlsv.Columns.Add("FullName", "Ho Ten");
            dgv_qlsv.Columns.Add("DiemTB", "DTB");
            dgv_qlsv.Columns.Add("FacultyID", "Ma Khoa");
        }


        private void Read_data_DB()
        {
            dgv_qlsv.Rows.Clear();
            List<Student> studentList = studentService.GetAllStudents();
            foreach(Student sv in studentList)
            {
                int index = dgv_qlsv.Rows.Add();
                dgv_qlsv.Rows[index].Cells["StudentID"].Value = sv.StudentID;
                dgv_qlsv.Rows[index].Cells["FullName"].Value = sv.FullName;
                dgv_qlsv.Rows[index].Cells["DiemTB"].Value = sv.DTB;
                dgv_qlsv.Rows[index].Cells["FacultyID"].Value = sv.FacultyID;
            }
            dgv_qlsv.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Tao phuong thuc tra ve
        private Student Read_data_SV()
        {
            Student sv = new Student();
            string mssv = txt_mssv.Text.Trim();
            if(int.TryParse(mssv, out int masv) == false)
            {
                throw new Exception("MSSV khong hop le");
            }
            sv.StudentID = masv;

            string ht = txt_ht.Text.Trim();
            if (string.IsNullOrEmpty(ht))
            {
                throw new Exception("Ho ten khong duoc de trong");
            }
            sv.FullName = ht;

            string dtb = txt_dtb.Text.Trim();
            if(double.TryParse(dtb, out double diemtb) == false)
            {
                throw new Exception("Diem TB khong hop le");
            }
            if(diemtb < 0 || diemtb > 10)
            {
                throw new Exception("Diem TB phai trong khoang 0 den 10");
            }
            sv.DTB = diemtb;

            string khoa = cbo_cn.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(khoa))
            {
                throw new Exception("Khoa/Chuyen nganh chua duoc chon");
            }
            sv.FacultyID = int.Parse(khoa);

            return sv;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Read_data_SV();
                Student existingStudent
                    = studentService.GetStudent(student.StudentID);
                if (existingStudent != null)
                {
                    throw new Exception("Ma so SV da ton tai");
                }
                studentService.addStudent(student);
                MessageBox.Show("Them MSSV thanh cong!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Read_data_DB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Read_data_SV();
                Student existingStudent
                    = studentService.GetStudent(student.StudentID);
                if(existingStudent == null)
                {
                    throw new Exception("Chua co MSSV ma muon cap nhat?");
                }
                studentService.updateStudent(student);
                MessageBox.Show("Cap nhat MSSV thanh cong!", "Thong bao",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Read_data_DB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = Read_data_SV();
                Student existingStudent
                    = studentService.GetStudent(student.StudentID);
                if (existingStudent == null)
                {
                    throw new Exception("Chua co MSSV ma muon xoa?");
                }
                studentService.removeStudent(student.StudentID);
                MessageBox.Show("Ban co muon xoa TTSV nay", "Thong Bao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Read_data_DB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void dgv_qlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >=0 && rowIndex < dgv_qlsv.Rows.Count)
            {
                DataGridViewRow datarow = dgv_qlsv.Rows[rowIndex];
                if(datarow.IsNewRow == false)
                {
                    txt_mssv.Text = datarow.Cells["StudentID"].Value.ToString();
                    txt_ht.Text = datarow.Cells["FullName"].Value.ToString();
                    cbo_cn.SelectedValue = datarow.Cells["FacultyID"].Value.ToString();
                    txt_dtb.Text = datarow.Cells["DiemTB"].Value.ToString();
                }
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_khoa frm = new frm_khoa();
            this.Hide();
            frm.Show();
            
        }

    }
}
