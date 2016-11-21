using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class AddresssDetails
    {
        [XmlAttribute("Number")]
         public int HouseNo { get; set; }
        [XmlElement("Street")]
        public string StreetName { get; set; }
        [XmlElement("CityName")]
        public string City { get; set; }

        [XmlIgnore]
        public Dictionary<string, string> AllSettings { get; set; }
        
    }
    
      public class Setting
    {
        public string Key;
        public string Value;
    }
}
