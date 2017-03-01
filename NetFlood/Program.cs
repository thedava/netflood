using System;
using System.Collections.Generic;
using System.Text;

namespace NetFlood
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            foreach (string s in args) ip = s;

            if (ip != "")
            {
                Console.Title = "NetFlood // DDoS";
                Flood f = new Flood(ip);
            }
            else
            {
                Console.Title = "NetFlood // Control";
                Control c = new Control();
            }
        }
    }
}
