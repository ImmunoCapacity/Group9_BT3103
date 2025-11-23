using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Logic.Controller;
using EventDriven.Project.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class StudentController
    {
        private readonly StudentRepository studentRepository;
        private readonly UserController userController;

        public StudentController()
        {
            userController = new UserController();
            studentRepository = new StudentRepository();
        }
        private bool authenticate(UserModel authenticationKey)
        {
            UserModel matching = userController.ValidateUser(authenticationKey.Username, authenticationKey.Password, authenticationKey.Role);
            if (matching != null){
                return true;
            }
            return false;
        }

        // ADD student
        public async Task<StudentModel> AddAsync(StudentModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
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
        public async Task<StudentModel> UpdateAsync(StudentModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
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
        public async Task<StudentModel> DeleteAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
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
        public async Task<List<StudentModel>> GetAllAsync(UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            try
            {
                return await studentRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving students: {ex.Message}");
            }
        }

        // GET: student count by section and academic year (using YearName)
        public async Task<int> GetStudentCountBySectionAndYearAsync(string sectionName, string yearName, UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey))
                throw new Exception("You are not Logged in");

            if (string.IsNullOrWhiteSpace(sectionName))
                throw new Exception("Missing parameter: sectionName");

            if (string.IsNullOrWhiteSpace(yearName))
                throw new Exception("Missing parameter: yearName");

            try
            {
                return await studentRepository.GetStudentCountBySectionAndYearAsync(sectionName, yearName);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving student count: {ex.Message}");
            }
        }


        // GET student by Id
        public async Task<StudentModel> GetByIdAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
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
