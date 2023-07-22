//By Bart Vertongen Dec 2022.

using System.Xml.Serialization;
using VertSoft.BelgianHR.Xml.DmfA.Common;


namespace VertSoft.BelgianHR.Xml.DmfA.Original223
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class WorkerRecord : WorkerRecordType
    {
        [XmlElement("ActivationInformation", typeof(ActivationInformationType))]
        [XmlElement("ComplementaryIndemnity", typeof(ComplementaryIndemnity))]
        [XmlElement("DismissedStatutoryWorkerContribution", typeof(DismissedStatutoryWorkerContributionType))]
        [XmlElement("EarlyRetirementContribution", typeof(EarlyRetirementContributionType))]
        [XmlElement("IndemnityWAPM", typeof(IndemnityWAPMType))]
        [XmlElement("Occupation", typeof(Occupation))]
        [XmlElement("StudentContribution", typeof(StudentContributionType))]
        [XmlElement("WorkerContribution", typeof(WorkerContributionType))]
        [XmlElement("WorkerDeduction", typeof(WorkerDeduction))]
        public object[]? Items;
    }
}