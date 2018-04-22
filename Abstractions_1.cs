using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions_1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML File is open\n");
        }
        public override void Create()
        {
            Console.WriteLine("XML File created\n");
        }
        public override void Change()
        {
            Console.WriteLine("XML File changed\n");
        }
        public override void Save()
        {
            Console.WriteLine("XML File saved\n");
        }

        public void XMLFileMenu()
        {
            int chooser = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(chooser == 0 ? "==>Open file\n" : "   Open file\n");
                Console.WriteLine(chooser == 1 ? "==>Create file\n" : "   Create file\n");
                Console.WriteLine(chooser == 2 ? "==>Change file\n" : "   Change file\n");
                Console.WriteLine(chooser == 3 ? "==>Save file\n" : "   Save file\n");
                Console.WriteLine(chooser == 4 ? "==>Exit\n" : "   Exit\n");
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();

                    switch (chooser)
                    {
                        case 0: Open();
                            break;
                        case 1: Create();
                            break;
                        case 2: Change();
                            break;
                        case 3: Save();
                            break;
                        case 4: return;
                    }

                    Console.ReadKey();
                }
                else
                {
                    switch (key)
                    {
                        case ConsoleKey.DownArrow: ++chooser;
                            break;
                        case ConsoleKey.UpArrow: --chooser;
                            break;
                    }
                }
                if (chooser >= 5) chooser = 0;
                if (chooser < 0) chooser = 2;
            }
        }
    }

    class TXTHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT File is open\n");
        }
        public override void Create()
        {
            Console.WriteLine("TXT File created\n");
        }
        public override void Change()
        {
            Console.WriteLine("TXT File changed\n");
        }
        public override void Save()
        {
            Console.WriteLine("TXT File saved\n");
        }

        public void TXTFileMenu()
        {
            int chooser = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(chooser == 0 ? "==>Open file\n" : "   Open file\n");
                Console.WriteLine(chooser == 1 ? "==>Create file\n" : "   Create file\n");
                Console.WriteLine(chooser == 2 ? "==>Change file\n" : "   Change file\n");
                Console.WriteLine(chooser == 3 ? "==>Save file\n" : "   Save file\n");
                Console.WriteLine(chooser == 4 ? "==>Exit\n" : "   Exit\n");
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();

                    switch (chooser)
                    {
                        case 0: Open();
                            break;
                        case 1: Create();
                            break;
                        case 2: Change();
                            break;
                        case 3: Save();
                            break;
                        case 4: return;
                    }

                    Console.ReadKey();
                }
                else
                {
                    switch (key)
                    {
                        case ConsoleKey.DownArrow: ++chooser;
                            break;
                        case ConsoleKey.UpArrow: --chooser;
                            break;
                    }
                }
                if (chooser >= 5) chooser = 0;
                if (chooser < 0) chooser = 2;
            }
        }
    }

    class DOCHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC File is open\n");
        }
        public override void Create()
        {
            Console.WriteLine("DOC File created\n");
        }
        public override void Change()
        {
            Console.WriteLine("DOC File changed\n");
        }
        public override void Save()
        {
            Console.WriteLine("DOC File saved\n");
        }

        public void DOCFileMenu()
        {
            int chooser = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(chooser == 0 ? "==>Open file\n" : "   Open file\n");
                Console.WriteLine(chooser == 1 ? "==>Create file\n" : "   Create file\n");
                Console.WriteLine(chooser == 2 ? "==>Change file\n" : "   Change file\n");
                Console.WriteLine(chooser == 3 ? "==>Save file\n" : "   Save file\n");
                Console.WriteLine(chooser == 4 ? "==>Exit\n" : "   Exit\n");
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Enter))
                {
                    Console.Clear();

                    switch (chooser)
                    {
                        case 0: Open();
                            break;
                        case 1: Create();
                            break;
                        case 2: Change();
                            break;
                        case 3: Save();
                            break;
                        case 4: return;
                    }
                    Console.ReadKey();
                }
                else
                {
                    switch (key)
                    {
                        case ConsoleKey.DownArrow: ++chooser;
                            break;
                        case ConsoleKey.UpArrow: --chooser;
                            break;
                    }
                }
                if (chooser >= 5) chooser = 0;
                if (chooser < 0) chooser = 2;
            }
        }
    }

    class Abstractions_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите формат файла (TXT, DOC или XML):");
            string formatName = Console.ReadLine();

            switch (formatName)
            {
                case "TXT": TXTHandler TXTH = new TXTHandler();
                    TXTH.TXTFileMenu();
                    break;
                case "DOC": DOCHandler DOCH = new DOCHandler();
                    DOCH.DOCFileMenu();
                    break;
                case "XML": XMLHandler XMLH = new XMLHandler();
                    XMLH.XMLFileMenu();
                    break;
            }
        }
    }
}
