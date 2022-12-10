//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.PID224;


namespace VertSoft.BelgianSocialSecurity.IntegrationTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Deserialize of DmfAPID224!");
            DeserializeDmfAPID("DmfAPID_20224_1.xml");
        }

        static private void DeserializeDmfAPID(string filename)
        {
            DmfAPID? oDmfAPID22401;
            XmlSerializer oSerializer = new XmlSerializer(typeof(DmfAPID));

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                oDmfAPID22401 = oSerializer.Deserialize(reader) as DmfAPID;
            }
        }
    }
}