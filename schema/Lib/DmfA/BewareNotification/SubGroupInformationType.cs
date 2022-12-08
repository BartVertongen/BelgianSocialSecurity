// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class SubGroupInformationType
    {
        [XmlElement(DataType = "integer")]
        public string? SubGroup;

        public SubGroupDecisionIndicator SubGroupDecisionIndicator;

        [XmlIgnore()]
        public bool SubGroupDecisionIndicatorSpecified;

        [XmlElement(DataType = "integer")]
        public string? UserQuality;

        public string? Justification;

        [XmlElement(DataType = "integer")]
        public string? JustificationCode;

        [XmlElement(DataType = "date")]
        public DateTime JustificationDate;

        [XmlIgnore()]
        public bool JustificationDateSpecified;
    }
}
