using demo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.DLL.Service
{
    public class StudentService
    {
        private QLSV_MYSEFL_Entities db_Connect;

        public StudentService()
        {
            db_Connect = new QLSV_MYSEFL_Entities();
        }

        public List<Student> GetAllStudents()
        {
            return db_Connect.Students.Include("Faculty").ToList();
        }

        public Student GetStudent(int studentID)
        {
            return db_Connect.Students.Include("Faculty")
                .FirstOrDefault(sv => sv.StudentID == studentID);
        }

        public void addStudent(Student student)
        {
            Student existingStudent
                = db_Connect.Students.Find(student.StudentID);
            if(existingStudent == null)
            {
                db_Connect.Students.Add(student);
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Ma sinh vien nhap ma bi trung a?");
            }
        }

        public void updateStudent(Student student)
        {
            Student existingStudent
                = db_Connect.Students.Find(student.StudentID);
            if(existingStudent != null)
            {
                existingStudent.StudentID = student.StudentID;
                existingStudent.FullName = student.FullName;
                existingStudent.DTB = student.DTB;
                existingStudent.FacultyID = student.FacultyID;
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Khong tim thay ma so sinh vien");
            }
        }

        public void removeStudent(int studentID)
        {
            Student existingStudent
                = db_Connect.Students.Find(studentID);
            if(existingStudent != null)
            {
                db_Connect.Students.Remove(existingStudent);
                db_Connect.SaveChanges();
            }
            else
            {
                throw new Exception("Khong tim thay ma so sinh vien");
            }
        }



    }
}
