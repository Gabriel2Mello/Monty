using System;

namespace Monty
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, np, n1, n2, n3, ganha1, perca1, ganha2, perca2;

            //números aleatórios (stime)
            Random randNum = new Random();
            randNum.Next();

            ganha1 = 0;
            perca1 = 0;
            ganha2 = 0;
            perca2 = 0;

            for (i = 0; i < 100; i++)
            {
                np = RandomNumber(1, 4);

                n1 = RandomNumber(1, 4);

                do
                {
                    n2 = RandomNumber(1, 4);
                } while ((n2 == n1) || (n2 == np));

                if (n1 == np)
                    ganha1++;
                else
                    perca1++;

                if ((np != 1) && (n2 != 1))
                {
                    if (np == 1)
                        ganha2++;
                    else
                        perca2++;
                    n3 = 1;
                }
                else if ((n1 != 2) && (n2 != 2))
                {
                    if (np == 2)
                        ganha2++;
                    else
                        perca2++;

                    n3 = 1;
                }
                else
                {
                    if (np == 3)
                        ganha2++;
                    else
                        perca2++;

                    n3 = 3;
                }

                Console.WriteLine(String.Format("{0} {1} {2} {3} {4} {5} {6} {7}\n", np, n1, n2, n3, ganha1, perca1, ganha2, perca2));
            }

        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

    }
}
