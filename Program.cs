using System; //
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework_6._3.GenerateL;
using homework_6._3.models;
using homework_6._3.students;


namespace homework_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            model model = new model();


            model.Print();

            Console.WriteLine(model.A());

            Console.WriteLine($"\nB:");
            foreach (var e in model.B())
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
            Console.Clear();

            model.Print();

            model.C();

            model.Print();

            Console.ReadLine();


            model.D();

            model.Print();

            Console.ReadLine();
        }
    }
}
