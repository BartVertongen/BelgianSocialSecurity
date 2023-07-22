// By Bart Vertongen April 2023.

using System.IO.Abstractions.TestingHelpers;
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona.Dimona231.Tests
{
    public class Dimona231Example1Fixature
    {
		private Dimona? oDimona231;

		/// <summary>
		/// The Constructor will be used forinitialization of the test and Fixatures.
		/// </summary>
		public Dimona231Example1Fixature()
        {
			MockFileSystem? oFileSystem;
			string sFileName = @"Dimona_20231_1.xml";
			string sExample1;

            sExample1 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n";
            sExample1 += "<Dimona xsi:noNamespaceSchemaLocation=\"Dimona_20231.xsd\" ";
            sExample1 +=   "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n";
            sExample1 += "\t<Form>\r\n";
            sExample1 += "\t\t<Identification>DIMONA</Identification>\r\n";
            sExample1 += "\t\t<FormCreationDate>2023-02-06</FormCreationDate>\r\n";
            sExample1 += "\t\t<FormCreationHour>14:35:00.000</FormCreationHour>\r\n";
            sExample1 += "\t\t<AttestationStatus>0</AttestationStatus>\r\n";
            sExample1 += "\t\t<TypeForm>SU</TypeForm>\r\n";
            sExample1 += "\t\t<Reference>\r\n";
            sExample1 += "\t\t\t<ReferenceType>1</ReferenceType>\r\n";
            sExample1 += "\t\t\t<ReferenceOrigin>1</ReferenceOrigin>\r\n";
			sExample1 += "\t\t\t<ReferenceNbr>string</ReferenceNbr>\r\n";
            sExample1 += "\t\t</Reference>\r\n";
            sExample1 += "\t\t<DimonaIn>\r\n";
            sExample1 += "\t\t\t<StartingDate>2023-02-08</StartingDate>\r\n";
            sExample1 += "\t\t\t<EndingDate>2023-02-08</EndingDate>\r\n";
            sExample1 += "\t\t\t<EmployerId>\r\n";
            sExample1 += "\t\t\t\t<NOSSRegistrationNbr>175110801</NOSSRegistrationNbr>\r\n";
            sExample1 += "\t\t\t</EmployerId>\r\n";
            sExample1 += "\t\t\t<NaturalPerson>\r\n";
            sExample1 += "\t\t\t\t<INSS>01410199955</INSS>\r\n";
            sExample1 += "\t\t\t</NaturalPerson>\r\n";
            sExample1 += "\t\t\t<DimonaFeatures>\r\n";
            sExample1 += "\t\t\t\t<JointCommissionNbr>XXX</JointCommissionNbr>\r\n";
            sExample1 += "\t\t\t\t<WorkerType>TRI</WorkerType>\r\n";
            sExample1 += "\t\t\t</DimonaFeatures>\r\n";
            sExample1 += "\t\t</DimonaIn>\r\n";
            sExample1 += "\t</Form>\r\n";
            sExample1 += "</Dimona>";
			oFileSystem = new MockFileSystem(new Dictionary<string, MockFileData>
					{
						{sFileName, new MockFileData(sExample1)}
					});
			MockFile oMockFile = new(oFileSystem);
			XmlSerializer oSerializer = new XmlSerializer(typeof(Dimona));

            using (Stream reader = oMockFile.Open(sFileName, FileMode.Open))
            {
                oDimona231 = oSerializer.Deserialize(reader) as Dimona;
            }
		}

		[Fact]
        public void Dimona231_Example1_IdentificationShouldBeDIMONA()
        {
            //Arrange
            string sIdentification;

			//Act
			sIdentification = oDimona231.Form.First().Identification.ToString();

            //Assert
            Assert.True(sIdentification == "DIMONA");
		}

		[Fact]
		public void Dimona231_Example1_FormCreationDateShouldBe_2023_02_06()
		{
			//Arrange
			string sCreationDate;

			//Act
			sCreationDate = oDimona231.Form.First().FormCreationDate.ToString("yyyy-MM-dd");

			//Assert
			Assert.True(sCreationDate == "2023-02-06");
		}

		[Fact]
		public void Dimona231_Example1_FormCreationHourShouldBe_14_35_00_000()
		{
			//Arrange
			string sCreationHour;

			//Act
			sCreationHour = oDimona231.Form.First().FormCreationHour.ToString("HH:mm:ss.fff");

			//Assert
			Assert.True(sCreationHour == "14:35:00.000");
		}

		/// <remarks>AttestationStatus zero means Original declaration</remarks>
		[Fact]
		public void Dimona231_Example1_AttestationStatusShouldBe_0()
		{
			//Arrange
			string sAttestationStatus;

			//Act
			sAttestationStatus = oDimona231.Form.First().AttestationStatus.ToString();

			//Assert
			Assert.True(sAttestationStatus == "Original");
		}

		[Fact]
		public void Dimona231_Example1_TypeFormShouldBe_SU()
		{
			//Arrange
			string sTypeForm;

			//Act
			sTypeForm = oDimona231.Form.First().TypeForm.ToString();

			//Assert
			Assert.True(sTypeForm == "SU");
		}

		[Fact]
		public void Dimona231_Example1_ReferenceTypeShouldBe_One()
		{
			//Arrange
			string sReferenceType;

			//Act
			sReferenceType = oDimona231.Form.First().Reference[0].ReferenceType1.ToString();

			//Assert
			Assert.True(sReferenceType == "ReferenceToThisForm");
		}

		[Fact]
		public void Dimona231_Example1_ReferenceOriginShouldBe_One()
		{
			//Arrange
			string sReferenceOrigin;

			//Act
			sReferenceOrigin = oDimona231.Form.First().Reference[0].ReferenceOrigin.ToString();

			//Assert
			Assert.True(sReferenceOrigin == "Declarant_or_Requester");
		}

		[Fact]
		public void Dimona231_Example1_ReferenceNbrShouldBe_string()
		{
			//Arrange
			string? sReferenceNbr;

			//Act
			sReferenceNbr = oDimona231.Form.First().Reference[0].ReferenceNbr;

			//Assert
			Assert.True(sReferenceNbr == "string");
		}


	}
}