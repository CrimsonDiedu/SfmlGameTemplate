using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading_test
{
    class Interface
    {
        string state = "main_menu";
        bool running;
        Book customSheets;
        
        public void Run()
        {
            running = true;
            while (running)
            {
                
                switch (state)
                {
                    case "main_menu":
                        MainMenu();
                        break;
                    case "mega test":
                        MegTest();
                        break;
                    case "new sheet":
                        NewSheet();
                        break;
                }
            }
        }
        void MainMenu()
        {
            Console.Write("Welcome to Crimson Composer!" +
                            "\n____________________________" +
                            "\nPlease type what you would like to do next");
            Console.Write("Create Sheets\nnmet(test)");
            string response = Console.ReadLine();
            switch (response.ToLower())
            {
                case "create sheets":
                    state = "new sheet";
                    break;
                case "nmet":
                    state = "mega test";
                    break;
                case "play sheet":
                    break;
            }
        }
        void MegTest()
        {
            Console.WriteLine("Press Enter to Play Song!");
            Console.ReadKey();
            Sheet sheet = new Sheet();
            
            #region notes in sheet 1
            
            Random random = new Random();
            int n1,n2,dur;
            for (int i = 0; i < 10; i++)
            {
                n1 = random.Next() % 12;
                n2 = 3+(random.Next() % 3);
                dur = random.Next() % 5;

                sheet.AddNote((Sheet.NOTE)(n1),n2,dur*100);
            }

            Sheet s2 = new Sheet(sheet);
            s2.ReplaceNote(0, Sheet.NOTE.C, 4, 200);
            s2.ReplaceNote(1, Sheet.NOTE.C, 4, 200);
            sheet.SetBar(s2);

            Sheet s3 = new Sheet(sheet);
            s3.ReplaceNote(0, Sheet.NOTE.B, 3, 200);
            s3.ReplaceNote(1, Sheet.NOTE.B, 3, 200);
            s2.SetBar(s3);

            Sheet s4 = new Sheet(sheet);
            s4.ReplaceNote(0, Sheet.NOTE.AS, 3, 200);
            s4.ReplaceNote(1, Sheet.NOTE.AS, 3, 200);
            s3.SetBar(s4);
#endregion
            Sheet sheet2 = sheet;
            //sheet2.AddNote()
            do
            {


                new Thread(sheet.Play).Start();
                for (char c = 'a'; c < 'z'; c++)
                {
                    Console.WriteLine(c + ", ");
                    Thread.Sleep(100);
                }
                Console.Clear();
                Console.Write("Type ''exit'' to exit to main menu:  ");
            } while (Console.ReadLine() != "exit");
            Console.Clear();
            state = "main_menu";
        }
        void NewSheet()
        {
            Console.Clear();

            customSheets = Book.GetBook();
            bool sheetCreated = false,addingNotes = true;
            Sheet sheet = new Sheet();

            while (!sheetCreated)
            {
                Console.WriteLine("Please enter the name of your new sheet, then press ENTER.");
                string sheet_name = Console.ReadLine();
                if (!customSheets.SheetExists(sheet_name))
                {
                    sheet.SetName(sheet_name);
                    customSheets.AddSheet(sheet);
                    sheetCreated = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have already created a sheet with this name. Please enter a new name");
                }
            }
            while (addingNotes)
            {
                Console.WriteLine("Please Enter the note you would like to add. The letter may be A-G, while you may pick between the 1st and 7th octave.\nONLY THE FIRST TWO CHARACTERS WILL BE CONSIDERED!");
                string pitch = Console.ReadLine();
                int _octave = 4;
                Console.WriteLine("Please Enter the duration of the note in seconds");
                string duration = Console.ReadLine();
                sheet.AddNote(pitch[0] + pitch[1] +"",_octave, Convert.ToInt32(duration));
            }
        }
    }/*
            #region notes in sheet 1

            sheet.AddNote(Sheet.NOTE.D, 4, 200);
            sheet.AddNote(Sheet.NOTE.D, 4, 200);
            sheet.AddNote(Sheet.NOTE.D, 5, 400);
            sheet.AddNote(Sheet.NOTE.A, 4, 800);
            sheet.AddNote(Sheet.NOTE.A, 1, 150);
            sheet.AddNote(Sheet.NOTE.GS, 4, 500);
            sheet.AddNote(Sheet.NOTE.G, 4, 400);
            sheet.AddNote(Sheet.NOTE.F, 4, 600);
            sheet.AddNote(Sheet.NOTE.D, 4, 200);
            sheet.AddNote(Sheet.NOTE.F, 4, 200);
            sheet.AddNote(Sheet.NOTE.G, 4, 200);

            Sheet s2 = new Sheet(sheet);
            s2.ReplaceNote(0, Sheet.NOTE.C, 4, 200);
            s2.ReplaceNote(1, Sheet.NOTE.C, 4, 200);
            sheet.SetBar(s2);

            Sheet s3 = new Sheet(sheet);
            s3.ReplaceNote(0, Sheet.NOTE.B, 3, 200);
            s3.ReplaceNote(1, Sheet.NOTE.B, 3, 200);
            s2.SetBar(s3);

            Sheet s4 = new Sheet(sheet);
            s4.ReplaceNote(0, Sheet.NOTE.AS, 3, 200);
            s4.ReplaceNote(1, Sheet.NOTE.AS, 3, 200);
            s3.SetBar(s4);
            #endregion
            */
}
