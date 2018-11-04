using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole.OperationLibrary
{
    public class EnParaPayment : IPayment
    {
        public void CancelPayment()
        {
            Console.Write("EnPara Payment Canelled");
        }

        public void DoPayment()
        {
            Console.Write("EnPara Payment Done");
        }
    }
}
