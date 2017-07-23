using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KnowledgeQuiz
{
    public class LinqToXMLObjectModel
    {
        public static string xmlDocUri = "C:\\Users\\Senex\\Documents\\Visual Studio 2015\\Projects\\MiniProjects\\KnowledgeQuiz\\KnowledgeQuiz\\Questions.xml";
        public static XDocument GetXmlInventory()
        {
            try
            {
                XDocument inventoryDoc = XDocument.Load(xmlDocUri);
                return inventoryDoc;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static void InsertNewElement(string question, string answer1, string answer2, string answer3, string answer4)
        {

            XDocument inventoryDoc = XDocument.Load(xmlDocUri);
                                               
            // For random id
            Random r = new Random();

            //Make new XElement 
            XElement newElement = new XElement("item", new XAttribute("id", r.Next(50000)),
                new XElement("question", question),
                new XElement("answer", answer1),
                new XElement("answer", answer2),
                new XElement("answer", new XAttribute("correct", "y"), answer3),
                new XElement("answer", answer4));

            inventoryDoc.Descendants("items").First().Add(newElement);

            inventoryDoc.Save(xmlDocUri);

        }

        public static void LookUpAnswers(string question)
        {
            XDocument inventoryDoc = XDocument.Load(xmlDocUri);

            var makeInfo = from item in inventoryDoc.Descendants("question")
                           where (string)item.Element("question") == question
                           select item.Element("answer").Value;

            string data = string.Empty;
            foreach (var item in makeInfo.Distinct())
            {
                data += string.Format("- {0}\n", item);
            }

            MessageBox.Show(data, string.Format("{0} answers: ", question));
        }
    }
}
