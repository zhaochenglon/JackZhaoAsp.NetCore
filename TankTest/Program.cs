using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace TankTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var maleDriver = new Driver(new LightTank());
            //maleDriver.Drive();


            //var pla = new Pla(new LightTank());
            //pla.Fire();
            //pla.Drive();



            //底层反射


            //ITank tank = new LightTank();

            ////===============================
            ////先得到动态信息
            //var t = tank.GetType();
            ////使用指定类型创建该对象的实例
            //object o = Activator.CreateInstance(t);

            ////动态的反射得到类型中的方法
            //MethodInfo fireMi =  t.GetMethod("Fire");
            //MethodInfo runMi = t.GetMethod("Run");

            ////在指定类中运行这个方法
            //fireMi.Invoke(o,null);
            //runMi.Invoke(o, null);



            //依赖注入
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank),typeof(LightTank));


            //Driver driver = new Driver(new LightTank());
            sc.AddScoped(typeof(IVehicele), typeof(LightTank));
            sc.AddScoped<Driver>();

            


            var sp = sc.BuildServiceProvider();

            //=================================
            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();


            var driver = sp.GetService<Driver>();
            driver.Drive();
            Console.ReadKey();
        }
    }

    //机械装置
    interface IVehicele
    {
        void Run();
    }

    //武器
    interface IWeapon
    {
        void Fire();
    }

    //坦克
    interface ITank : IVehicele, IWeapon
    {
    }



    class Car : IVehicele
    {
        public void Run()
        {
            Console.WriteLine("Car mis Running");
        }
    }

    class Truck : IVehicele
    {
        public void Run()
        {
            Console.WriteLine("Truck is Running");
        }
    }


    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom");
        }

        public void Run()
        {
            Console.WriteLine("Tank is running");
        }
    }


    class Driver{
        private IVehicele _vehicele;
        public Driver(IVehicele vehicele)
        {
            _vehicele = vehicele;
        }

        public void Drive()
        {
            _vehicele.Run();
        }
    }


    class Pla {
        private ITank _tank;
        public Pla(ITank tank)
        {
            _tank = tank;
        }

        public void Fire()
        {
            _tank.Fire();
        }


        public void Drive()
        {
            _tank.Run();
        }
    }

}
