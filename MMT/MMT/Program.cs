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
            
            string indexFileName = "index.html";
            string postsFolder = "_posts";
            string layoutFolder = "_layouts";

            if (!File.Exists(indexFileName) || !Directory.Exists(postsFolder) || !Directory.Exists(layoutFolder))
            {
                Console.WriteLine("woops!");
            }
            else
            {
                Template index = Template.Parse(File.ReadAllText(indexFileName));
                
                //find posts
                //get template for posts
                //
            }
        }
    }
}
