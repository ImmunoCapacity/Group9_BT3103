using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class StudentInformationController
    {
        private readonly StudentRepository studentRepository;

        public StudentInformationController()
        {
            studentRepository = new StudentRepository();
        }

        // ADD student
        public async Task<StudentModel> AddAsync(StudentModel model)
        {
            if (model == null) throw new Exception("Missing parameter: student");

            try
            {
                return await studentRepository.InsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding student: {ex.Message}");
            }
        }

        // UPDATE student
        public async Task<StudentModel> UpdateAsync(StudentModel model)
        {
            if (model == null) throw new Exception("Missing parameter: student");

            try
            {
                return await studentRepository.UpdateAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating student: {ex.Message}");
            }
        }

        // DELETE student
        public async Task<StudentModel> DeleteAsync(int id)
        {
            if (id <= 0) throw new Exception("Missing parameter: student ID");

            try
            {
                return await studentRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting student: {ex.Message}");
            }
        }

        // GET all students
        public async Task<List<StudentModel>> GetAllAsync()
        {
            try
            {
                return await studentRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving students: {ex.Message}");
            }
        }

        // GET student by Id
        public async Task<StudentModel> GetByIdAsync(int id)
        {
            if (id <= 0) throw new Exception("Missing parameter: student ID");

            try
            {
                return await studentRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving student: {ex.Message}");
            }
        }
    }
}
