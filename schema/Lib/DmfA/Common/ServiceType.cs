//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Common
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("Service", Namespace = "", IsNullable = false)]
    public class ServiceType
    {
        [XmlElement(DataType = "integer")]
        public string? ServiceSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? ServiceCode;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrDays;

        [XmlElement(DataType = "integer")]
        public string? ServiceNbrHours;

        [XmlElement(DataType = "integer")]
        public string? FlightNbrMinutes;
    }
}