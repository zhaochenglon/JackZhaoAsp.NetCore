


using System.Runtime.Loader;

namespace BabyStroller
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animaleType = new List<Type>();
            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    if (t.GetMethod("Voice")!=null)
                    {
                        animaleType.Add(t);
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < animaleType.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{animaleType[i].Name}");
                }
                Console.WriteLine("=========================");
                Console.WriteLine("Please choose animal:");
                int index = int.Parse(Console.ReadLine());
                if (index>animaleType.Count || index < 1)
                {
                    Console.WriteLine("No such an animal.Try again!");
                    continue;
                }
                Console.WriteLine("Please enter times");
                int times = int.Parse(Console.ReadLine());
                var t = animaleType[index - 1];
                var m = t.GetMethod("Voice");
                var o = Activator.CreateInstance(t);
            }
        }
    }
}

