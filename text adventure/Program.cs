using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_adventure
{
    internal class Program
    {
        static int page = 0;

        static ConsoleKeyInfo playerInput = Console.ReadKey(true);
        static void Main(string[] args)
        {
            bool keyPressed = false;
            Console.WriteLine("Hello");
            Console.ReadKey();
            while(keyPressed != true)
            {
                switch (playerInput.Key)
                {
                    case ConsoleKey.D1:
                        keyPressed = true;
                        break;
                    case ConsoleKey.D2:
                        keyPressed = true;
                        break;
                    default:
                        keyPressed = false;
                        Console.WriteLine(playerInput.Key + " is not a vaild input");
                        break;
                }

            }
        }
        //updates the text on screen based on player input
        static void Update()
        {
            StoryText();

        }
        //Prints story text 
        static void StoryText()
        {
            switch(page)
            {
                case 0:
                    Console.WriteLine("Title page");
                    break ;
                case 1:
                    Console.WriteLine("Page 1");
                    break;
                case 2:
                    Console.WriteLine("Page 2");
                    break;
                case 3:
                    Console.WriteLine("Page 3");
                    break;
                case 4:
                    Console.WriteLine("Page 4");
                    break;
                case 5:
                    Console.WriteLine("Page 5");
                    break;
                default :
                    Console.WriteLine("Invaild Page");
                    break;
            }

        }
        static void ActionText()
        {
            switch(page)
            {
                case 0:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;

                case 1:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;
                case 2:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;
                case 3:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;
                case 4:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;
                case 5:
                    Console.WriteLine("1 - Go to page");
                    Console.WriteLine("2 - Go to page");
                    Console.WriteLine("3 - Save");
                    Console.WriteLine("4 - Load ");
                    Console.WriteLine("5 - Quit");
                    break;
                default:
                    Console.WriteLine("Invaild Page");
                    break;
            }
        }
        static void PlayerInput()
        {

        }
    }
}
