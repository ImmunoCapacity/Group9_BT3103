using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventDriven.Project.Logic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.Logic.Controller
{
    public class PaymentController
    {
        private readonly StudentPaymentRepository paymentRepository;
        private readonly UserController userController;

        public PaymentController()
        {
            userController = new UserController();
            paymentRepository = new StudentPaymentRepository();
        }

        // 🔐 Authenticate user credentials
        private bool Authenticate(UserModel authenticationKey)
        {
            UserModel matching = userController.ValidateUser(
                authenticationKey.Username,
                authenticationKey.Password,
                authenticationKey.Role
            );

            return matching != null;
        }

        // ➕ Add payment
        public async Task<PaymentModel> AddAsync(PaymentModel model, UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not logged in.");

            if (model == null)
                throw new Exception("Missing parameter: payment");

            // 🚫 Prevent negative or zero payments
            if (model.AmountPaid <= 0)
                throw new Exception("Payment amount must be greater than zero.");

            try
            {
                return await paymentRepository.InsertAsync(model);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding payment: {ex.Message}");
            }
        }

        // 💰 Get total paid by student
        public async Task<decimal> GetTotalPaidByStudentIdAsync(int studentId, UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not logged in.");

            try
            {
                return await paymentRepository.GetTotalPaidByStudentIdAsync(studentId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payments: {ex.Message}");
            }
        }

        // 📜 Get all payment history (for reports)
        public async Task<List<PaymentHistoryModel>> GetAllPayments(UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not logged in.");

            try
            {
                return await paymentRepository.GetAllPayments();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payments: {ex.Message}");
            }
        }

        // 👩‍🎓 Get all student payment summary
        public async Task<List<StudentPaymentInfo>> GetAllStudentPayment(UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not logged in.");

            try
            {
                return await paymentRepository.GetAllStudentPayments();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving payments: {ex.Message}");
            }
        }

        // 📂 Get all raw payment records
        public async Task<List<PaymentModel>> GetAllAsync(UserModel authenticationKey)
        {
            if (!Authenticate(authenticationKey))
                throw new Exception("You are not logged in.");

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
