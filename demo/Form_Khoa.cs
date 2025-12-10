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
    public partial class frm_khoa : Form
    {
        private FacultyService facultyService;
        private StudentService studentService;
        public frm_khoa()
        {
            InitializeComponent();
            facultyService = new FacultyService();
            studentService = new StudentService();
        }

        private void Create_Header_dgv()
        {
            dgv_khoa.Columns.Add("FacultyID", "Ma Khoa");
            dgv_khoa.Columns.Add("FacultyName", "Ten Khoa");
            dgv_khoa.Columns.Add("Count_Professor", "So Luong Giao Su");
        }

        private void Read_data_DB()
        {
            dgv_khoa.Rows.Clear();
            List<Faculty> facultyList = facultyService.GetAllFaculties();
            foreach(Faculty fc in facultyList)
            {
                int index = dgv_khoa.Rows.Add();
                dgv_khoa.Rows[index].Cells["FacultyID"].Value = fc.FacultyID;
                dgv_khoa.Rows[index].Cells["FacultyName"].Value = fc.FacultyName;
                dgv_khoa.Rows[index].Cells["Count_Professor"].Value = fc.Count_Professor;
            }
            dgv_khoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private Faculty Read_data_Faculty()
        {
            Faculty fc = new Faculty();
            string mk = txt_mk.Text.Trim();
            if(int.TryParse(mk, out int makhoa) == false)
            {
                throw new Exception("Ma Khoa khong hop le!");
            }
            fc.FacultyID = makhoa;

            string tk = txt_tk.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                throw new Exception("Ten Khoa khong duoc de trong!");
            }
            fc.FacultyName = tk;

            string sl = txt_sl.Text.Trim();
            if(int.TryParse(sl, out int soluong) == false)
            {
                throw new Exception("So Luong Giao Su khong hop le!");
            }
            fc.Count_Professor = soluong;

            return fc;
        }
        private void btn_add_update_Click(object sender, EventArgs e)
        {
            Faculty faculty = Read_data_Faculty();
            Faculty existingFaculty
                = facultyService.GetFaculty(faculty.FacultyID);
            if(existingFaculty == null)
            {
                facultyService.addFaculty(faculty);
                MessageBox.Show("Ban co chac muon them", "Thong Bao",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            }
            else
            {
                existingFaculty.FacultyName = faculty.FacultyName;
                existingFaculty.Count_Professor = faculty.Count_Professor;
                facultyService.updateFaculty(existingFaculty);
                MessageBox.Show("Ban co chac muon cap nhat", "Thong Bao",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            Read_data_DB();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Faculty faculty = Read_data_Faculty();
            Faculty existingFaculty
                = facultyService.GetFaculty(faculty.FacultyID);
            if(existingFaculty != null)
            {
                facultyService.RemoveFaculty(existingFaculty.FacultyID);
                MessageBox.Show("Ban co chac muon xoa", "Thong Bao",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                Read_data_DB();
            }
            else
            {
                throw new Exception("Khoa khong ton tai de xoa!");
            }
        }

        private void dgv_khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0 && rowIndex < dgv_khoa.Rows.Count)
            {
                DataGridViewRow datarow = dgv_khoa.Rows[rowIndex];
                if(datarow.IsNewRow == false)
                {
                    txt_mk.Text = datarow.Cells["FacultyID"].Value.ToString();
                    txt_tk.Text = datarow.Cells["FacultyName"].Value.ToString();
                    txt_sl.Text = datarow.Cells["Count_Professor"].Value.ToString();
                }
            }
        }

        private void frm_khoa_Load(object sender, EventArgs e)
        {
            Create_Header_dgv();
            Read_data_DB();

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
