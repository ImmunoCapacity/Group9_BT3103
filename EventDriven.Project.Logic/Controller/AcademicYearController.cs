using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    public class AcademicYearController
    {
        private readonly AcademicYearRepository academicYearRepository;
        private readonly UserController userController;

        public AcademicYearController()
        {
            userController = new UserController();
            academicYearRepository = new AcademicYearRepository();
        }

        public async Task<int> getYearId(string yearName, List<AcademicYearModel> academicYear, UserModel authenticationKey)
        {
            if (academicYear == null)
                academicYear = await GetAllAsync(authenticationKey);
            if(yearName != null) 
                foreach(var year in academicYear)
                {
                    if (yearName.Equals(year.YearName))
                    {
                        return year.Id;
                    }
                }
            return -1;
        }

        private bool authenticate(UserModel authenticationKey)
        {
            UserModel matching = userController.ValidateUser(
                authenticationKey.Username,
                authenticationKey.Password,
                authenticationKey.Role
            );

            return matching != null;
        }

        // ADD Academic Year
        public async Task<AcademicYearModel> AddAsync(AcademicYearModel model, UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey)) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: academic year");

            try
            {
                return await academicYearRepository.AddAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding academic year: {ex.Message}");
            }
        }

        // UPDATE Academic Year
        public async Task<AcademicYearModel> UpdateAsync(AcademicYearModel model, UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey)) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: academic year");

            try
            {
                return await academicYearRepository.UpdateAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating academic year: {ex.Message}");
            }
        }

        

        // GET all Academic Years
        public async Task<List<AcademicYearModel>> GetAllAsync(UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey)) throw new Exception("You are not Logged in");

            try
            {
                return await academicYearRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving academic years: {ex.Message}");
            }
        }

        // GET Academic Year by Id
        public async Task<AcademicYearModel> GetByIdAsync(int id, UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey)) throw new Exception("You are not Logged in");
            if (id <= 0) throw new Exception("Missing parameter: academic year ID");

            try
            {
                return await academicYearRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving academic year: {ex.Message}");
            }
        }
    }
}
