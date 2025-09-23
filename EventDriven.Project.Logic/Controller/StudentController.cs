using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class StudentController
    {
        private StudentRepository studentRepo;

        public StudentController()
        {
            studentRepo = new StudentRepository();
        }

        public int Add(StudentModel model)
        {
            if (model == null) throw new Exception("Missing parameter: student");

            try
            {
                return studentRepo.Insert(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding student: {ex.Message}");
            }
        }

        public List<StudentModel> GetAll()
        {
            try
            {
                return studentRepo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving students: {ex.Message}");
            }
        }

        public StudentModel GetById(int id)
        {
            if (id <= 0) throw new Exception("Invalid student Id");

            try
            {
                return studentRepo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving student by Id: {ex.Message}");
            }
        }

        public int GetCount()
        {
            try
            {
                return studentRepo.GetCount();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting students: {ex.Message}");
            }
        }
    }
}
