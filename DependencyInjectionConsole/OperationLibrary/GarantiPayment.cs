using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole.OperationLibrary
{
    public class GarantiPayment : IPayment
    {
        public void CancelPayment()
        {
            Console.Write("Garanti Payment Canelled");
        }

        public void DoPayment()
        {
            Console.Write("Garanti Payment Done");
        }
    }
}
