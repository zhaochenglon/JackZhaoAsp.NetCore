using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Oppo:IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Oppo 正在打电话");
        }

        public void PickUp()
        {
            Console.WriteLine("Oppo 接电话");
        }

        public void Receive()
        {
            Console.WriteLine("Oppo 正在收短信");
        }

        public void Send()
        {
            Console.WriteLine("Oppo 正在发电话");
        }
    }
}
