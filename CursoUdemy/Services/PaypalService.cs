using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double _monthlySimpleInterest = 0.01;
        private const double _feePercentage = 0.02;

        public double PaymentFee(double amount)
        {
            return amount * _feePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * _monthlySimpleInterest * months;
        }
    }
}
