using System;
using System.Text.RegularExpressions;
using Bowling;

namespace DebuggingTechnics
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = new Game();
            
            g.Roll(2);
            Console.WriteLine($"Your score is {g.Score()}");

            
            //var xml = "<note class=\"test\"><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";
        }
    }
}
