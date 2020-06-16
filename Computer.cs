using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_140620
{
    
   [DebuggerDisplay("{model} {(price*3.67)}")]
   public class Computer
    {

        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn = false;


        public void TellMeThePrice()
        {
            Console.WriteLine($"My price is {price}");
        }
        public void TellMeTheScreenSize()
        {
            Console.WriteLine($"My screen size is {screenSize}");
        }
        public void TurnOn()
        {
            Console.WriteLine("The computer is on");
            isTurnOn = true;
        }
        public void TurnOFF()
        { 
            Console.WriteLine("The computer is off ");
            isTurnOn = false;
        }
        public int AddProcessor()
        {
            return numberOfProcessors;
        }
        public override string ToString()
        {
            return $"[Computer] : model:{model} price:{price} numberOfProcessors:{numberOfProcessors} screenSize:{screenSize} isTurnOn:{isTurnOn}";
        }
    }
}
