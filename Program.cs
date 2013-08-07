using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To what number of rows and columns would you like to create a multiplication table?");
            int rowsAndColums = int.Parse(Console.ReadLine());
            MultiplicationTable m = new MultiplicationTable();
            string[] table = m.generateTable(rowsAndColums);
            Console.WriteLine();
            Console.WriteLine("Here your table:");
            Console.WriteLine();
            for (int i = 0; i < table.Length; i++)
                Console.WriteLine(table[i]);
            Console.ReadLine();
        }
    }

    public class MultiplicationTable
    {
        public string[] generateTable(int number)
        {
            string[] table = new string[number];
            int spaces = (number * number).ToString().Length + 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    table[i] += ((i + 1) * (j + 1)).ToString();
                    for (int a = 0; a < spaces - ((i + 1) * (j + 1)).ToString().Length; a++)
                        table[i] += " ";
                }
            }
            return table;
        }
    }
}
