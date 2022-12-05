// By Bart Vertongen Nov 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.Dimona.Common;


namespace VertSoft.BelgianHR.Xml.NOTIFICATION223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class HandlingResultType
    {
        [XmlElement(DataType = "integer")]
        public string? ResultCode;

        [XmlElement("Diagnosis", DataType = "integer")]
        public string[]? Diagnosis;
    }
}