using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure
{
    internal class Program
    {
        //Insert amount of pages in new string[]
        static string[] pageText = new string[4];
        static string[] pageLines;

        static void Main(string[] args)
        {
            // pageText initialization. Page formate: Line 1,2,3; option 1; option 2; option 1 page; option 2 page
            pageText[0] = "Title Page; ; ;1;1";
            pageText[1] = "This is page one;You can go to page two or page Three;Go to page two;Go to page Three;2;3";
            pageText[2] = "This is page two;You can go to page one or page Three;Go to page one;Go to page Three;1;3";
            pageText[3] = "This is page Three;You can go to page two or page one;Go to page two;Go to page one;2;1";
            Update();

        }
        static void Update()
        {
            bool exit = false;
            int pageNumber = 1;
            while (exit != true)
            {
                //splits pageText into lines that can be printed
                pageLines = pageText[pageNumber].Split(';');
                //counts what line to print
                int pageLine = 0;
                // detirmins how many 
                int pageLenth = pageLines.Count();
                while ((pageLenth - 4) != pageLine)
                {
                    if (pageLine <= (pageLines.Length - 4))
                    {
                        Console.WriteLine(pageLines[pageLine]);
                    }
                    pageLine++;
                }
                OptionBox();
                int option1 = Convert.ToInt32(pageLines[(pageLines.Length - 2)]);
                int option2 = Convert.ToInt32(pageLines[(pageLines.Length - 1)]);
                pageNumber = PlayerController(option1 , option2);
            }
        }
        static void OptionBox()
        {
            
            Console.WriteLine(" ");
            Console.WriteLine("1 - " + pageLines[(pageLines.Length - 4)]);
            Console.WriteLine("2 - " + pageLines[(pageLines.Length - 3)]);
        }

        static int PlayerController(int option1, int option2)
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            bool aT = true;
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        return (option1);
                    case ConsoleKey.D2:
                        return (option2);
                    default:
                        return (option1);
                }
        }
    }
}
