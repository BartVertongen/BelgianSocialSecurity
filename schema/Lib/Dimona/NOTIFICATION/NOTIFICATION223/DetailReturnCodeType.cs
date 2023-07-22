// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.Dimona.NOTIFICATION.NOTIFICATION223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DetailReturnCodeType
    {
        public string? AnomalyClass;

        [XmlElement(DataType = "integer")]
        public string? ReasonCodeCBSS;

        public string? Justification;
    }
}