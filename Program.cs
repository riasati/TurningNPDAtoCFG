using System;
using System.Collections.Generic;

namespace TurningNPDAtoCFG
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            LinkedList<string> strList = new LinkedList<string>();
            for (int i = 0; i < n; i++)
            {
                string str = "q" + i;
                strList.AddLast(str);
            }
            string s = "";
            string c = "";
            while ((s = Console.ReadLine()) != "")
            {
                Rule a = new Rule(s);
                c += a.RuternGrammer(strList);
                c += "\n";
            }
            Console.WriteLine(c);
        }
    }
}
