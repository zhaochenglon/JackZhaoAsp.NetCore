using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    public class PhoneUser
    {
        //我要使用电话 但是需要使用到积累的电话 每次调用的使用 需要使用构造器进行声明
        private  IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.Send();
            _phone.Receive();
            _phone.PickUp();
        }
    }
}
