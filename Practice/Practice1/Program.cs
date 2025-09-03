using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Norah Wolff
 * Practice 1
 * Date: Thursday 8/28/25 
 * Purpose:Functonality 1 => defined variables and process them to calculate areas of circles 

 */

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== This is Functionality 1 ===========");
            //Console.WriteLine("Hello,WOrld!");
            //Console.WriteLine("The area of a circle with a radius 1 is 3.14");
            // a variable to hold the radius 
            double theRadius = 15.5;

            // another variable to hold the area 
            double theArea = theRadius * theRadius * 3.14;
            // print out the info in diffferent ways.. 
            Console.WriteLine("The cricle with a radius of " + theRadius + " is  " + theArea);
            Console.WriteLine("The cricle with a radius of {0} is {1}", theRadius, theArea);
            Console.WriteLine($"The cricle with a radius of {theRadius} is {theArea}");

            Console.WriteLine("======================================");


        }
    }
}
