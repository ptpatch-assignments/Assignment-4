using ShirtAssignmentV2.Enums;
using ShirtAssignmentV2.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2
{
    public class Shirt
    {
        public Color Color { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }

        public Shirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        private IPayment _shirt;

        public Shirt(IPayment strategy)
        {
            _shirt = strategy;
        }

        public void SetStrategy(IPayment strategy)
        {
            _shirt = strategy;
        }

        public void PaymentMethod(Color c, Size s, Fabric f)
        {
            _shirt.PaymentMethod(c, s, f);
        }

        public void Output()
        {
            Console.WriteLine("{0, 10} {1, 10} {2, 10}", Color, Size, Fabric);
        }
    }
}
