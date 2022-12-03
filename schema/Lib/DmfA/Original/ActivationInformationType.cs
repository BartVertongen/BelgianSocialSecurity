
using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ActivationInformation", Namespace = "", IsNullable = false)]
    public class ActivationInformationType
    {
        [XmlElement(DataType = "date")]
        public DateTime ServiceExemptionStartDate;

        [XmlElement(DataType = "date")]
        public DateTime TrainingSituationStartDate;

        [XmlElement(DataType = "integer")]
        public string? TrainingSituation;
    }
}