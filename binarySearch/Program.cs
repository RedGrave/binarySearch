using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static int[] regenerateTree(int nbrOfNbr, int max)
        {
            Random rand = new Random();
            int[] data = new int[nbrOfNbr];
            for(int i = 0; i < nbrOfNbr; i++)
            {
                data[i] = rand.Next() % max;
            }
            return data;
        }

        static void askQuestion(Node n)
        {
            Console.WriteLine("READY!");
            while(true)
            {
                string s = Console.ReadLine().ToString();
                if (s == "exit") break;

                int srch;
                if(int.TryParse(s, out srch))
                {
                    int result = n.searchNode(srch, 0);
                    if(result != 0)
                    {
                        Console.WriteLine("FOUND ! STEP : " + result);
                    }

                    else
                    {
                        Console.WriteLine("NOT FOUND !");
                    }
                }
                else
                {
                    Console.WriteLine("Failed to parse number");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] data = regenerateTree(1000000, 10000);
            RootNode rn = new RootNode();
            Node n = rn.populateTree(data);

            askQuestion(n);
            
        }
    }
}
