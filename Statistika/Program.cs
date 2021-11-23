using System;

namespace Statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string numbers = "0123456789";
            string text = "";
            int rowNumber = 0;
            do
            {
                keyInfo = Console.ReadKey(true);       //Zachycení stisknuté
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //když uživatel zmáčkne Enter
                    Console.WriteLine();
                    rowNumber++;
                    text = "";
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    //když uživatel zmáčkne Backspace
                    //přepíšu řádek mezerama - počet podle délky textu
                    Console.SetCursorPosition(0, rowNumber);
                    Console.Write(new string(' ', text.Length));
                    

                    //zkrátím text
                    text = text.Substring(0, text.Length - 1);

                    //napíšu zkrácený text
                    Console.SetCursorPosition(0, rowNumber);
                    Console.Write(text);
                }
                else if (numbers.Contains(keyInfo.KeyChar))
                {
                    //když uživatel napsal čislici
                    text += keyInfo.KeyChar;
                    Console.SetCursorPosition(0, rowNumber);
                    Console.Write(text);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
            
                
        }  
    }
}
