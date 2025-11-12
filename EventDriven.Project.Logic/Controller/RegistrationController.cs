using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    public class RegistrationController
    {
        private readonly StudentRegistrationRepository registrationRepository;
        private readonly UserController userController;

        public RegistrationController()
        {
            userController = new UserController();
            registrationRepository = new StudentRegistrationRepository();
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

        // ADD registration
        public async Task<RegistrationModel> AddAsync(RegistrationModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: registration");

            try
            {
                return await registrationRepository.AddAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding registration: {ex.Message}");
            }
        }

        // UPDATE registration
        public async Task<RegistrationModel> UpdateAsync(RegistrationModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: registration");

            try
            {
                return await registrationRepository.UpdateAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating registration: {ex.Message}");
            }
        }

        public async Task<RegistrationModel> UpsertAsync(RegistrationModel model, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (model == null) throw new Exception("Missing parameter: registration");

            try
            {
                return await registrationRepository.UpsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating registration: {ex.Message}");
            }
        }

        // DELETE registration
        public async Task<bool> DeleteAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (id <= 0) throw new Exception("Missing parameter: registration ID");

            try
            {
                return await registrationRepository.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting registration: {ex.Message}");
            }
        }

        // GET all registrations
        public async Task<List<RegistrationModel>> GetAllAsync(UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            try
            {
                return await registrationRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving registrations: {ex.Message}");
            }
        }

        // GET registration by Id
        public async Task<RegistrationModel> GetByIdAsync(int id, UserModel authenticationKey)
        {
            if (authenticate(authenticationKey) == false) throw new Exception("You are not Logged in");
            if (id <= 0) throw new Exception("Missing parameter: registration ID");

            try
            {
                return await registrationRepository.GetByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving registration: {ex.Message}");
            }
        }
    }
}