//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.PersonnelFileConsultationRequest223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReferencePeriod", Namespace = "", IsNullable = false)]
    public class ReferencePeriodType
    {
        [XmlElement(DataType = "date")]
        public DateTime RefStartingDate;

        [XmlIgnore()]
        public bool RefStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public DateTime RefEndingDate;

        [XmlIgnore()]
        public bool RefEndingDateSpecified;
    }
}
