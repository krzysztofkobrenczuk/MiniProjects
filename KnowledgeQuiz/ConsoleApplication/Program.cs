using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument myDoc = XDocument.Load("C:\\Users\\Senex\\Documents\\Visual Studio 2015\\Projects\\MiniProjects\\KnowledgeQuiz\\KnowledgeQuiz\\Questions.xml");
            Console.WriteLine(myDoc);

            Console.ReadKey();
        }
    }
}
