using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    internal class AssessmentController
    {
        private readonly StudentAssessmentRepository studentassessmentRepository;
        private readonly UserController userController;

        public AssessmentController()
        {
            userController = new UserController();
            studentassessmentRepository = new StudentAssessmentRepository();
        }

        private bool authenticate(UserModel authenticationKey)
        {
            UserModel matching = userController.ValidateUser(authenticationKey.Username, authenticationKey.Password, authenticationKey.Role);
            if (matching != null)
            {
                return true;
            }
            return false;
        }

        // ADD assessment
        public async Task<AssessmentModel> AddAsync(AssessmentModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: assessment");

            try
            {
                return await studentassessmentRepository.AddAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding assessment: {ex.Message}");
            }
        }

        // UPDATE assessment
        public async Task<AssessmentModel> UpdateAsync(AssessmentModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: assessment");

            try
            {
                return await studentassessmentRepository.UpdateAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating assessment: {ex.Message}");
            }
        }

        public async Task<AssessmentModel> UpsertAsync(AssessmentModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: assessment");

            try
            {
                return await studentassessmentRepository.UpsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating assessment: {ex.Message}");
            }
        }

        // DELETE assessment
        public async Task<bool> DeleteAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (id <= 0) throw new Exception("Missing parameter: assessment ID");

            try
            {
                return await studentassessmentRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting assessment: {ex.Message}");
            }
        }

        // GET all assessments
        public async Task<List<AssessmentModel>> GetAllAsync(UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            try
            {
                return await studentassessmentRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving assessments: {ex.Message}");
            }
        }

        // GET assessment by Id
        public async Task<AssessmentModel> GetByIdAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (id <= 0) throw new Exception("Missing parameter: assessment ID");

            try
            {
                return await studentassessmentRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving assessment: {ex.Message}");
            }
        }

        // GET all enrolled students
        public async Task<List<StudentAssessment>> GetAllEnrolledAsync(UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false)
                throw new Exception("You are not Logged in");

            try
            {
                // Call the repository method
                var repo = new AssessmentRepository();
                return await repo.GetAllEnrolledAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving enrolled students: {ex.Message}");
            }
        }

    }
}
