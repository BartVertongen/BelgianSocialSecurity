// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;

namespace Schemas.Lib.Dimona.NOTIFICATION.NOTIFICATION223
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
