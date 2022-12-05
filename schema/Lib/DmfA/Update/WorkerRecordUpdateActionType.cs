// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class WorkerRecordUpdateActionType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? EmployerClass;

        [XmlElementAttribute(DataType = "integer")]
        public string? WorkerCode;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime NOSSQuarterStartingDate;

        [XmlIgnoreAttribute()]
        public bool NOSSQuarterStartingDateSpecified;

        [XmlElement(DataType = "date")]
        public System.DateTime NOSSQuarterEndingDate;

        [XmlIgnore()]
        public bool NOSSQuarterEndingDateSpecified;

        [XmlElement(DataType = "integer")]
        public string? Border;

        [XmlElement(DataType = "integer")]
        public string? ActivityWithRisk;

        [XmlElement(DataType = "integer")]
        public string? LocalUnitID;

        public string? WorkerRecordUserReference;

        public UpdateAction UpdateAction;
    }
}
