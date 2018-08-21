using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Message message = new Message(new int[] { 7, 15, 23 });
            do
            {
                Console.WriteLine(message.GetHelloMessage());
                Console.Write("Type 'exit' to quit...");
            } while (Console.ReadLine().ToLower() != "exit");


        }
    }
}
