// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class BewareInformationType
    {
        [XmlElement(DataType = "integer")]
        public string? NOSSRegistrationNbr;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "date")]
        public DateTime ProcessingDate;

        public UserQualityClass UserQualityClass;

        public CalculationRequestArt54ter CalculationRequestArt54ter;

        [XmlIgnore()]
        public bool CalculationRequestArt54terSpecified;

        public FaultyCode FaultyCode;

        [XmlIgnore()]
        public bool FaultyCodeSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? JustificationCode;

        public Notion22Quater Notion22Quater;

        [XmlIgnore()]
        public bool Notion22QuaterSpecified;
    }
}
