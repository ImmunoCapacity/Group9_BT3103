using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    public class AssessmentController2
    {
        private readonly UserController userController;
        private readonly AssessmentRepository assessmentRepository;

        public AssessmentController2()
        {
            userController = new UserController();
            assessmentRepository = new AssessmentRepository();
        }

        private bool Authenticate(UserModel authenticationKey)
        {
            UserModel matching = userController.ValidateUser(
                authenticationKey.Username,
                authenticationKey.Password,
                authenticationKey.Role
            );

            return matching != null;
        }
        public async void UpdateStudentStatusAsync(int studentId, string requirement, string enrollment, UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not Logged in");

            if (studentId <= 0)
                throw new Exception("Missing parameter: student ID");

            try
            {
                await assessmentRepository.UpdateStudentStatusAsync(studentId, requirement, enrollment);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving assessment: {ex.Message}");
            }
        }



        // GET assessment for student
        public async Task<List<StudentAssessment>> GetAssessmentAsync(int studentId, UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not Logged in");

            if (studentId <= 0)
                throw new Exception("Missing parameter: student ID");

            try
            {
                return await assessmentRepository.GetAssessmentAsync(studentId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving assessment: {ex.Message}");
            }
        }
        public async Task<List<StudentAssessment>> GetAllAssessmentsAsync(UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not Logged in");

            try
            {
                return await assessmentRepository.GetAllAssessmentsAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving all assessments: {ex.Message}");
            }
        }

        public async Task<List<StudentAssessment>> GetAllEnrolledAsync(UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
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