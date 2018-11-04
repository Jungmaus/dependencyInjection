using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole.OperationLibrary
{
    public class Payment: IPayment
    {
        private IPayment _payment;

        public Payment(IPayment payment)
        {
            _payment = payment;
        }

        public void CancelPayment()
        {
            _payment.CancelPayment();
        }

        public void DoPayment()
        {
            _payment.DoPayment();
        }
    }
}
