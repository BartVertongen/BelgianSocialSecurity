// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("LastSituationWR", Namespace = "", IsNullable = false)]
    public class LastSituationWRType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordVersionNbr;
    }
}