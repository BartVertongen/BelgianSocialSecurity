// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.PersonnelFileConsultationAnswer.PersonnelFileConsultationAnswer223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class PersonnelFileConsultType
    {
        [XmlElement("NOSSLPARegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("NOSSRegistrationNbr", typeof(string), DataType = "integer")]
        [XmlElement("ProvisionalNSSONbr", typeof(string), DataType = "integer")]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType2? ItemElementName;

        [XmlElement(DataType = "integer")]
        public string? CompanyID;

        [XmlElement(DataType = "date")]
        public DateTime? RefStartingDate;

        [XmlIgnore()]
        public bool RefStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime RefEndingDate;

        [XmlIgnore()]
        public bool RefEndingDateSpecified;

        public ResultCodeResearch ResultCodeResearch;
    }
}
