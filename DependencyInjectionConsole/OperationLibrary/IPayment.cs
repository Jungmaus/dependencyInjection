using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConsole.OperationLibrary
{
    public interface IPayment
    {
        void DoPayment();
        void CancelPayment();
    }
}
