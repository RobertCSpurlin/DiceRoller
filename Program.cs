using System;

namespace Dice_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int dice;
            int ndice;
            int minroll = 0;
            int maxroll = 0;
            int dicemod;
            int diceroll;

        restart:

            Console.WriteLine("Please Select the Dice to Roll:");
            Console.WriteLine("1=d4, 2=d6, 3=d8, 4=d10, 5=d12, 6=d20, 7=d100, 8=Exit");
            Console.Write("Plese Enter Selection:");
            dice = Convert.ToInt32(Console.ReadLine());


            if (dice == 8)
                goto exit;
            else
            {
                diceinput:
                try
                {
                    Console.Write("Please Enter Number of Dice to Roll: ");
                    ndice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please Enter Roll Modifiers: ");
                    dicemod = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nINPUT ERROR\n\""+ e.Message+"\"\n");
                    goto diceinput;
                }
            }
        
            switch (dice)
            {
                case 1:
                    minroll = (1 * ndice);
                    maxroll = (4 * ndice);
                    break;
                case 2:
                    minroll = (1 * ndice);
                    maxroll = (6 * ndice);
                    break;
                case 3:
                    minroll = (1 * ndice);
                    maxroll = (8 * ndice);
                    break;
                case 4:
                    minroll = (1 * ndice);
                    maxroll = (10 * ndice);
                    break;
                case 5:
                    minroll = (1 * ndice);
                    maxroll = (12 * ndice);
                    break;
                case 6:
                    minroll = (1 * ndice);
                    maxroll = (20 * ndice);
                    break;
                case 7:
                    minroll = (1 * ndice);
                    maxroll = (100 * ndice);
                    break;
                case 8:
                    goto exit;

                default:
                    Console.WriteLine("Invalid Dice Selection");
                    break;
            }


            diceroll = rand.Next(minroll, maxroll);

            Console.WriteLine("\nYou rolled a {0} with a modifier of {1} for a total of {2}\n\n", diceroll, dicemod, (diceroll+dicemod));


          
            goto restart;

        exit:
            Console.WriteLine("Goodbye");
          

        }
    }
}
