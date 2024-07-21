using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace QuizMaker
{
    public  class QuastionHandlarcs
    {
        public string loadXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\\Users\\Owner\\source\\repos\\QuizMaker\\QuizMaker\\Data\\Quiz.xml");
            string xmlcontents = doc.InnerXml;
            return xmlcontents;
        }
        public XDocument ReadXmlAndCatchErrors(string xml)
        {
            try
            {
                return XDocument.Parse(xml);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong:");
                Console.WriteLine(ex);
            }
            return new XDocument();
        }
    }

}
