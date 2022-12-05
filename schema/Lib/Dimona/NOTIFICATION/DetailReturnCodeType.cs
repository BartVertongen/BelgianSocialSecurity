// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION223
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