using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //此处就是使用到了多态
            IPhone iphone = new Oppo();
            PhoneUser phone = new PhoneUser(iphone);
            phone.UsePhone();
            Console.ReadKey();
        }
    }

}
