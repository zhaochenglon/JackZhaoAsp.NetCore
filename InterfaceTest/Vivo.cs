using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Vivo:IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Vivo 正在打电话");
        }

        public void PickUp()
        {
            Console.WriteLine("Vivo 接电话");
        }

        public void Receive()
        {
            Console.WriteLine("Vivo 正在收短信");
        }

        public void Send()
        {
            Console.WriteLine("Vivo 正在发短信");
        }
    }
}
