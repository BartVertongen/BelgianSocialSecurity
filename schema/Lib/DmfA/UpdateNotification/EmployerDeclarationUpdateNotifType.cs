//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class EmployerDeclarationUpdateNotifType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("Trusteeship", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[]? Items;

        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[]? ItemsElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        public TransmissionMode TransmissionMode;

        [XmlElement(DataType = "integer")]
        public string? EmployerDeclarationPID;

        public FaultyCode FaultyCode;

        [XmlIgnore()]
        public bool FaultyCodeSpecified;

        public CalculationRequestArt54ter CalculationRequestArt54ter;

        [XmlIgnore()]
        public bool CalculationRequestArt54terSpecified;

        public Notion22Quater Notion22Quater;

        [XmlIgnore()]
        public bool Notion22QuaterSpecified;

        [XmlElement(DataType = "integer")]
        public string? EmployerDeclarationNewVersionNbr;

        public Action Action;
    }
}
