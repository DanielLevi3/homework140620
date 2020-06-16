using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_140620
{
    class Program
    {
        static void Main(string[] args)
        {

            Computer myNewMac = new Computer()
            {
                model = "apple",
                price = 3000,
                numberOfProcessors = 8,
                screenSize = 17.2f,
            };

            Console.WriteLine($"model of my Computer : {myNewMac.model}");

            myNewMac.TurnOn();
            myNewMac.TellMeThePrice();
            myNewMac.AddProcessor();
            myNewMac.TurnOFF();
            Console.WriteLine(myNewMac);


            Computer myNewHp = new Computer()
            {
                model = "Hp",
                price = 2000,
                numberOfProcessors = 4,
                screenSize = 19.4f,
            };

            Console.WriteLine($"the model of my computer : {myNewHp.model} ");

            myNewHp.TurnOn();
            myNewHp.TellMeThePrice();
            myNewHp.AddProcessor();
            myNewHp.TurnOFF();
            Console.WriteLine(myNewHp);

            Computer myNewLenovo = new Computer()
            {
                model = "Lenovo",
                price = 1500,
                numberOfProcessors = 6,
                screenSize = 15.4f,
            };

            Console.WriteLine($"model of my Computer : {myNewLenovo.model}");

            myNewLenovo.TurnOn();
            myNewLenovo.TellMeThePrice();
            myNewLenovo.AddProcessor();
            myNewLenovo.TurnOFF();
            Console.WriteLine(myNewLenovo);


        }
    }
}
