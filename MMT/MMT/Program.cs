using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotLiquid;
using System.IO;
using System.Reflection;

namespace MMT
{
    class Program
    {
        static void Main(string[] args)
        {
            //read index file...
            if (args.Count() < 1)
            {
                Console.WriteLine("not enough arguments");
                return;
            }
            else
            {
                string indexFileName = Path.Combine(args[0], "index.html");
                string postsFolder = Path.Combine(args[0], "_posts");
                string layoutFolder = Path.Combine(args[0], "_layouts");

                if (!File.Exists(indexFileName) || !Directory.Exists(postsFolder) || !Directory.Exists(layoutFolder))
                {
                    Console.WriteLine("woops!");
                }
                else
                {
                    Template index = Template.Parse(File.ReadAllText(indexFileName));

                    //find posts
                    foreach (string post in Directory.GetFiles(postsFolder))
                    {

                    }


                    //
                }
            }
        }
    }
}
