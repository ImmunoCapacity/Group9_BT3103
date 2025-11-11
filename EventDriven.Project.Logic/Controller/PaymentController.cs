using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{

        public class PaymentController
        {
            private readonly StudentPayment paymentRepository;
            private readonly UserController userController;

            public PaymentController()
            {
                userController = new UserController();
                paymentRepository = new StudentPayment();
            }

            private bool authenticate(UserModel authenticationKey)
            {
                UserModel matching = userController.ValidateUser(authenticationKey.Username, authenticationKey.Password, authenticationKey.Role);
                return matching != null;
            }

            // ADD payment
            public async Task<PaymentModel> AddAsync(PaymentModel model, UserModel authenticationKey)
            {
                if (!authenticate(authenticationKey)) throw new Exception("You are not logged in.");
                if (model == null) throw new Exception("Missing parameter: payment");

                try
                {
                    return await paymentRepository.InsertAsync(model);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error adding payment: {ex.Message}");
                }
            }

            

        public async Task<List<StudentPaymentInfo>> GetAllStudentPayment(UserModel authenticationKey)
        {
            if (!authenticate(authenticationKey)) throw new Exception("You are not logged in.");

            try
            {
                return await paymentRepository.GetAllStudentPayments();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payments: {ex.Message}");
            }
        }



        // GET all payments
        public async Task<List<PaymentModel>> GetAllAsync(UserModel authenticationKey)
            {
                if (!authenticate(authenticationKey)) throw new Exception("You are not logged in.");

                try
                {
                    return await paymentRepository.GetAllAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error retrieving payments: {ex.Message}");
                }
            }

            

           
        }
    }


