//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("ContributionUnrelatedToNP", Namespace = "", IsNullable = false)]
    public class ContributionUnrelatedToNPType
    {
        [XmlElement(DataType = "integer")]
        public string? UnrelatedEmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedCalculationBasis;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedAmount;
    }
}