// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ReductionConsultationAnswer224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ReductionConsultationDetail", Namespace = "", IsNullable = false)]
    public class ReductionConsultationDetailType
    {
        [XmlElement(DataType = "integer")]
        public string? Quarter;

        [XmlElement(DataType = "integer")]
        public string? Trusteeship;

        [XmlElement(DataType = "integer")]
        public string? INSS;

        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "date")]
        public DateTime DeductionRightStartingDate;
    }
}