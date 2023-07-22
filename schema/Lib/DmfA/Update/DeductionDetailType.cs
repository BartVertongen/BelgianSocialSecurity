// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Update223
{
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRoot("DeductionDetail", Namespace = "", IsNullable = false)]
    public class DeductionDetailType
    {
        [XmlElementAttribute(DataType = "integer")]
        public string? DeductionDetailSequenceNbr;

        [XmlElementAttribute(DataType = "integer")]
        public string? DeductionDetailAmount;

        public string? WorkingRegulationsRegistryNbr;

        [XmlElementAttribute(DataType = "date")]
        public System.DateTime WorkingRegulationsStartingDate;

        [XmlIgnoreAttribute()]
        public bool WorkingRegulationsStartingDateSpecified;

        [XmlElementAttribute(DataType = "integer")]
        public string? AverageWorkingTimeBeforeReduction;

        [XmlElementAttribute(DataType = "integer")]
        public string? AverageWorkingTimeAfterReduction;
    }
}