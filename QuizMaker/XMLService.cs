using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace QuizMaker
{
    public class XMLService
    {
        public XDocument Doc;
        public XElement Root;
        public string Path;
        public XMLService(string path)
        {
            Path = path;
            Doc = XDocument.Load(path);
            Root= Doc.Root?? throw new Exception("no root element found!");

        }
        public void CreateNewQA(string q, string a)
        {
            XElement item = new XElement("Item",
              new XElement("Question", q),
              new XElement("Answer", a)
              );
        }
        public List<XElement> ReadAllQA()
        {
            return Doc.Root.Elements().ToList();
        }
    }
}
