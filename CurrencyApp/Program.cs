using System;
using System.IO;
using System.Xml;

namespace CurrencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");

            Console.WriteLine("EUROPEAN CENTRAL BANK - Euro foreign exchange reference rates");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
                Console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);

            Console.ReadKey();
        }


    }
}
