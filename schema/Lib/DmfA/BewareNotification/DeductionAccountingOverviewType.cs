// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlRoot("DeductionAccountingOverview", Namespace = "", IsNullable = false)]
    public class DeductionAccountingOverviewType
    {
        [XmlElement(DataType = "integer")]
        public string? EmployerClass;

        [XmlElement(DataType = "integer")]
        public string? WorkerCode;

        [XmlElement(DataType = "integer")]
        public string? DeductionCode;

        [XmlElement(DataType = "integer")]
        public string? NbrOfWorkersInvolved;

        public string? SignedDeductionCalcBasis;

        public string? SignedDeductionAmount;
    }
}
