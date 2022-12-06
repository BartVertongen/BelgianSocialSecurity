//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;

namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{

    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ActivationInformationAction", Namespace = "", IsNullable = false)]
    public class ActivationInformationActionType
    {
        [XmlElement(DataType = "date")]
        public DateTime ServiceExemptionStartDate;

        [XmlElement(DataType = "date")]
        public DateTime TrainingSituationStartDate;

        [XmlElement(DataType = "integer")]
        public string? TrainingSituation;

        public Action Action;
    }
}