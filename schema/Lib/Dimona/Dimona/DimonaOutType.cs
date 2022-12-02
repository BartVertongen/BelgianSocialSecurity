//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaOutType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "date")]
        public DateTime EndingDate;

        [XmlElement(DataType = "integer")]
        public string? INSS;
    }
}
