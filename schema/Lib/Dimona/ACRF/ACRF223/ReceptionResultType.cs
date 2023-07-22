
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.ACRF.ACRF223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReceptionResult", Namespace = "", IsNullable = false)]
    public class ReceptionResultType
    {
        [XmlElement(DataType = "integer")]
        public string? ResultCode;

        [XmlElement("ErrorID")]
        public string[]? ErrorID;
    }
}
