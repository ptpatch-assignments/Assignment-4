using ShirtAssignmentV2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2.Payment
{
    class PayWithCredit : IPayment
    {
        public void PaymentMethod(Color c, Size s, Fabric f)
        {
            Console.WriteLine($" Your payment method for T-shirt with Color {c}, Size {s}, Fabric {f} is Credit / Debit Cards.");
        }
    }
}
