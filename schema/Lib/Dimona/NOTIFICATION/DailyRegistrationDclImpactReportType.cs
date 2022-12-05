// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public partial class DailyRegistrationDclImpactReportType
    {
        [XmlElement(DataType = "integer")]
        public string? DailyRegistrationId;


        [XmlElement(DataType = "integer")]
        public string? AttestationStatus;


        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;
    }
}
