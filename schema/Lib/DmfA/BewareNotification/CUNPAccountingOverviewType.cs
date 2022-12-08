// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("CUNPAccountingOverview", Namespace = "", IsNullable = false)]
    public class CUNPAccountingOverviewType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? UnrelatedWorkerCode;

        public string? SignedCUNPCalcBasis;

        public string? SignedCUNPAmount;
    }
}
