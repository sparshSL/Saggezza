using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Xml_manipulation
{
    class Program
    {

        static void Main(string[] args)
        {
            XDocument responceXML = XDocument.Load("responce.xml");
            decimal maintainance_cost = 12.00M;
            //XElement maintainanceNode = XElement.Load("Maintainance_node.xml");

            IEnumerable<XElement> RateResults = responceXML.Elements();

            //foreach (XElement rateResults in RateResults.Elements("PriceSheets").Elements("PriceSheet").Elements("Charges"))
            //{
            //    rateResults.Add(maintainanceNode);  
            //}
            int sequenceNum;
            XElement maintainanceNode = GenerateMaintainanceNode(maintainance_cost);
            IEnumerable<XElement> Pricesheets = RateResults.Elements("PriceSheets").Elements("PriceSheet");

            foreach (XElement rateResults in Pricesheets)
            {
                //maintainanceNode = GenerateMaintainanceNode(maintainance_cost);

                decimal AccessorialTotal = decimal.Parse(rateResults.Element("AccessorialTotal").Value) + maintainance_cost;
                rateResults.Element("AccessorialTotal").Value = AccessorialTotal.ToString();

                decimal Total = decimal.Parse(rateResults.Element("Total").Value) + maintainance_cost;
                rateResults.Element("Total").Value = Total.ToString();

                sequenceNum = rateResults.Elements("Charges").First().Elements("Charge").Count() + 1;
                maintainanceNode.Attribute("sequenceNum").Value = sequenceNum.ToString();
                rateResults.Element("Charges").Add(XElement.Parse(maintainanceNode.ToString()));
            }

            responceXML.Save("Responce_edited.xml");
            Console.ReadKey();
        }
        public static XElement GenerateMaintainanceNode(decimal maintainancecharge)
        {
            XElement maintainancenode = new XElement("Charge", new XAttribute("sequenceNum",""), new XAttribute("type", "ACCESSORIAL"), new XAttribute("itemGroupId", ""),
                new XElement("Description", "Maintanance Charge"),
                new XElement("EdiCode", ""),
                new XElement("Amount", maintainancecharge.ToString()),
                new XElement("Rate", maintainancecharge.ToString()),
                new XElement("RateQualifier", "FR"),
                new XElement("Quantity", ""),
                new XElement("Weight", "0.0"),
                new XElement("DimWeight", "0.0"),
                new XElement("FreightClass", "0.0"),
                new XElement("FakFreightClass", "0.0"),
                new XElement("IsMin", "false"),
                new XElement("IsMax", "false"),
                new XElement("IsNontaxable", "false")
                );
            return maintainancenode;
        }
    }
}
