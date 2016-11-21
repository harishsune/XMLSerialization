using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {

            //AddresssDetails details = new AddresssDetails();
            //details.HouseNo = 4;
            //details.StreetName = "Not available";
            //details.City = "Pune";
            //Serialize(details);1
            Deserialize();
        }
        static public void Serialize(AddresssDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddresssDetails));
            using (TextWriter writer = new StreamWriter(@"d:\XmlSerialize.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }

        static public object Deserialize()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddresssDetails));
            StreamReader oStream = new StreamReader(@"d:\XmlSerialize.xml");
            AddresssDetails oAddressDetails = ( AddresssDetails)serializer.Deserialize(oStream);
         //   return oAddressDetails;

            var xdoc = XDocument.Load(@"d:\XmlSerialize.xml");
           
           
            oAddressDetails.AllSettings = xdoc.Descendants("AppSettings").Descendants("Setting").ToDictionary(x => (string)x.Attribute("Key"), x =>
            {
                var value= (string)x.Attribute("Value");
                return value;
            }
            );
            return oAddressDetails;
        }
    }
}
