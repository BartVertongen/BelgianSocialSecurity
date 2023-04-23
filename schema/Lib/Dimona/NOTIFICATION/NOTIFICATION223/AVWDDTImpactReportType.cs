// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.NOTIFICATION.NOTIFICATION223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class AVWDDTImpactReportType
    {
        [XmlElement("CompanyID", typeof(string), DataType = "integer")]
        [XmlElement("ForeignCompanyID", typeof(string))]
        [XmlElement("VATNbr", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string? Item;

        [XmlIgnore()]
        public ItemChoiceType8 ItemElementName;

        public string? Denomination;
    }
}