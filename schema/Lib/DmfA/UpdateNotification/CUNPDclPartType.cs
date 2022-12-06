//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CUNPDclPart", Namespace = "", IsNullable = false)]
    public class CUNPDclPartType
    {
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedAmount;

        [XmlElement(DataType = "integer")]
        public string? ContUnrelatedToNPNewVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? CodeSubjected;

        public Action Action;

        public BlockDecisionIndicator BlockDecisionIndicator;

        [XmlIgnore()]
        public bool BlockDecisionIndicatorSpecified;
    }
}
