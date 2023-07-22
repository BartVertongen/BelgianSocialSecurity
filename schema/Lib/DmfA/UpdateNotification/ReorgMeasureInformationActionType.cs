//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.UpdateNotification223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReorgMeasureInformationAction", Namespace = "", IsNullable = false)]
    public class ReorgMeasureInformationActionType
    {
        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasure;

        [XmlElement(DataType = "integer")]
        public string? ReorganisationMeasurePercentage;

        public Action Action;
    }
}