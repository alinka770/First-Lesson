using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_task4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт\n");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про\n");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про\n");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован\n");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт\n");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате\n");
        }
    }

    class Inheritance_task4
    {
        public static int MyMenu()
        {
            int chooser = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(chooser == 0 ? "==>Открыть документ\n" : "   Открыть документ\n");
                Console.WriteLine(chooser == 1 ? "==>Редактировать документ\n" : "   Редактировать документ\n");
                Console.WriteLine(chooser == 2 ? "==>Сохранить документ\n" : "   Сохранить документ\n");
                ConsoleKey key = Console.ReadKey().Key;
                if (key.Equals(ConsoleKey.Enter)) return chooser;
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
                if (chooser >= 3) chooser = 0;
                if (chooser < 0) chooser = 2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ для доступа в версии редактора \"Про\" и \"Эксперт\"\n");

            string key = Console.ReadLine();

            Console.Clear();
            if (key.Equals("pro"))
            {
                Console.WriteLine("Добро пожаловать в версию Про!\n");
                Console.ReadKey();

                DocumentWorker DW = new ProDocumentWorker();
                int choice = MyMenu();
                switch (choice)
                {
                    case 0: DW.OpenDocument();
                        break;
                    case 1: DW.EditDocument();
                        break;
                    case 2: DW.SaveDocument();
                        break;
                }
                Console.ReadKey();
            }
            else if (key.Equals("exp"))
            {
                Console.WriteLine("Добро пожаловать в версию Эксперт!\n");
                Console.ReadKey();

                DocumentWorker DW = new ExpertDocumentWorker();
                int choice = MyMenu();
                switch (choice)
                {
                    case 0: DW.OpenDocument();
                        break;
                    case 1: DW.EditDocument();
                        break;
                    case 2: DW.SaveDocument();
                        break;
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вам доступна только бесплатная версия.\n");
                Console.ReadKey();

                DocumentWorker DW = new DocumentWorker();
                int choice = MyMenu();
                switch (choice)
                {
                    case 0: DW.OpenDocument();
                        break;
                    case 1: DW.EditDocument();
                        break;
                    case 2: DW.SaveDocument();
                        break;
                }
                Console.ReadKey();
            }
        }
        
    }
}
