//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.PID224;
using Dimona223 = VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona223;
using Dimona231 = VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231;


namespace VertSoft.BelgianSocialSecurity.IntegrationTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/*Console.WriteLine("Test Deserialize of DmfAPID224!");
            DeserializeDmfAPID("DmfAPID_20224_1.xml");*/

			/*Console.WriteLine("Test Deserialize of Dimona223!");
            DeserializeDimona223("Dimona_20223_1.xml");*/

			/*Console.WriteLine("Test Deserialize of Dimona231 voorbeeld 1!");
			DeserializeDimona231("Dimona_20231_1.xml");*/

			//REM: In EmployerId we can not get the number of NOSSRegistrationNbr
			//REM: EmployerId works fine if we keep the namespace empty
			Console.WriteLine("Test Deserialize of Dimona231 voorbeeld 2!");
			DeserializeDimona231("Dimona_20231_2.xml");

			Console.WriteLine("Test Deserialize of Dimona231 voorbeeld 3!");
			DeserializeDimona231("Dimona_20231_3.xml");
		}



		static private void DeserializeDimona231(string filename)
		{
			Dimona231.Dimona? oDimona231;
			XmlSerializer oSerializer = new XmlSerializer(typeof(Dimona231.Dimona));

			using (Stream reader = new FileStream(filename, FileMode.Open))
			{
				oDimona231 = oSerializer.Deserialize(reader) as Dimona231.Dimona;
			}
		}

		static private void DeserializeDimona223(string filename)
		{
			Dimona223.Dimona? oDimona223;
			XmlSerializer oSerializer = new XmlSerializer(typeof(Dimona223.Dimona));

			using (Stream reader = new FileStream(filename, FileMode.Open))
			{
				oDimona223 = oSerializer.Deserialize(reader) as Dimona223.Dimona;
			}
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