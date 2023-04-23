// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.NOTIFICATION.NOTIFICATION223
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