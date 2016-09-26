using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AddresssDetails details = new AddresssDetails();
            details.HouseNo = 4;
            details.StreetName = "Not available";
            details.City = "Pune";
            Serialize(details);
        }
        static public void Serialize(AddresssDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddresssDetails));
            using (TextWriter writer = new StreamWriter(@"d:\XmlSerialize.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
    }
}
