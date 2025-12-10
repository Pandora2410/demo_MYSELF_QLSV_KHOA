using demo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DLL.Service
{
    public class FacultyService
    {
        private QLSV_MYSEFL_Entities db_Connect;

        public FacultyService()
        {
            db_Connect = new QLSV_MYSEFL_Entities();
        }

        //Lay tat ca cac khoa
        public List<Faculty> GetAllFaculties()
        {
            return db_Connect.Faculties.ToList();
        }

        //Them mot khoa
        public Faculty GetFaculty(int id)
        {
            return db_Connect.Faculties.Find(id);
        }

        //Them thong tin khoa
        public void addFaculty(Faculty faculty)
        {
            Faculty existingFaculty
                = db_Connect.Faculties.Find(faculty.FacultyID);
            if(existingFaculty == null)
            {
                db_Connect.Faculties.Add(faculty);
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Khong tim thay khoa de cap nhat");
            }
        }

        //Cap nhat thong tin khoa
        public void updateFaculty(Faculty faculty)
        {
            Faculty existingFaculty
                = db_Connect.Faculties.Find(faculty.FacultyID);
            if(existingFaculty != null)
            {
                existingFaculty.FacultyID = faculty.FacultyID;
                existingFaculty.FacultyName = faculty.FacultyName;
                existingFaculty.Count_Professor = faculty.Count_Professor;
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Khong tim thay khoa de cap nhat");
            }
        }

        //Xoa mot khoa
        public void RemoveFaculty(int id)
        {
            Faculty existingFaculty
                = db_Connect.Faculties.Find(id);
            if(existingFaculty != null)
            {
                db_Connect.Faculties.Remove(existingFaculty);
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Khong tim thay khoa de xoa");
            }
        }
    }
}
