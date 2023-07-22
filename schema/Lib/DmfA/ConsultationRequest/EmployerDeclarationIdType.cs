// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationRequest224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class EmployerDeclarationIdType
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

        public AnomalySubmission AnomalySubmission;

        [XmlIgnore()]
        public bool AnomalySubmissionSpecified;
    }
}
