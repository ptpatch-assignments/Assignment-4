using ShirtAssignmentV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2.Payment
{
    public interface IPayment
    {
        void PaymentMethod(Color c, Size s, Fabric f);
    }
}
