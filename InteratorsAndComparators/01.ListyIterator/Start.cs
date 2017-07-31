namespace _01.ListyIterator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string inputLine;

            ListyIterator<string> iterator = null;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] tokens = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Create":

                        iterator = new ListyIterator<string>(tokens.Skip(1));
                        break;

                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;

                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;

                    case "Print":

                        try
                        {
                            Console.WriteLine(iterator.Print());

                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;

                    case "PrintAll":

                        foreach (string item in iterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}

            