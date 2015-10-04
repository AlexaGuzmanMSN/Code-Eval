using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtractAgainHTMLSep13
{
    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            StreamReader reader = new StreamReader("..\\..\\HTMLTest2.html");
            StreamWriter writer = new StreamWriter("..\\..\\ExtractedHTML2.txt");
            string line = reader.ReadLine();

            using (reader)
            {
                while (line != null)
                {
                    //Console.WriteLine();
                    //line = reader.ReadLine();

                    int start = line.IndexOf("<");
                    int end = line.IndexOf(">");

                    while (start != -1)
                    {
                        line = line.Remove(start, end - start + 1);
                        start = line.IndexOf("<");
                        end = line.IndexOf(">");
                    }
                    line = line.Trim();
                    if (line != "") ;
                    {
                        sb.AppendLine(line);
                    }
                    line = reader.ReadLine();
                }
            }
            using (writer)
            {
                writer.Write(sb.ToString());
                Console.WriteLine(sb.ToString());
            }
            Console.ReadLine();

        }

            //for (line = reader.ReadLine();
            //line != null; line = reader.ReadLine()) ;

        }
    }

