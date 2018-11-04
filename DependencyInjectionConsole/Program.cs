using DependencyInjectionConsole.OperationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Which payment type you will use ? => ");
                int paymentType = int.Parse(Console.ReadLine());

                Console.Write("Which operation type you will do ? => ");
                int operationType = int.Parse(Console.ReadLine());

                Payment payment;

                if (paymentType == 1)
                {
                    payment = new Payment(new GarantiPayment());
                    if (operationType == 1)
                        payment.DoPayment();
                    else if (operationType == 2)
                        payment.CancelPayment();
                }
                else if (paymentType == 2)
                {
                    payment = new Payment(new EnParaPayment());
                    if (operationType == 1)
                        payment.DoPayment();
                    else if (operationType == 2)
                        payment.CancelPayment();
                }

                Console.WriteLine();
                Console.WriteLine();
            } while (true);

        }
    }
}
