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
        static string[] pageText = new string[1000];
        static string[] pageLines;
        //edit this value to change what number the endpages start at
        static int endPageNumber = 500;
        //edit this value to change what page the title is on
        static int startPageNumber = 0;
        //the starting page number will allways be that of the title page
        static int pageNumber = 0;

        static void Main(string[] args)
        {
            // pageText initialization. Page formate: Line 1,2,3; option 1; option 2; option 1 page; option 2 page
            // by defualt pageText[0] is always a title page while any pageText[] over 500 will be an end page. if needed these values can be edited by changing the "endPageNumber" and "startPageNumber" respectively
            pageText[0] = "Title Page;Start;Start;1;1";
            pageText[1] = "You wake your head still groggy from the night before;you reach over to the glass of water you keep by the bed;as you are reaching for the water you hear a group of songbirds;singing their song hearing this snaps out of the grogginess you were feeling just a moment; before as you look around you realise you are not in your room. You are not in your house.;You seem to have woken up in the middle of the forest;Get up and figure out where you are ;Go back to sleep;2;501";
            pageText[2] = "You slowly get up looking around trying to get your bearing together; in the distance, you can see a river. walking over to the river you are left with a choice; go upstream or downstream;go upstream;Go downstream;502;4";
            pageText[3] = "You wake your head still groggy from the night before;you reach over to the glass of water you keep by the bed;as you are reaching for the water you hear a group of songbirds;singing their song hearing this snaps out of the grogginess you were feeling just a moment before;“Not again” you think to yourself;You seem to have woken up in the middle of the forest;Get up and figure out where you are ;Go back to sleep;2;501";
            pageText[4] = "You walk alongside the river eventually coming to a splitting path;You wonder to yourself “which path do I go down?”;Go down the left path; go down the right path;503;5";
            pageText[5] = "As you walk down the right path you come across a bridge;This bridge was over a bottomless pit;You don’t know if the pit was actually bottomless but you do you know is that you can’t see the bottom;The bridge looks old, wooden, rickety and is likely unable to hold your weight;But crossing may be the only way back to civilization;Cross the bridge;Don’t cross the bridge;504;6";
            pageText[6] = " As you walk down the right path you come across a bridge;This bridge was over a bottomless pit;You don’t know if the pit was actually bottomless but you do you know is that you can’t see the bottom;The bridge looks old, wooden, rickety and is likely unable to hold your weight;But crossing may be the only way back to civilization;Cross the bridge;Don’t cross the bridge;505;7";
            pageText[7] = "As you try and find a way around the pit you see a road in the distance;An honest to goodness road;You rush over excited at the thought of escape;But you stop right before the edge of forest;You think to yourself “Do I really want to leave this forest and all my memories hear”;Leave;Stay;506;507";
            pageText[501] = "You close your eyes hoping this was all a bad dream; you soon fall asleep however the true nightmare would begin;You wake up to the sound of an alarm blaring you look around your surroundings;you find yourself in a metal pod filled with a mysterious liquid;Wires and tubes are connected to various parts different parts of your body; you try to move but quickly discover that you paralyzed from the neck down;A few moments later the liquid drains from the pod;as the liquid drains you begin to feel the return of your motor functions; once the pod is drained your able to force your way out;Once out you look around and see hundreds if not thousands of more pods all in a warehouse-like structure;Your determined to find out the cause of all of this but feel like there isn’t enough time;”How silly” you think to yourself ”I got all the time in the wor;THE END; ending [1/6]: simulation end;;;1;1";
            pageText[502] = "You walk upstream eventually coming to the source of the river;A perfectly circular pound with unnaturally deep blue water;Although just seconds before you felt fine now you find yourself overcome with a deep thirst.;you try to resist the thirst but soon give in to your desires;gathering water from the pound in your hands you as much water as you can.; after a few handfuls the thirst subsides and you try to stand up;You suddenly feel weak in the knees and sick to your stomach;You take a step forward but quickly collapse to the cold ground below;Unfortunately you are about to learn firsthand the dangers of drinking from a strange water source;THE END; ending [2/6]: dysentery end;;;3;1";
            pageText[503] = "As you walk down the left path you start noticing something strange; you begin to suspect that you have been going in circles;To test this theory you tear off a piece of your favourite shirt and tie it to a tree;Sure enough you eventually find yourself at the same tree with the old shirt tied to it;You start retracing your steps looking for any place you could have entered this strange looping path; you end up back at the tree with the shirt;Out of frustration you start sprinting into the woods;Much to your dismay you end up back at the tree;You resign yourself to your fate and start walking along the path once again…;THE END;ending[3/6] lost in the loop end;;;3;1";
            pageText[504] = "You only make it halfway across the bridge before the bridge starts crumbling to dust;You try to quickly make your way back but it was no use;After one wrong step a plank breaks under you sending you down into the pit;You don’t know if the pit was actually bottomless but you figure you’re about to find out;THE END;ending[4/6];;;3;3";
            pageText[505] = "You escape the woods and move on with your life;But you always think back to the woods and what could have been;THE END;ending[6/6];;;3;3";
            pageText[506] = "You decide to stay dedicating your life to the forest;THE END;ending[5/6];;;3;3";
            Update();

        }
        static void Update()
        {
            bool exit = false;
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
                PlayerController(option1, option2);
                Console.Clear();
            }
        }
        static void OptionBox()
        {
            if(pageNumber == startPageNumber)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Quit Game");
            }
            else if (pageNumber > startPageNumber && pageNumber < endPageNumber)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1 - " + pageLines[(pageLines.Length - 4)]);
                Console.WriteLine("2 - " + pageLines[(pageLines.Length - 3)]);
                Console.WriteLine("3 - Quit Game");
            }
            else if(pageNumber >= endPageNumber)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Quit Game");
            }
        }

        static void PlayerController(int option1, int option2)
        {
            ConsoleKeyInfo input;
            bool aT = true;
            while(aT == true)
            {
                input = Console.ReadKey(true);
                if (pageNumber == startPageNumber)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            pageNumber = 1;
                            aT = false;
                            break;
                        case ConsoleKey.D2:
                            System.Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("invaild option");
                            aT = true;
                            break;
                    }
                }
                else if (pageNumber > startPageNumber && pageNumber < endPageNumber)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            pageNumber = option1;
                            aT = false;
                            break;
                        case ConsoleKey.D2:
                            pageNumber = option2;
                            aT = false;
                        break;
                        case ConsoleKey.D3:
                            System.Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("invaild option");
                            aT = true;
                            break;
                    }

                }
                else if (pageNumber >= endPageNumber)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.D1:
                            pageNumber = option1;
                            aT = false;
                            break;
                        case ConsoleKey.D2:
                            System.Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("invaild option");
                            aT = true;
                            break;
                    }
                }

            }
        }
    }
}
