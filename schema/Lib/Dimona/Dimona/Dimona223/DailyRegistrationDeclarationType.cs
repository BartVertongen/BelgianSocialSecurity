//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DailyRegistrationDeclaration", Namespace = "", IsNullable = false)]
    public class DailyRegistrationDeclarationType
    {
        public AttestationStatus AttestationStatus;

        [XmlElement(DataType = "integer")]
        public string? DailyRegistrationId;

        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "date")]
        public DateTime StartingDate;

        [XmlIgnore()]
        public bool StartingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? StartingHour;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlIgnore()]
        public bool EndingDateSpecified;


        [XmlElement(DataType = "integer")]
        public string? EndingHour;
    }
}
