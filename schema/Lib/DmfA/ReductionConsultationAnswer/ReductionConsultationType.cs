// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.ReductionConsultationAnswer224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    public class ReductionConsultationType
    {
        [XmlElement(DataType = "integer")]
        public string? ResultCodeResearch;
    }
}