using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //内置委托 可以把方法当作参数传递给另一个方法
            Func<int, int, int> func = Add;
            int result = func(1, 2);
            Console.WriteLine(result);
            //内置委托 可以把方法当作参数传递给另一个方法
            int r = Calcuate(8, func(1, 2));
            Console.WriteLine(r);




            //lambda表达式 日常的linq  实现一些简单的操作  是一个匿名函数  没有方法名
            Func<int, int, int> func2 = (a, b) => { return a + b; };
            int k =  func2(1, 2);
            Console.WriteLine(k);

            var dbContext = new BookStoreEntities();
            var books = dbContext.Book;
            foreach (var item in books)
            {
                Console.WriteLine(item.Report());
            }


            Console.ReadKey();
        }

        public static int Add(int a,int b)
        {
            return a + b;
        }



        public static  int Calcuate(int a ,int b)
        {
            return a - b;
        }
    }

}
