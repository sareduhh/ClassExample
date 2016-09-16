using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Practice
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the beginning of our class example.");

            //our first person instance

            //Person thisPerson = new Person();
            //thisPerson.Greet("Sarah");

            //Console.WriteLine();

            //Our second person instance

            //Person secondPerson = new Person(25, "Lupe", "Purple", "Whattup?");
            //secondPerson.greeting = "How's it going?";
            //secondPerson.Greet("Clone Sarah");

            Student freshman = new Student("Jane Doe", 19, "University School", "Underwater Basket Weaving", 3.5);
            freshman.Name = "Janie Doe";

            for (int i=0; i<10; i++)
            {
                freshman.PrintAllDetails();
                freshman.Birthday();
                System.Threading.Thread.Sleep(500);
            }


        }
        
    }
}
