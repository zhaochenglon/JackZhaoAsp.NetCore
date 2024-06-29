using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student<int> student = new Student<int>();
            student.ID = 100;
            student.Name = "jack";
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);


            //这里使用到了多态和泛型的方法 进行了解耦操作
            IDictionary<int,string> dict = new Dictionary<int,string>();
            dict[1] = "Jack";
            dict[2] = "chenglong";
            Console.WriteLine(dict[2]);


            Console.WriteLine("==============================================");

            //内置委托和lambda表达式结合使用

            Calculate<int>((a, b) => { return a + b; }, 200, 300);

            Console.ReadKey();
        }


        public static void Calculate<T>(Func<T ,T ,T> func ,T x,T y)
        {
            T result = func(x, y);
            Console.WriteLine(result);
        }

    }


    /// <summary>
    /// 声明一个泛型接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IUnique<T>
    {
        T ID { get; set; }
    }


    //泛型类在继承泛型接口的时候 也必须要是泛型的
    class Student<T> : IUnique<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }
    }
}
