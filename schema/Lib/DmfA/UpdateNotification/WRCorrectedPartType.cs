//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class WRCorrectedPartType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "date")]
        public DateTime NOSSQuarterStartingDate;

        [XmlElement(DataType = "date")]
        public DateTime NOSSQuarterEndingDate;

        [XmlElement(DataType = "integer")]
        public string? Border;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public string? WorkerRecordUserReference;

        [XmlElement(DataType = "integer")]
        public string? WorkerRecordNewVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? CodeSubjected;

        public Action Action;
    }
}
