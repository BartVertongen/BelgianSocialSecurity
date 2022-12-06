//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class NaturalPersonUpdateNotifType
    {
        [XmlElement(DataType = "integer")]
        public string? NaturalPersonSequenceNbr;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        public string? NaturalPersonUserReference;

        [XmlElement(DataType = "integer")]
        public string? NaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonPID;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonVersionNbr;

        [XmlElement(DataType = "integer")]
        public string? DeclNaturalPersonNewVersionNbr;

        public Action Action;

        public BlockDecisionIndicator BlockDecisionIndicator;

        [XmlIgnore()]
        public bool BlockDecisionIndicatorSpecified;

        public RepaymentDecision RepaymentDecision;

        [XmlIgnore()]
        public bool RepaymentDecisionSpecified;
    }
}
