using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lola
{
    public class FileContent
    {
        public static void Main(string[] args)
        {
            try
            {
                try
                {
                    foreach (string s in args)
                    {
                        try
                        {
                            if (Path.GetExtension(args[0]).Equals(".txt"))
                            {
                                using (StreamReader sr = new StreamReader(args[0]))
                                {
                                    string line = sr.ReadToEnd();
                                    Console.WriteLine(line);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid text file name");
                            }

                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        while (keyInfo.Key != ConsoleKey.Enter)
                            keyInfo = Console.ReadKey();
                    }

                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

