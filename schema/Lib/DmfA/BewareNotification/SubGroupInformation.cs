// By Bart Vertongen Dec 2022.

using System.Xml.Serialization;


namespace VertSoft.BelgianHR.Xml.DmfA.BewareNotification224
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class SubGroupInformation : SubGroupInformationType
    {
        [XmlElement("WorkerContAccountingOverview")]
        public WorkerContAccountingOverviewType[]? WorkerContAccountingOverview;

        [XmlElement("DeductionAccountingOverview")]
        public DeductionAccountingOverviewType[]? DeductionAccountingOverview;

        [XmlElement("CUNPAccountingOverview")]
        public CUNPAccountingOverviewType[]? CUNPAccountingOverview;
    }
}
