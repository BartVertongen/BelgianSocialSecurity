//By Bart Vertongen Nov 2022.

using System.Xml.Serialization;


namespace Schemas.Lib.Dimona.Dimona.Dimona223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class DimonaCancelType
    {
        [XmlElement(DataType = "integer")]
        public string? DimonaPeriodId;

        [XmlElement(DataType = "integer")]
        public string? INSS;
    }
}