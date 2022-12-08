// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ConsultationRequest224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ContributionUnrelatedToNPId", Namespace = "", IsNullable = false)]
    public class ContributionUnrelatedToNPIdType
    {
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;
    }
}
