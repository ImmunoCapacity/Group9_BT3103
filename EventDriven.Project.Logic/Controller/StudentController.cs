using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class StudentController
    {
        private readonly StudentRepository studentRepository;

        public StudentController()
        {
            studentRepository = new StudentRepository();
        }

        // ADD student
        public StudentModel Add(StudentModel model)
        {
            if (model == null) throw new Exception("Missing parameter: student");

            try
            {
                return studentRepository.Insert(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding student: {ex.Message}");
            }
        }

        // UPDATE student
        public StudentModel Update(StudentModel model)
        {
            if (model == null) throw new Exception("Missing parameter: student");

            try
            {
                return studentRepository.Update(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating student: {ex.Message}");
            }
        }

        // DELETE student
        public StudentModel Delete(int id)
        {
            if (id <= 0) throw new Exception("Missing parameter: student ID");

            try
            {
                return studentRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting student: {ex.Message}");
            }
        }

        // GET all students
        public List<StudentModel> GetAll()
        {
            try
            {
                return studentRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving students: {ex.Message}");
            }
        }

        // GET student by Id
        public StudentModel GetById(int id)
        {
            if (id <= 0) throw new Exception("Missing parameter: student ID");

            try
            {
                return studentRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving student: {ex.Message}");
            }
        }
    }
}
