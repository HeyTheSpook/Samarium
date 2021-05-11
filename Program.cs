using System;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace Spook_Game_Basher
{
    class Program
    {
        static int choice = 0;
        static void Main(string[] args)
        {

            Console.Title = "Samarium";
            Console.ForegroundColor = ConsoleColor.Green;
            string message = "Hello! Samarium is a 100% free to use program. If you have been charged money for this program please attempt a refund immediately as you have been scammed.\n\n" +
                "This is a compilation of varius cheats for many differant popular video games and is being updated regularly. If you have not yet, please join the discord at https://discord.gg/zaGGspgqW3. \n";
            string title = "PLEASE READ!";
            MessageBox.Show(message, title);

            while (true)
            {
                dispTitle();
                dispGames();

                Console.Write("[?] Please choose module: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch {
                    choice = 0;
                }
                if (choice == 1)
                {
                    internalCheat("https://cdn.discordapp.com/attachments/833042354771722310/833042412976734249/gmod_4-17-21.exe", "notes example");
                }
                else if (choice == 2)
                {
                    internalCheat("https://download1338.mediafire.com/b4yxm99picdg/lzvqdphmy5icuz2/modest-menu.exe", "<F5> to show/hide the menu," + Environment.NewLine +
                    "< Numpad 0 > to go back, " + Environment.NewLine +
                    "< Numpad 8 > and < Numpad 2 > to navigate up / down through the menu options." + Environment.NewLine +
                    "< Numpad 4 > and < Numpad 6 > to decrease / increase the current value." + Environment.NewLine +
                    "< Numpad 5 > to activate an option, toggle its value or applying any changed setting.");
                }
                else if (choice == 3)
                {
                    internalCheat("https://cdn.discordapp.com/attachments/833042354771722310/833540666936131604/Osiris.exe", "INSERT to open");
                }
                else if (choice == 4) {
                    internalCheat("https://cdn.discordapp.com/attachments/833042354771722310/834143571783188555/AmongUs.exe", "Show Menu - DELETE" + Environment.NewLine +
                    "Show Radar - INSERT" + Environment.NewLine +
                    "Show Console - HOME" + Environment.NewLine +
                    "Repair Sabotage - END");
                }
            }

        }
        static void dispTitle() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(  "███████╗ █████╗ ███╗   ███╗ █████╗ ██████╗ ██╗██╗   ██╗███╗   ███╗"+ Environment.NewLine +
                                "██╔════╝██╔══██╗████╗ ████║██╔══██╗██╔══██╗██║██║   ██║████╗ ████║" + Environment.NewLine +
                                "███████╗███████║██╔████╔██║███████║██████╔╝██║██║   ██║██╔████╔██║" + Environment.NewLine +
                                "╚════██║██╔══██║██║╚██╔╝██║██╔══██║██╔══██╗██║██║   ██║██║╚██╔╝██║" + Environment.NewLine +
                                "███████║██║  ██║██║ ╚═╝ ██║██║  ██║██║  ██║██║╚██████╔╝██║ ╚═╝ ██║" + Environment.NewLine +
                                "╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝ ╚═════╝ ╚═╝     ╚═╝");
            Console.WriteLine("Made by Spook#6250");
        }

        static void dispGames() {
            Console.WriteLine("[-] Game \t\t Hack \t\t\t\t Date Added \t\t Note");
            Console.WriteLine("[1] Garry's Mod \t (AOSHax) \t\t\t ADDED: 4/17/21 \t Use in main menu");
            Console.WriteLine("[2] GTA V \t\t (Kiddion's Modest Menu) \t ADDED: 4/17/21 \t Use when in loaded game");
            Console.WriteLine("[3] CS:GO \t\t (Osiris) \t\t\t ADDED: 4/18/21 \t Use in main menu");
            Console.WriteLine("[4] Among Us \t\t (AmongUsMenu) \t\t\t ADDED: 4/20/21 \t Use in main menu");
            Console.WriteLine();
        }

        static void internalCheat(string url, string notes) {
            using (var client = new WebClient())
            {
                Console.WriteLine();
                Console.WriteLine("Retrieving Executables...");
                client.DownloadFile(url, "C:\\temp\\Tsm.exe");
                Console.WriteLine("Executables Retrieved!");
                Console.WriteLine("Starting Injection Process...");
                bool unclean = true;
                while (unclean)
                {
                    try
                    {
                        Process.Start("C:\\temp\\Tsm.exe");
                        unclean = false;
                    }
                    catch { }
                }
                Console.WriteLine("Game Injected!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(notes);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
            }
        }
        static void getDependency(string url,string fileName) {
            using (var client = new WebClient())
            {
                Console.WriteLine();
                Console.WriteLine("Retrieving Dependency...");
                client.DownloadFile(url, "C:\\temp\\" +fileName+".exe");
                Console.WriteLine("Dependency Retrieved!");
                Console.ReadLine();
            }
        }
    }
}
